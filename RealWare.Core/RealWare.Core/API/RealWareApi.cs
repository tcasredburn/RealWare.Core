using Newtonsoft.Json.Linq;
using RealWare.Core.API.Connection;
using RealWare.Core.API.Exceptions;
using RealWare.Core.API.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace RealWare.Core.API
{
    /// <summary>
    /// Object for connecting and interacting with the RealWare API.
    /// </summary>
    public partial class RealWareApi : RealWareApiBase
    {
        /// <summary>
        /// The connection parameters for connecting to the API.
        /// </summary>
        public readonly RealWareApiConnection Connection;

        /// <summary>
        /// True if RealWare API key is available. Otherwise, false.
        /// </summary>
        public bool HasRealWareAuthentication => !string.IsNullOrEmpty(Connection.ApiKey);

        #region Constructor/Execution
        public RealWareApi(RealWareApiConnection connection) : base(connection.BaseUrl)
        {
            Connection = connection ?? throw new ArgumentNullException(nameof(connection));
        }
        public RealWareApi(HttpClient httpClient, RealWareApiConnection connection) : base(httpClient, connection.BaseUrl)
        {
            Connection = connection ?? throw new ArgumentNullException(nameof(connection));
        }
        /// <summary>
        /// Checks if a token is valid against the RealWare API.
        /// </summary>
        /// <param name="httpClient">An instance of <see cref="HttpClient"/> to be used for API calls.</param>
        /// <param name="apiUrl">URL of the RealWare API.</param>
        /// <param name="token">Token for the user to connect to the RealWare API.</param>
        /// <returns>True if authentication is valid; otherwise, false.</returns>
        public static async Task<bool> IsTokenValidAsync(HttpClient httpClient, string apiUrl, string token)
        {
            var api = new RealWareApi(httpClient, new RealWareApiConnection(apiUrl, token));
            return await api.IsAuthenticationValidAsync();
        }

        /// <summary>
        /// Synchronous version of ExecuteAsync.
        /// </summary>
        public T Execute<T>(string url, RWHttpVerb verb, object data = null)
            => ExecuteAsync<T>(url, verb, data).GetAwaiter().GetResult();
        /// <inheritdoc/>
        public override async Task<T> ExecuteAsync<T>(string url, RWHttpVerb verb, object data = null, CancellationToken cancellationToken = default)
        {
            if (!HasRealWareAuthentication)
                await AuthenticateAsync(cancellationToken: cancellationToken);

            AddAuthorization(Connection.ApiKey);
            return await base.ExecuteAsync<T>(url, verb, data, cancellationToken).ConfigureAwait(false);
        }
        /// <inheritdoc/>
        public override async Task<HttpResponseMessage> ExecuteWithResponseAsync(string url, RWHttpVerb verb, object data = null, CancellationToken cancellationToken = default)
        {
            if (!HasRealWareAuthentication)
                await AuthenticateAsync(cancellationToken: cancellationToken);

            AddAuthorization(Connection.ApiKey);
            return await base.ExecuteWithResponseAsync(url, verb, data, cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region Ping/Authentication
        /// <summary>
        /// Authenticates the user using the RealWare api and returns <see cref="AuthenticationResultDto"/>.
        /// </summary>
        /// <param name="username">RealWare login name. Uses <see cref="RealWareApiConnection"/> username if null.</param>
        /// <param name="password">RealWare password. Uses <see cref="RealWareApiConnection"/> password if null.</param>
        /// <param name="updateConnectionApiKey">Updates local connection api token when true. Default true.</param>
        /// <returns><see cref="RWAuthenticationResult"/></returns>
        /// <exception cref="ArgumentNullException">Username/password cannot be null in both function and <see cref="RealWareApiConnection"/></exception>
        public RWAuthenticationResult Authenticate(string username = null, string password = null)
            => AuthenticateAsync(username, password).GetAwaiter().GetResult();
        /// <summary>
        /// Authenticates the user using the RealWare API and updates the API key in the connection.
        /// </summary>
        /// <param name="username">RealWare login name. Uses <see cref="RealWareApiConnection"/> username if null.</param>
        /// <param name="password">RealWare password. Uses <see cref="RealWareApiConnection"/> password if null.</param>
        /// <returns><see cref="RWAuthenticationRequest"/></returns>
        /// <exception cref="ArgumentNullException">Username/password cannot be null in both function and <see cref="RealWareApiConnection"/></exception>
        public async Task<RWAuthenticationResult> AuthenticateAsync(string username = null, string password = null, CancellationToken cancellationToken = default)
        {
            string url = "api/authentication/token";

            username = username ?? Connection.Username;
            if (string.IsNullOrWhiteSpace(username))
                throw new ArgumentNullException(nameof(username), "Username cannot be null or empty.");

            password = password ?? Connection.Password;
            if (string.IsNullOrWhiteSpace(password))
                throw new ArgumentNullException(nameof(password), "Password cannot be null or empty.");

            var request = new RWAuthenticationRequest
            {
                Username = username,
                Password = password,
                GrantType = Constants.API_AUTHORIZATION_GRANT_TYPE
            };

            var result = await base.ExecuteAsync<RWAuthenticationResult>(url, RWHttpVerb.POST, request, cancellationToken).ConfigureAwait(false);

            if (result.Authenticated)
                Connection.SetApiKey(result.AccessToken);

            return result;
        }

        /// <summary>
        /// Synchronously pings the RealWare API.
        /// </summary>
        /// <returns></returns>
        public RWPingResponse Ping()
            => PingAsync().GetAwaiter().GetResult();
        /// <summary>
        /// Pings the RealWare API to ensure it is running.
        /// </summary>
        public async Task<RWPingResponse> PingAsync(CancellationToken cancellationToken = default)
        {
            string url = $"api/ping";
            return await ExecuteAsync<RWPingResponse>(url, RWHttpVerb.GET, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Synchronously tests if the authentication token is valid.
        /// </summary>
        /// <returns>True if authenticated request is valid, OW false.</returns>
        public bool IsAuthenticationValid()
            => IsAuthenticationValidAsync().GetAwaiter().GetResult();
        /// <summary>
        /// Tests if the authentication token is valid.
        /// </summary>
        public async Task<bool> IsAuthenticationValidAsync(CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrWhiteSpace(Connection.ApiKey))
                return false;

            AddAuthorization(Connection.ApiKey);

            try
            {
                string url = "api/admin/realware/0";
                await base.ExecuteAsync<string>(url, RWHttpVerb.GET, cancellationToken: cancellationToken).ConfigureAwait(false);
                return true;
            }
            catch (RealWareApiException ex) when (ex.StatusCode == System.Net.HttpStatusCode.Unauthorized)
            {
                return false;
            }
            catch
            {
                return false;
            }
        }
        #endregion

        #region Pictures
        /// <summary>
        /// Synchronously retrieves the primary photo for an account.
        /// </summary>
        public byte[] GetPrimaryPhoto(string accountNo, string taxYear, string order = "PRIMARY|IMP|LAND|MISC")
            => GetPrimaryPhotoAsync(accountNo, taxYear, order).GetAwaiter().GetResult();
        /// <summary>
        /// Retrieves the primary photo for an account.
        /// </summary>
        public async Task<byte[]> GetPrimaryPhotoAsync(string accountNo, string taxYear, string order = "PRIMARY|IMP|LAND|MISC", CancellationToken cancellationToken = default)
        {
            string url = $"api/accounts/{accountNo}/{taxYear}/primaryphoto";
            if(order != null)
                url += $"?order={order}";
            return await ExecuteAsync<byte[]>(url, RWHttpVerb.GET, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Synchronously retrieves the primary sketch for an account.
        /// </summary>
        public byte[] GetPrimarySketchPhoto(string accountNo, string taxYear)
            => GetPrimarySketchPhotoAsync(accountNo, taxYear).GetAwaiter().GetResult();
        /// <summary>
        /// Retrieves the primary sketch for an account.
        /// </summary>
        public async Task<byte[]> GetPrimarySketchPhotoAsync(string accountNo, string taxYear, CancellationToken cancellationToken = default)
        {
            string url = $"api/accounts/{accountNo}/{taxYear}/primarysketch";
            return await ExecuteAsync<byte[]>(url, RWHttpVerb.GET, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region RealAccount/RealProperty
#if v5
        /// <summary>
        /// Synchronously gets a real account.
        /// </summary>
        public RWRealAccount GetRealAccount(string accountNo, string taxYear)
            => GetRealAccountAsync(accountNo, taxYear).GetAwaiter().GetResult();
        /// <summary>
        /// Gets a real account.
        /// </summary>
        public async Task<RWRealAccount> GetRealAccountAsync(string accountNo, string taxYear, CancellationToken cancellationToken = default)
        {
            if (accountNo == null)
                throw new ArgumentNullException(nameof(accountNo));

            if (taxYear == null)
                throw new ArgumentNullException(nameof(taxYear));

            string url = $"api/realproperty/{accountNo}/{taxYear}";
            return await ExecuteAsync<RWRealAccount>(url, RWHttpVerb.GET, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Synchronously gets a real account as a string(json) value.
        /// </summary>
        public string GetRealAccountAsString(string accountNo, string taxYear)
            => GetRealAccountAsStringAsync(accountNo, taxYear).GetAwaiter().GetResult();
        /// <summary>
        /// Gets a real account as a string(json) value.
        /// </summary>
        public async Task<string> GetRealAccountAsStringAsync(string accountNo, string taxYear, CancellationToken cancellationToken = default)
        {
            if (accountNo == null)
                throw new ArgumentNullException(nameof(accountNo));

            if (taxYear == null)
                throw new ArgumentNullException(nameof(taxYear));

            string url = $"api/realproperty/{accountNo}/{taxYear}";
            return await ExecuteAsync<string>(url, RWHttpVerb.GET, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Synchronously updates a real account.
        /// </summary>
        public void UpdateRealAccount(RWRealAccount account, string taxYear)
            => UpdateRealAccountAsync(account, taxYear).GetAwaiter().GetResult();
        /// <summary>
        /// Updates a real account.
        /// </summary>
        public async Task UpdateRealAccountAsync(RWRealAccount account, string taxYear, CancellationToken cancellationToken = default)
        {
            if (account == null)
                throw new ArgumentNullException(nameof(account));

            if (account.AccountNo == null)
                throw new ArgumentNullException(nameof(account.AccountNo));

            if (taxYear == null)
                throw new ArgumentNullException(nameof(taxYear));

            string url = $"api/realproperty/{account.AccountNo}/{taxYear}";
            await ExecuteAsync<string>(url, RWHttpVerb.PUT, account, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Synchronously inserts a real account and returns the new id of the account (if successful).
        /// </summary>
        public string InsertRealAccount(RWRealAccount account, string accountNo, string taxYear)
            =>  InsertRealAccountAsync(account, accountNo, taxYear).GetAwaiter().GetResult();
        /// <summary>
        /// Inserts a real account and returns the new id of the account (if successful).
        /// </summary>
        public async Task<string> InsertRealAccountAsync(RWRealAccount account, string accountNo, string taxYear, CancellationToken cancellationToken = default)
        {
            if (account == null)
                throw new ArgumentNullException(nameof(account));

            if (account.AccountNo == null)
                throw new ArgumentNullException(nameof(account.AccountNo));

            if (taxYear == null)
                throw new ArgumentNullException(nameof(taxYear));

            string url = $"api/realproperty/{accountNo}/{taxYear}";
            var response = await ExecuteWithResponseAsync(url, RWHttpVerb.POST, account, cancellationToken: cancellationToken).ConfigureAwait(false);
            return getIdFromResponse(response);
        }

        /// <summary>
        /// Synchronously deletes a real account.
        /// </summary>
        public void DeleteRealAccount(string accountNo, string taxYear)
            => DeleteRealAccountAsync(accountNo, taxYear).GetAwaiter().GetResult();
        /// <summary>
        /// Deletes a real account.
        /// </summary>
        public async Task DeleteRealAccountAsync(string accountNo, string taxYear, CancellationToken cancellationToken = default)
        {
            if (accountNo == null)
                throw new ArgumentNullException(nameof(accountNo));

            if (taxYear == null)
                throw new ArgumentNullException(nameof(taxYear));

            string url = $"api/realproperty/{accountNo}/{taxYear}";
            await ExecuteAsync<string>(url, RWHttpVerb.DELETE, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
#else
        /// <summary>
        /// Synchronously gets a real account.
        /// </summary>
        public RWRealProperty GetRealProperty(string accountNo, string taxYear)
            => GetRealPropertyAsync(accountNo, taxYear).GetAwaiter().GetResult();
        /// <summary>
        /// Gets a real account.
        /// </summary>
        public async Task<RWRealProperty> GetRealPropertyAsync(string accountNo, string taxYear, CancellationToken cancellationToken = default)
        {
            if (accountNo == null)
                throw new ArgumentNullException(nameof(accountNo));

            if (taxYear == null)
                throw new ArgumentNullException(nameof(taxYear));

            string url = $"api/realProperty/{accountNo}/{taxYear}";
            return await ExecuteAsync<RWRealProperty>(url, RWHttpVerb.GET, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Synchronously gets a real account as a string(json) value.
        /// </summary>
        public string GetRealPropertyAsString(string accountNo, string taxYear)
            => GetRealPropertyAsStringAsync(accountNo, taxYear).GetAwaiter().GetResult();
        /// <summary>
        /// Gets a real account as a string(json) value.
        /// </summary>
        public async Task<string> GetRealPropertyAsStringAsync(string accountNo, string taxYear, CancellationToken cancellationToken = default)
        {
            if (accountNo == null)
                throw new ArgumentNullException(nameof(accountNo));

            if (taxYear == null)
                throw new ArgumentNullException(nameof(taxYear));

            string url = $"api/realProperty/{accountNo}/{taxYear}";
            return await ExecuteAsync<string>(url, RWHttpVerb.GET, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Synchronously updates a real account.
        /// </summary>
        public void UpdateRealProperty(RWRealProperty account, string taxYear)
            => UpdateRealPropertyAsync(account, taxYear).GetAwaiter().GetResult();
        /// <summary>
        /// Updates a real account.
        /// </summary>
        public async Task UpdateRealPropertyAsync(RWRealProperty account, string taxYear, CancellationToken cancellationToken = default)
        {
            if (account == null)
                throw new ArgumentNullException(nameof(account));

            if (account.AccountNo == null)
                throw new ArgumentNullException(nameof(account.AccountNo));

            if (taxYear == null)
                throw new ArgumentNullException(nameof(taxYear));

            string url = $"api/realProperty/{account.AccountNo}/{taxYear}";
            await ExecuteAsync<string>(url, RWHttpVerb.PUT, account, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Synchronously inserts a real account and returns the new id of the account (if successful).
        /// </summary>
        public string InsertRealAccount(RWRealProperty account, string accountNo, string taxYear)
            => InsertRealPropertyAsync(account, accountNo, taxYear).GetAwaiter().GetResult();
        /// <summary>
        /// Inserts a real account and returns the new id of the account (if successful).
        /// </summary>
        public async Task<string> InsertRealPropertyAsync(RWRealProperty account, string accountNo, string taxYear, CancellationToken cancellationToken = default)
        {
            if (account == null)
                throw new ArgumentNullException(nameof(account));

            if (account.AccountNo == null)
                throw new ArgumentNullException(nameof(account.AccountNo));

            if (taxYear == null)
                throw new ArgumentNullException(nameof(taxYear));

            string url = $"api/realProperty/{accountNo}/{taxYear}";
            var response = await ExecuteWithResponseAsync(url, RWHttpVerb.POST, account, cancellationToken: cancellationToken).ConfigureAwait(false);
            return getIdFromResponse(response);
        }

        /// <summary>
        /// Synchronously deletes a real account.
        /// </summary>
        public void DeleteRealProperty(string accountNo, string taxYear)
            => DeleteRealPropertyAsync(accountNo, taxYear).GetAwaiter().GetResult();
        /// <summary>
        /// Deletes a real account.
        /// </summary>
        public async Task DeleteRealPropertyAsync(string accountNo, string taxYear, CancellationToken cancellationToken = default)
        {
            if (accountNo == null)
                throw new ArgumentNullException(nameof(accountNo));

            if (taxYear == null)
                throw new ArgumentNullException(nameof(taxYear));

            string url = $"api/realProperty/{accountNo}/{taxYear}";
            await ExecuteAsync<string>(url, RWHttpVerb.DELETE, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
#endif
        #endregion

        #region Improvements
        /// <summary>
        /// Synchronously gets a list of improvements for an account.
        /// </summary>
        public List<RWImprovement> GetImprovements(string accountNo, string taxYear)
            => GetImprovementsAsync(accountNo, taxYear).GetAwaiter().GetResult();
        /// <summary>
        /// Gets a list of improvements for an account.
        /// </summary>
        /// <exception cref="ArgumentNullException"></exception>
        public async Task<List<RWImprovement>> GetImprovementsAsync(string accountNo, string taxYear, CancellationToken cancellationToken = default)
        {
            if (accountNo == null)
                throw new ArgumentNullException(nameof(accountNo));

            if (taxYear == null)
                throw new ArgumentNullException(nameof(taxYear));

            string url = $"api/improvements/{accountNo}/{taxYear}";
            return await ExecuteAsync<List<RWImprovement>>(url, RWHttpVerb.GET, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Synchronously gets an improvement for an account.
        /// </summary>
        public RWImprovement GetImprovement(string accountNo, int improvementNo, string taxYear)
            => GetImprovementAsync(accountNo, improvementNo, taxYear).GetAwaiter().GetResult();
        /// <summary>
        /// Gets an improvement for an account.
        /// </summary>
        /// <exception cref="ArgumentNullException"></exception>
        public async Task<RWImprovement> GetImprovementAsync(string accountNo, int improvementNo, string taxYear, CancellationToken cancellationToken = default)
        {
            if (accountNo == null)
                throw new ArgumentNullException(nameof(accountNo));

            if (taxYear == null)
                throw new ArgumentNullException(nameof(taxYear));

            string url = $"api/improvements/{accountNo}/{improvementNo}/{taxYear}";
            return await ExecuteAsync<RWImprovement>(url, RWHttpVerb.GET, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Synchronously gets an improvement for an account as a string(json) value.
        /// </summary>
        public string GetImprovementAsString(string accountNo, int improvementNo, string taxYear)
            => GetImprovementAsStringAsync(accountNo, improvementNo, taxYear).GetAwaiter().GetResult();
        /// <summary>
        /// Gets an improvement for an account as a string(json) value.
        /// </summary>
        /// <exception cref="ArgumentNullException"></exception>
        public async Task<string> GetImprovementAsStringAsync(string accountNo, int improvementNo, string taxYear, CancellationToken cancellationToken = default)
        {
            if (accountNo == null)
                throw new ArgumentNullException(nameof(accountNo));

            if (taxYear == null)
                throw new ArgumentNullException(nameof(taxYear));

            string url = $"api/improvements/{accountNo}/{improvementNo}/{taxYear}";
            return await ExecuteAsync<string>(url, RWHttpVerb.GET, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Synchronously updates an improvement for an account.
        /// </summary>
        public void UpdateImprovement(RWImprovement improvement, int improvementNo, string taxYear)
            => UpdateImprovementAsync(improvement, improvementNo, taxYear).GetAwaiter().GetResult();
        /// <summary>
        /// Updates an improvement for an account.
        /// </summary>
        public async Task UpdateImprovementAsync(RWImprovement improvement, int improvementNo, string taxYear, CancellationToken cancellationToken = default)
        {
            if (improvement == null)
                throw new ArgumentNullException(nameof(improvement));

            if (taxYear == null)
                throw new ArgumentNullException(nameof(taxYear));

            string url = $"api/improvements/{improvement.AccountNo}/{improvementNo}/{taxYear}";
            await ExecuteAsync<string>(url, RWHttpVerb.PUT, improvement, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Synchronously inserts an improvement for an account and returns the new id of the improvement (if successful).
        /// </summary>
        public string InsertImprovement(RWImprovement improvement, string accountNo, string taxYear)
            => InsertImprovementAsync(improvement, accountNo, taxYear).GetAwaiter().GetResult();
        /// <summary>
        /// Inserts an improvement for an account and returns the new id of the improvement (if successful).
        /// </summary>
        public async Task<string> InsertImprovementAsync(RWImprovement improvement, string accountNo, string taxYear, CancellationToken cancellationToken = default)
        {
            if (improvement == null)
                throw new ArgumentNullException(nameof(improvement));

            if (accountNo == null)
                throw new ArgumentNullException(nameof(accountNo));

            if (taxYear == null)
                throw new ArgumentNullException(nameof(taxYear));

            string url = $"api/improvements/{accountNo}/{taxYear}";
            var response = await ExecuteWithResponseAsync(url, RWHttpVerb.POST, improvement, cancellationToken: cancellationToken).ConfigureAwait(false);
            return getIdFromResponse(response);
        }

        /// <summary>
        /// Synchronously deletes an improvement for an account.
        /// </summary>
        public void DeleteImprovement(string accountNo, int improvementNo, string taxYear)
            => DeleteImprovementAsync(accountNo, improvementNo, taxYear).GetAwaiter().GetResult();
        /// <summary>
        /// Deletes an improvement for an account.
        /// </summary>
        public async Task DeleteImprovementAsync(string accountNo, int improvementNo, string taxYear, CancellationToken cancellationToken = default)
        {
            if (accountNo == null)
                throw new ArgumentNullException(nameof(accountNo));

            if (taxYear == null)
                throw new ArgumentNullException(nameof(taxYear));

            string url = $"api/improvements/{accountNo}/{improvementNo}/{taxYear}";
            await ExecuteAsync<string>(url, RWHttpVerb.DELETE, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region ListBuilder
        /// <summary>
        /// Synchronous version of GetListBuilderSearchesAsync
        /// </summary>
        public List<RWListBuilderQueryItem> GetListBuilderSearches()
            => GetListBuilderSearchesAsync().GetAwaiter().GetResult();
        /// <summary>
        /// Retrieves a list of saved searches for the ListBuilder.
        /// </summary>
        public async Task<List<RWListBuilderQueryItem>> GetListBuilderSearchesAsync(CancellationToken cancellationToken = default)
        {
            string url = $"api/listbuilder/realware/savedsearches";
            return await ExecuteAsync<List<RWListBuilderQueryItem>>(url, RWHttpVerb.GET, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Synchronous version of GetListBuilderSearchParametersAsync
        /// </summary>
        public string[] GetListBuilderSearchParameters(long queryId)
            => GetListBuilderSearchParametersAsync(queryId).GetAwaiter().GetResult();
        /// <summary>
        /// Retrieves the parameters for a saved listbuilder query.
        /// </summary>
        public async Task<string[]> GetListBuilderSearchParametersAsync(long queryId, CancellationToken cancellationToken = default)
        {
            string url = $"api/listbuilder/realware/parameters/{queryId}";
            return await ExecuteAsync<string[]>(url, RWHttpVerb.GET, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Synchronous version of GetListBuilderQuerySchemaAsync
        /// </summary>
        public string GetListBuilderQuerySchema(long queryId)
            => GetListBuilderQuerySchemaAsync(queryId).GetAwaiter().GetResult();
        /// <summary>
        /// Retrieves the schema for a saved listbuilder query.
        /// </summary>
        public async Task<string> GetListBuilderQuerySchemaAsync(long queryId, CancellationToken cancellationToken = default)
        {
            string url = $"api/listbuilder/realware/{queryId}/schema";
            return await ExecuteAsync<string>(url, RWHttpVerb.GET, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Synchronous version of GetListBuilderQueryResultsAsync
        /// </summary>
        public List<object> GetListBuilderQueryResults(long queryId, List<RWListBuilderQueryParameter> parameters, int maxResults = -1, int taxYear = 0)
            => GetListBuilderQueryResultsAsync(queryId, parameters, maxResults, taxYear).GetAwaiter().GetResult();
        /// <summary>
        /// Retrieves the results for a saved listbuilder query.
        /// </summary>
        public async Task<List<object>> GetListBuilderQueryResultsAsync(long queryId, List<RWListBuilderQueryParameter> parameters, int maxResults = -1, int taxYear = 0, CancellationToken cancellationToken = default)
        {
            if (parameters == null)
                parameters = new List<RWListBuilderQueryParameter>();

            string url = $"api/listbuilder/realware/{queryId}?maxResults={maxResults}&taxyear={taxYear}";
            return await ExecuteAsync<List<object>>(url, RWHttpVerb.POST, parameters, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region Permits
        /// <summary>
        /// Synchronously gets a permit.
        /// </summary>
        public RWPermit GetPermit(string permitNo, string taxYear)
            => GetPermitAsync(permitNo, taxYear).GetAwaiter().GetResult();
        /// <summary>
        /// Gets a permit.
        /// </summary>
        public async Task<RWPermit> GetPermitAsync(string permitNo, string taxYear, CancellationToken cancellationToken = default)
        {
            if(permitNo == null)
                throw new ArgumentNullException(nameof(permitNo));

            if(taxYear == null)
                throw new ArgumentNullException(nameof(taxYear));

            string url = $"api/permits/{permitNo}/{taxYear}";
            return await ExecuteAsync<RWPermit>(url, RWHttpVerb.GET, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Synchronously gets a permit as a string(json) value.
        /// </summary>
        public string GetPermitAsString(string permitNo, string taxYear)
            => GetPermitAsStringAsync(permitNo, taxYear).GetAwaiter().GetResult();
        /// <summary>
        /// Gets a permit as a string(json) value.
        /// </summary>
        public async Task<string> GetPermitAsStringAsync(string permitNo, string taxYear, CancellationToken cancellationToken = default)
        {
            if (permitNo == null)
                throw new ArgumentNullException(nameof(permitNo));

            if (taxYear == null)
                throw new ArgumentNullException(nameof(taxYear));

            string url = $"api/permits/{permitNo}/{taxYear}";
            return await ExecuteAsync<string>(url, RWHttpVerb.GET, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Synchronously updates a permit.
        /// </summary>
        public void UpdatePermit(RWPermit permit, string permitNo, string taxYear)
            => UpdatePermitAsync(permit, permitNo, taxYear).GetAwaiter().GetResult();
        /// <summary>
        /// Updates a permit.
        /// </summary>
        public async Task UpdatePermitAsync(RWPermit permit, string permitNo, string taxYear, CancellationToken cancellationToken = default)
        {
            if (permit == null)
                throw new ArgumentNullException(nameof(permit));

            if(permitNo != null)
                permit.PermitNo = permitNo;

            if (taxYear == null)
                throw new ArgumentNullException(nameof(taxYear));

            string url = $"api/permits/{permit.PermitNo}/{taxYear}";
            await ExecuteAsync<string>(url, RWHttpVerb.PUT, permit, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Synchronously inserts a permit and returns the new id of the permit (if successful).
        /// </summary>
        public string InsertPermit(RWPermit permit, string taxYear)
            => InsertPermitAsync(permit, taxYear).GetAwaiter().GetResult();
        /// <summary>
        /// Inserts a permit and returns the new id of the permit (if successful).
        /// </summary>
        /// <param name="permit"></param>
        /// <param name="taxYear"></param>
        /// <returns></returns>
        public async Task<string> InsertPermitAsync(RWPermit permit, string taxYear, CancellationToken cancellationToken = default)
        {
            if (permit == null)
                throw new ArgumentNullException(nameof(permit));

            if (taxYear == null)
                throw new ArgumentNullException(nameof(taxYear));

            string url = $"api/permits/{taxYear}";
            var response = await ExecuteWithResponseAsync(url, RWHttpVerb.POST, permit, cancellationToken: cancellationToken).ConfigureAwait(false);
            return getIdFromResponse(response);
        }

        /// <summary>
        /// Synchronously deletes a permit.
        /// </summary>
        public void DeletePermit(string permitNo, string taxYear)
            => DeletePermitAsync(permitNo, taxYear).GetAwaiter().GetResult();
        /// <summary>
        /// Deletes a permit.
        /// </summary>
        public async Task DeletePermitAsync(string permitNo, string taxYear, CancellationToken cancellationToken = default)
        {
            if (permitNo == null)
                throw new ArgumentNullException(nameof(permitNo));

            if (taxYear == null)
                throw new ArgumentNullException(nameof(taxYear));

            string url = $"api/permits/{permitNo}/{taxYear}";
            await ExecuteAsync<string>(url, RWHttpVerb.DELETE, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region Sales
        /// <summary>
        /// Synchronously gets a sale.
        /// </summary>
        public RWSale GetSale(string receptionNo)
            => GetSaleAsync(receptionNo).GetAwaiter().GetResult();
        /// <summary>
        /// Gets a sale.
        /// </summary>
        public async Task<RWSale> GetSaleAsync(string receptionNo, CancellationToken cancellationToken = default)
        {
            if(receptionNo == null)
                throw new ArgumentNullException(nameof(receptionNo));

            string url = $"api/sales/{receptionNo}";
            return await ExecuteAsync<RWSale>(url, RWHttpVerb.GET, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Synchronously gets a sale as a string(json) value.
        /// </summary>
        public string GetSaleAsString(string receptionNo)
            => GetSaleAsStringAsync(receptionNo).GetAwaiter().GetResult();
        /// <summary>
        /// Gets a sale as a string(json) value.
        /// </summary>
        public async Task<string> GetSaleAsStringAsync(string receptionNo, CancellationToken cancellationToken = default)
        {
            if (receptionNo == null)
                throw new ArgumentNullException(nameof(receptionNo));

            string url = $"api/sales/{receptionNo}";
            return await ExecuteAsync<string>(url, RWHttpVerb.GET, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Synchronously updates a sale.
        /// </summary>
        public void UpdateSale(RWSale sale, string receptionNo)
            => UpdateSaleAsync(sale, receptionNo).GetAwaiter().GetResult();
        /// <summary>
        /// Updates a sale.
        /// </summary>
        public async Task UpdateSaleAsync(RWSale sale, string receptionNo = null, CancellationToken cancellationToken = default)
        {
            if (sale == null)
                throw new ArgumentNullException(nameof(sale));

            if (!string.IsNullOrEmpty(receptionNo))
                sale.ReceptionNo = receptionNo;

            if (sale.ReceptionNo == null)
                throw new ArgumentNullException(nameof(sale.ReceptionNo));

            string url = $"api/sales/{sale.ReceptionNo}";

            if (sale.FieldPriority == null)
                sale.FieldPriority = RWSale.GetDefaultFieldPriority();

            await ExecuteAsync<string>(url, RWHttpVerb.PUT, sale, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Synchronously inserts a sale and returns the new id of the sale (if successful).
        /// </summary>
        public string InsertSale(RWSale sale, string receptionNo)
            => InsertSaleAsync(sale, receptionNo).GetAwaiter().GetResult();
        /// <summary>
        /// Inserts a sale and returns the new id of the sale (if successful).
        /// </summary>
        public async Task<string> InsertSaleAsync(RWSale sale, string receptionNo = null, CancellationToken cancellationToken = default)
        {
            if (sale == null)
                throw new ArgumentNullException(nameof(sale));

            if (!string.IsNullOrEmpty(receptionNo))
                sale.ReceptionNo = receptionNo;

            if (sale.ReceptionNo == null)
                throw new ArgumentNullException(nameof(sale.ReceptionNo));

            string url = $"api/sales/{receptionNo}";

            if (sale.FieldPriority == null)
                sale.FieldPriority = RWSale.GetDefaultFieldPriority();

            var response = await ExecuteWithResponseAsync(url, RWHttpVerb.POST, sale, cancellationToken: cancellationToken).ConfigureAwait(false);
            return getIdFromResponse(response, 0);
        }

        /// <summary>
        /// Synchronously deletes a sale.
        /// </summary>
        public void DeleteSale(string receptionNo)
            => DeleteSaleAsync(receptionNo).GetAwaiter().GetResult();
        /// <summary>
        /// Deletes a sale.
        /// </summary>
        public async Task DeleteSaleAsync(string receptionNo, CancellationToken cancellationToken = default)
        {
            if (receptionNo == null)
                throw new ArgumentNullException(nameof(receptionNo));

            string url = $"api/sales/{receptionNo}";
            await ExecuteAsync<string>(url, RWHttpVerb.DELETE, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region SalesAffidavit
        /// <summary>
        /// Synchronously gets a sale affidavit.
        /// </summary>
        public RWSaleAffidavit GetSaleAffidavit(string receptionNo)
            => GetSaleAffidavitAsync(receptionNo).GetAwaiter().GetResult();
        /// <summary>
        /// Gets a sale affidavit.
        /// </summary>
        public async Task<RWSaleAffidavit> GetSaleAffidavitAsync(string receptionNo, CancellationToken cancellationToken = default)
        {
            if (receptionNo == null)
                throw new ArgumentNullException(nameof(receptionNo));

            string url = $"api/salesAffidavit/{receptionNo}";
            return await ExecuteAsync<RWSaleAffidavit>(url, RWHttpVerb.GET, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Synchronously gets a sale affidavit as a string(json) value.
        /// </summary>
        public string GetSaleAffidavitAsString(string receptionNo)
            => GetSaleAffidavitAsStringAsync(receptionNo).GetAwaiter().GetResult();
        /// <summary>
        /// Gets a sale affidavit as a string(json) value.
        /// </summary>
        public async Task<string> GetSaleAffidavitAsStringAsync(string receptionNo, CancellationToken cancellationToken = default)
        {
            if (receptionNo == null)
                throw new ArgumentNullException(nameof(receptionNo));

            string url = $"api/salesAffidavit/{receptionNo}";
            return await ExecuteAsync<string>(url, RWHttpVerb.GET, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Synchronously updates a sale affidavit.
        /// </summary>
        public void UpdateSaleAffidavit(RWSaleAffidavit saleAffidavit, string receptionNo = null)
            => UpdateSaleAffidavitAsync(saleAffidavit, receptionNo).GetAwaiter().GetResult();
        /// <summary>
        /// Updates a sale affidavit.
        /// </summary>
        public async Task UpdateSaleAffidavitAsync(RWSaleAffidavit saleAffidavit, string receptionNo = null, CancellationToken cancellationToken = default)
        {
            if (saleAffidavit == null)
                throw new ArgumentNullException(nameof(receptionNo));

            if (receptionNo != null)
                saleAffidavit.ReceptionNo = receptionNo;

            if(saleAffidavit.ReceptionNo == null)
                throw new ArgumentNullException(nameof(saleAffidavit.ReceptionNo));

            string url = $"api/salesAffidavit/{saleAffidavit.ReceptionNo}";
            await ExecuteAsync<string>(url, RWHttpVerb.PUT, saleAffidavit, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Synchronously inserts a sale affidavit and returns the new id of the sale affidavit (if successful).
        /// </summary>
        public string InsertSaleAffidavit(RWSaleAffidavit saleAffidavit, string receptionNo = null)
            => InsertSaleAffidavitAsync(saleAffidavit, receptionNo).GetAwaiter().GetResult();
        /// <summary>
        /// Inserts a sale affidavit and returns the new id of the sale affidavit (if successful).
        /// </summary>
        public async Task<string> InsertSaleAffidavitAsync(RWSaleAffidavit saleAffidavit, string receptionNo = null, CancellationToken cancellationToken = default)
        {
            if (saleAffidavit == null)
                throw new ArgumentNullException(nameof(receptionNo));

            if (receptionNo != null)
                saleAffidavit.ReceptionNo = receptionNo;

            if (saleAffidavit.ReceptionNo == null)
                throw new ArgumentNullException(nameof(saleAffidavit.ReceptionNo));

            string url = $"api/salesAffidavit/{saleAffidavit.ReceptionNo}";
            var response = await ExecuteWithResponseAsync(url, RWHttpVerb.POST, saleAffidavit, cancellationToken: cancellationToken).ConfigureAwait(false);
            return getIdFromResponse(response);
        }

        /// <summary>
        /// Synchronously deletes a sale affidavit.
        /// </summary>
        public void DeleteSaleAffidavit(string receptionNo)
            => DeleteSaleAffidavitAsync(receptionNo).GetAwaiter().GetResult();
        /// <summary>
        /// Deletes a sale affidavit.
        /// </summary>
        public async Task DeleteSaleAffidavitAsync(string receptionNo, CancellationToken cancellationToken = default)
        {
            if (receptionNo == null)
                throw new ArgumentNullException(nameof(receptionNo));

            string url = $"api/salesAffidavit/{receptionNo}";
            await ExecuteAsync<string>(url, RWHttpVerb.DELETE, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region Appeals
        /// <summary>
        /// Synchronously gets an appeal.
        /// </summary>
        public RWAppeal GetAppeal(string appealNo, string taxYear)
            => GetAppealAsync(appealNo, taxYear).GetAwaiter().GetResult();
        /// <summary>
        /// Gets an appeal.
        /// </summary>
        /// <returns></returns>
        public async Task<RWAppeal> GetAppealAsync(string appealNo, string taxYear, CancellationToken cancellationToken = default)
        {
            if (appealNo == null)
                throw new ArgumentNullException(nameof(appealNo));

            if (taxYear == null)
                throw new ArgumentNullException(nameof(taxYear));

            string url = $"api/appeals/{appealNo}/{taxYear}";
            return await ExecuteAsync<RWAppeal>(url, RWHttpVerb.GET, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Synchronously gets an appeal as a string(json) value.
        /// </summary>
        public string GetAppealAsString(string appealNo, string taxYear)
            => GetAppealAsStringAsync(appealNo, taxYear).GetAwaiter().GetResult();
        /// <summary>
        /// Gets an appeal as a string(json) value.
        /// </summary>
        public async Task<string> GetAppealAsStringAsync(string appealNo, string taxYear, CancellationToken cancellationToken = default)
        {
            if (appealNo == null)
                throw new ArgumentNullException(nameof(appealNo));

            if (taxYear == null)
                throw new ArgumentNullException(nameof(taxYear));

            string url = $"api/appeals/{appealNo}/{taxYear}";
            return await ExecuteAsync<string>(url, RWHttpVerb.GET, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Synchronously updates an appeal.
        /// </summary>
        public void UpdateAppeal(RWAppeal appeal, string appealNo, string taxYear)
            => UpdateAppealAsync(appeal, appealNo, taxYear).GetAwaiter().GetResult();
        /// <summary>
        /// Updates an appeal.
        /// </summary>
        public async Task UpdateAppealAsync(RWAppeal appeal, string appealNo, string taxYear, CancellationToken cancellationToken = default)
        {
            if (appeal == null)
                throw new ArgumentNullException(nameof(appeal));

            if (appealNo == null)
                throw new ArgumentNullException(nameof(appealNo));

            if (taxYear == null)
                throw new ArgumentNullException(nameof(taxYear));

            string url = $"api/appeals/{appealNo}/{taxYear}";
            await ExecuteAsync<string>(url, RWHttpVerb.PUT, appeal, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Synchronously inserts an appeal and returns the new id of the appeal (if successful).
        /// </summary>
        public string InsertAppeal(RWAppeal appeal, string taxYear)
            => InsertAppealAsync(appeal, taxYear).GetAwaiter().GetResult();
        /// <summary>
        /// Inserts an appeal and returns the new id of the appeal (if successful).
        /// </summary>
        public async Task<string> InsertAppealAsync(RWAppeal appeal, string taxYear, CancellationToken cancellationToken = default)
        {
            if (appeal == null)
                throw new ArgumentNullException(nameof(appeal));

            if (taxYear == null)
                throw new ArgumentNullException(nameof(taxYear));

            string url = $"api/appeals/{taxYear}";
            var response = await ExecuteWithResponseAsync(url, RWHttpVerb.POST, appeal, cancellationToken: cancellationToken).ConfigureAwait(false);
            return getIdFromResponse(response);
        }

        /// <summary>
        /// Synchronously deletes an appeal.
        /// </summary>
        public void DeleteAppeal(string appealNo, string taxYear)
            => DeleteAppealAsync(appealNo, taxYear).GetAwaiter().GetResult();
        /// <summary>
        /// Deletes an appeal.
        /// </summary>
        public async Task DeleteAppealAsync(string appealNo, string taxYear, CancellationToken cancellationToken = default)
        {
            if (appealNo == null)
                throw new ArgumentNullException(nameof(appealNo));

            if (taxYear == null)
                throw new ArgumentNullException(nameof(taxYear));

            string url = $"api/appeals/{appealNo}/{taxYear}";
            await ExecuteAsync<string>(url, RWHttpVerb.DELETE, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region AccountOwners
        /// <summary>
        /// Synchronously gets a list of account owners for an account.
        /// </summary>
        public List<RWAccountOwner> GetAccountOwners(string accountNo, string taxYear)
            => GetAccountOwnersAsync(accountNo, taxYear).GetAwaiter().GetResult();
        /// <summary>
        /// Gets a list of account owners for an account.
        /// </summary>
        public async Task<List<RWAccountOwner>> GetAccountOwnersAsync(string accountNo, string taxYear, CancellationToken cancellationToken = default)
        {
            if(accountNo == null)
                throw new ArgumentNullException(nameof(accountNo));

            if(taxYear == null)
                throw new ArgumentNullException(nameof(taxYear));

            string url = $"api/accountOwners/{accountNo}/{taxYear}";
            return await ExecuteAsync<List<RWAccountOwner>>(url, RWHttpVerb.GET, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Synchronously gets the primary account owner for an account.
        /// </summary>
        public RWAccountOwner GetAccountOwnerPrimary(string accountNo, string taxYear)
            => GetAccountOwnerPrimaryAsync(accountNo, taxYear).GetAwaiter().GetResult();
        /// <summary>
        /// Gets the primary account owner for an account.
        /// </summary>
        public async Task<RWAccountOwner> GetAccountOwnerPrimaryAsync(string accountNo, string taxYear, CancellationToken cancellationToken = default)
        {
            if (accountNo == null)
                throw new ArgumentNullException(nameof(accountNo));

            if (taxYear == null)
                throw new ArgumentNullException(nameof(taxYear));

            string url = $"api/accountOwners/{accountNo}/{taxYear}/primaryOwner";
            return await ExecuteAsync<RWAccountOwner>(url, RWHttpVerb.GET, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Synchronously gets the primary account owner for an account as a string(json) value.
        /// </summary>
        public string GetAccountOwnerPrimaryAsString(string accountNo, string taxYear)
            => GetAccountOwnerPrimaryAsStringAsync(accountNo, taxYear).GetAwaiter().GetResult();
        /// <summary>
        /// Gets the primary account owner for an account as a string(json) value.
        /// </summary>
        public async Task<string> GetAccountOwnerPrimaryAsStringAsync(string accountNo, string taxYear, CancellationToken cancellationToken = default)
        {
            if (accountNo == null)
                throw new ArgumentNullException(nameof(accountNo));

            if (taxYear == null)
                throw new ArgumentNullException(nameof(taxYear));

            string url = $"api/accountOwners/{accountNo}/{taxYear}/primaryOwner";
            return await ExecuteAsync<string>(url, RWHttpVerb.GET, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Updates the account owners for an account.
        /// </summary>
        public void UpdateAccountOwners(List<RWAccountOwner> owners, string accountNo, string taxYear)
            => UpdateAccountOwnersAsync(owners, accountNo, taxYear).GetAwaiter().GetResult();
        /// <summary>
        /// Updates the account owners for an account.
        /// </summary>
        public async Task UpdateAccountOwnersAsync(List<RWAccountOwner> owners, string accountNo, string taxYear, CancellationToken cancellationToken = default)
        {
            if (owners == null)
                throw new ArgumentNullException(nameof(owners));

            if (accountNo == null)
                throw new ArgumentNullException(nameof(accountNo));

            if (taxYear == null)
                throw new ArgumentNullException(nameof(taxYear));

            string url = $"api/accountOwners/{accountNo}/{taxYear}";
            await ExecuteAsync<string>(url, RWHttpVerb.PUT, owners, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Synchronously deletes the account owners for an account.
        /// </summary>
        public void DeleteAccountOwners(string accountNo, string taxYear)
            => DeleteAccountOwnersAsync(accountNo, taxYear).GetAwaiter().GetResult();
        /// <summary>
        /// Deletes the account owners for an account.
        /// </summary>
        public async Task DeleteAccountOwnersAsync(string accountNo, string taxYear, CancellationToken cancellationToken = default)
        {
            if (accountNo == null)
                throw new ArgumentNullException(nameof(accountNo));

            if (taxYear == null)
                throw new ArgumentNullException(nameof(taxYear));

            string url = $"api/accountOwners/{accountNo}/{taxYear}";
            await ExecuteAsync<string>(url, RWHttpVerb.DELETE, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region Sketches
        /// <summary>
        /// Synchronously gets a sketch for an improvement.
        /// </summary>
        public RWImprovementSketch GetSketch(string accountNo, int improvementNo, string taxYear)
            => GetSketchAsync(accountNo, improvementNo, taxYear).GetAwaiter().GetResult();
        /// <summary>
        /// Gets a sketch for an improvement.
        /// </summary>
        /// <exception cref="ArgumentNullException"></exception>
        public async Task<RWImprovementSketch> GetSketchAsync(string accountNo, int improvementNo, string taxYear, CancellationToken cancellationToken = default)
        {
            if (accountNo == null)
                throw new ArgumentNullException(nameof(accountNo));

            string url = $"api/sketches/{accountNo}/{improvementNo}/{taxYear}";
            return await ExecuteAsync<RWImprovementSketch>(url, RWHttpVerb.GET, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Synchronously gets a sketch for an improvement as a string(json) value.
        /// </summary>
        public string GetSketchAsString(string accountNo, int improvementNo, string taxYear)
            => GetSketchAsStringAsync(accountNo, improvementNo, taxYear).GetAwaiter().GetResult();
        /// <summary>
        /// Gets a sketch for an improvement as a string(json) value.
        /// </summary>
        public async Task<string> GetSketchAsStringAsync(string accountNo, int improvementNo, string taxYear, CancellationToken cancellationToken = default)
        {
            if (accountNo == null)
                throw new ArgumentNullException(nameof(accountNo));

            string url = $"api/sketches/{accountNo}/{improvementNo}/{taxYear}";
            return await ExecuteAsync<string>(url, RWHttpVerb.GET, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Synchronously updates a sketch for an improvement.
        /// </summary>
        public void UpdateSketch(RWImprovementSketch sketch, string accountNo = null, int? improvementNo = null, string taxYear = null)
            => UpdateSketchAsync(sketch, accountNo, improvementNo, taxYear).GetAwaiter().GetResult();
        /// <summary>
        /// Updates a sketch for an improvement.
        /// </summary>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="RealWareApiException"></exception>
        public async Task UpdateSketchAsync(RWImprovementSketch sketch, string accountNo = null, int? improvementNo = null, string taxYear = null, CancellationToken cancellationToken = default)
        {
            if (accountNo != null)
                sketch.AccountNo = accountNo;

            if (sketch.AccountNo == null)
                throw new ArgumentNullException(nameof(sketch.AccountNo));

            if (taxYear != null)
            {
                if (int.TryParse(taxYear, out int year))
                    sketch.TaxYear = year;
                else
                    throw new RealWareApiException($"Failed to parse {nameof(taxYear)} as a number with value={taxYear}.");
            }

            if (sketch.TaxYear < 1900)
                throw new ArgumentNullException(nameof(sketch.TaxYear));

            if (improvementNo.HasValue)
                sketch.ImpNo = improvementNo.Value;

            string url = $"api/sketches/{sketch.AccountNo}/{sketch.ImpNo}/{sketch.TaxYear}";
            await ExecuteAsync<string>(url, RWHttpVerb.PUT, sketch, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Synchronously inserts a sketch for an improvement.
        /// </summary>
        public void InsertSketch(RWImprovementSketch sketch, string accountNo, int improvementNo, string taxYear)
            => InsertSketchAsync(sketch, accountNo, improvementNo, taxYear).GetAwaiter().GetResult();
        /// <summary>
        /// Inserts a sketch for an improvement.
        /// </summary>
        public async Task InsertSketchAsync(RWImprovementSketch sketch, string accountNo = null, int? improvementNo = null, string taxYear = null, CancellationToken cancellationToken = default)
        {
            if(accountNo != null)
                sketch.AccountNo = accountNo;

            if (sketch.AccountNo == null)
                throw new ArgumentNullException(nameof(sketch.AccountNo));

            if (taxYear != null)
            {
                if(int.TryParse(taxYear, out int year))
                    sketch.TaxYear = year;
                else
                    throw new RealWareApiException($"Failed to parse {nameof(taxYear)} as a number with value={taxYear}.");
            }

            if (sketch.TaxYear < 1900)
                throw new ArgumentNullException(nameof(sketch.TaxYear));

            if (improvementNo.HasValue)
                sketch.ImpNo = improvementNo.Value;

            string url = $"api/sketches/{sketch.AccountNo}/{sketch.ImpNo}/{sketch.TaxYear}";
            await ExecuteAsync<string>(url, RWHttpVerb.POST, sketch, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Synchronously deletes a sketch for an improvement.
        /// </summary>
        public void DeleteSketch(string accountNo, int improvementNo, string taxYear)
            => DeleteSketchAsync(accountNo, improvementNo, taxYear).GetAwaiter().GetResult();
        /// <summary>
        /// Deletes a sketch for an improvement.
        /// </summary>
        public async Task DeleteSketchAsync(string accountNo, int improvementNo, string taxYear, CancellationToken cancellationToken = default)
        {
            if (accountNo == null)
                throw new ArgumentNullException(nameof(accountNo));

            string url = $"api/sketches/{accountNo}/{improvementNo}/{taxYear}";
            await ExecuteAsync<string>(url, RWHttpVerb.DELETE, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion

        #region Applications
        /// <summary>
        /// Synchronously gets a list of applications for an applicant.
        /// </summary>
        public RWApplicationApplicant GetApplication(long applicantId, string taxYear)
            => GetApplicationsAsync(applicantId, taxYear).GetAwaiter().GetResult();
        /// <summary>
        /// Gets a list of applications for an applicant.
        /// </summary>
        public async Task<RWApplicationApplicant> GetApplicationsAsync(long applicantId, string taxYear, CancellationToken cancellationToken = default)
        {
            if (applicantId <= 0)
                throw new ArgumentNullException(nameof(applicantId));

            if (taxYear == null)
                throw new ArgumentNullException(nameof(taxYear));

            string url = $"api/applications/{applicantId}/{taxYear}";
            return await ExecuteAsync<RWApplicationApplicant>(url, RWHttpVerb.GET, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Synchronously gets a list of applications for an applicant.
        /// </summary>
        public RWApplicationApplicant GetApplications(long applicantId, string accountNo, string taxYear)
            => GetApplicationsAsync(applicantId, accountNo, taxYear).GetAwaiter().GetResult();
        /// <summary>
        /// Gets a list of applications for an applicant.
        /// </summary>
        public async Task<RWApplicationApplicant> GetApplicationsAsync(long applicantId, string accountNo, string taxYear, CancellationToken cancellationToken = default)
        {
            if (applicantId <= 0)
                throw new ArgumentNullException(nameof(applicantId));

            if (accountNo == null)
                throw new ArgumentNullException(nameof(accountNo));

            if (taxYear == null)
                throw new ArgumentNullException(nameof(taxYear));

            string url = $"api/applications/{applicantId}/{accountNo}/{taxYear}";
            return await ExecuteAsync<RWApplicationApplicant>(url, RWHttpVerb.GET, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Synchronously gets a list of applicants.
        /// </summary>
        public List<int> GetApplicants(string accountNo, string taxYear)
            => GetApplicantsAsync(accountNo, taxYear).GetAwaiter().GetResult();
        /// <summary>
        /// Gets a list of applicants
        /// </summary>
        public async Task<List<int>> GetApplicantsAsync(string accountNo, string taxYear, CancellationToken cancellationToken = default)
        {
            if (accountNo == null)
                throw new ArgumentNullException(nameof(accountNo));

            if (taxYear == null)
                throw new ArgumentNullException(nameof(taxYear));

            string url = $"api/applications/account/{accountNo}/{taxYear}";
            return await ExecuteAsync<List<int>>(url, RWHttpVerb.GET, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Synchronously inserts an application.
        /// </summary>
        public string InsertApplication(RWApplication application, string taxYear)
            => InsertApplicationAsync(application, taxYear).GetAwaiter().GetResult();
        /// <summary>
        /// Inserts an application.
        /// </summary>
        public async Task<string> InsertApplicationAsync(RWApplication application, string taxYear, CancellationToken cancellationToken = default)
        {
            if (application == null)
                throw new ArgumentNullException(nameof(application));

            if (taxYear == null)
                throw new ArgumentNullException(nameof(taxYear));

            string url = $"api/applications/{taxYear}";
            return await ExecuteAsync<string>(url, RWHttpVerb.POST, application, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Synchronously updates application(s) for an applicant.
        /// </summary>
        public void UpdateApplicationApplicant(RWApplicationApplicant applicationApplicant, long applicantId, string taxYear)
            => UpdateApplicationAsync(applicationApplicant, applicantId, taxYear).GetAwaiter().GetResult();
        /// <summary>
        /// Updates application(s) for an applicant.
        /// </summary>
        public async Task UpdateApplicationAsync(RWApplicationApplicant applicationApplicant, long applicantId, string taxYear, CancellationToken cancellationToken = default)
        {
            if (applicationApplicant == null)
                throw new ArgumentNullException(nameof(applicationApplicant));

            if (applicantId <= 0)
                throw new ArgumentNullException(nameof(applicantId));

            if (taxYear == null)
                throw new ArgumentNullException(nameof(taxYear));

            string url = $"api/applications/{applicantId}/{taxYear}";
            await ExecuteAsync<string>(url, RWHttpVerb.PUT, applicationApplicant, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Synchronously deletes an applicant and all associated applications.
        /// </summary>
        public void DeleteApplications(long applicantId, string taxYear)
            => DeleteApplicationsAsync(applicantId, taxYear).GetAwaiter().GetResult();
        /// <summary>
        /// Deletes an applicant and all associated applications.
        /// </summary>
        public async Task DeleteApplicationsAsync(long applicantId, string taxYear, CancellationToken cancellationToken = default)
        {
            if (applicantId <= 0)
                throw new ArgumentNullException(nameof(applicantId));

            if (taxYear == null)
                throw new ArgumentNullException(nameof(taxYear));

            string url = $"api/applications/{applicantId}/{taxYear}";
            await ExecuteAsync<string>(url, RWHttpVerb.DELETE, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        #endregion
    }
}
