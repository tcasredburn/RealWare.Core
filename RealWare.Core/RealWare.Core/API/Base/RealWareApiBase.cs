using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.Threading;
using Newtonsoft.Json;
using RealWare.Core.API.Exceptions;

namespace RealWare.Core.API.Connection
{
    /// <summary>
    /// Base class for REST API connections to the RealWare API over HTTP.
    /// </summary>
    public class RealWareApiBase
    {
        public bool HasAuthorization { get; private set; }

        private readonly HttpClient _client;
        private readonly string _baseUrl;


        /// <summary>
        /// Initializes a new instance of the <see cref="RealWareApiBase"/> class.
        /// </summary>
        /// <param name="baseUrl">The base URL of the API.</param>
        /// <param name="ignoreServerCertificateValidation">Whether to ignore server certificate validation. 
        /// It is highly recommended you do leave this as false in production environments.</param>
        public RealWareApiBase(string baseUrl, bool ignoreServerCertificateValidation = false)
        {
            if(_client == null)
                _client = new HttpClient();

            _baseUrl = baseUrl ?? throw new ArgumentNullException(nameof(baseUrl));

            if (!Uri.IsWellFormedUriString(_baseUrl, UriKind.Absolute))
                throw new ArgumentException("The base URL is not a valid URI.", nameof(baseUrl));

            _client.BaseAddress = new Uri(_baseUrl);

            //NOTE: This should ONLY be enabled in dev environment! This should NEVER be enabled on a production.
            //      This code disables validation checks on the https certificate.
            if (ignoreServerCertificateValidation)
                ServicePointManager.ServerCertificateValidationCallback += (o, c, ch, er) => true;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealWareApiBase"/> class.
        /// </summary>
        /// <param name="client">An instance of <see cref="HttpClient"/> to be used for API calls.</param>
        /// <param name="baseUrl">The base URL of the API.</param>
        /// <param name="ignoreServerCertificateValidation">Whether to ignore server certificate validation. 
        /// It is highly recommended you do leave this as false in production environments.</param>
        public RealWareApiBase(HttpClient client, string baseUrl, bool ignoreServerCertificateValidation = false) : this(baseUrl, ignoreServerCertificateValidation)
        {
            _client = client;
        }

        // <summary>
        /// Adds an authorization token to the request headers.
        /// </summary>
        /// <param name="token">The authorization token.</param>
        public void AddAuthorization(string token)
        {
            if (HasAuthorization)
                return;

            if (string.IsNullOrWhiteSpace(token))
                throw new ArgumentNullException(nameof(token), "Authorization token cannot be null or empty.");

            _client.DefaultRequestHeaders.Add(nameof(HttpRequestHeader.Authorization), string.Format(Constants.API_BEARER_KEY_FORMAT, token));
            HasAuthorization = true;
        }

        /// <summary>
        /// Executes an API request asynchronously.
        /// </summary>
        /// <typeparam name="T">The type of the expected response payload.</typeparam>
        /// <param name="url">The API endpoint URL relative to the base URL.</param>
        /// <param name="verb">The HTTP verb to use for the request.</param>
        /// <param name="data">The request payload to send (for POST and PUT requests).</param>
        /// <param name="cancellationToken">A cancellation token to cancel the request.</param>
        /// <returns>The deserialized response payload.</returns>
        /// <exception cref="RealWareApiException">Thrown when the API call is unsuccessful.</exception>
        public virtual async Task<T> ExecuteAsync<T>(string url, RWHttpVerb verb, object data = null, CancellationToken cancellationToken = default)
        {
            var response = await executeAsyncWithResponse(url, verb, data, cancellationToken);

            if (!response.IsSuccessStatusCode)
            {
                var errorContent = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                throw new RealWareApiException(response.StatusCode, errorContent);
            }

            return await getResultPayload<T>(response).ConfigureAwait(false);
        }

        /// <summary>
        /// Executes an API request and returns the raw <see cref="HttpResponseMessage"/>.
        /// </summary>
        /// <param name="url">The API endpoint URL relative to the base URL.</param>
        /// <param name="verb">The HTTP verb to use for the request.</param>
        /// <param name="data">The request payload to send (for POST and PUT requests).</param>
        /// <param name="cancellationToken">A cancellation token to cancel the request.</param>
        /// <returns>The deserialized response payload.</returns>
        public virtual async Task<HttpResponseMessage> ExecuteWithResponseAsync(string url, RWHttpVerb verb, object data = null, CancellationToken cancellationToken = default)
        {
            return await executeAsyncWithResponse(url, verb, data, cancellationToken);
        }

        private async Task<HttpResponseMessage> executeAsyncWithResponse(string url, RWHttpVerb verb, object data = null, CancellationToken cancellationToken = default)
        {
            if (data != null && (verb == RWHttpVerb.GET || verb == RWHttpVerb.DELETE))
                throw new InvalidOperationException($"Cannot send data with HTTP {verb} request.");

            var requestUrl = $"{_baseUrl}{url}";

            HttpResponseMessage response;

            var content = getJsonHttpContent(data);

            try
            {
                switch (verb)
                {
                    case RWHttpVerb.GET:
                        response = await _client.GetAsync(requestUrl, cancellationToken).ConfigureAwait(false);
                        break;
                    case RWHttpVerb.POST:
                        response = await _client.PostAsync(requestUrl, content, cancellationToken).ConfigureAwait(false);
                        break;
                    case RWHttpVerb.PUT:
                        response = await _client.PutAsync(requestUrl, content, cancellationToken).ConfigureAwait(false);
                        break;
                    case RWHttpVerb.DELETE:
                        response = await _client.DeleteAsync(requestUrl, cancellationToken).ConfigureAwait(false);
                        break;
                    default:
                        throw new NotSupportedException($"The HTTP verb {verb} is not supported.");
                }
            }
            catch (OperationCanceledException)
            {
                throw; // Propagate cancellation exception
            }
            catch (Exception ex)
            {
                throw new RealWareApiException("An error occurred while sending the request.", ex);
            }

            return response;
        }

        /// <summary>
        /// Converts the data object to JSON and creates a StringContent instance.
        /// </summary>
        /// <param name="data">The data object to serialize.</param>
        /// <returns>A StringContent instance with the serialized JSON, or null if data is null.</returns>
        private HttpContent getJsonHttpContent(object data)
        {
            if (data == null)
                return null;

            var json = JsonConvert.SerializeObject(data);
            return new StringContent(json, Encoding.UTF8, "application/json");
        }

        /// <summary>
        /// Reads and deserializes the response content.
        /// </summary>
        /// <typeparam name="T">The type to deserialize the response into.</typeparam>
        /// <param name="response">The HTTP response message.</param>
        /// <returns>The deserialized object of type T.</returns>
        private async Task<T> getResultPayload<T>(HttpResponseMessage response)
        {
            if (response.Content == null)
                return default;

            var contentType = response.Content.Headers.ContentType?.MediaType;

            var result = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            if (string.IsNullOrWhiteSpace(result))
                return default;

            if (contentType != null && contentType.Contains("application/json") && typeof(T) != typeof(string))
            {
                return JsonConvert.DeserializeObject<T>(result);
            }
            else if (typeof(T) == typeof(string))
            {
                return (T)(object)result;//(T)Convert.ChangeType(result, typeof(T));
            }
            else
            {
                throw new RealWareApiException($"Unsupported content type: {contentType}");
            }
        }

        /// <summary>
        /// Extracts the ID from the 'Location' header in the response.
        /// </summary>
        internal string getIdFromResponse(HttpResponseMessage response, int iterationsFromEnd = 1)
        {
            if (response == null)
                throw new ArgumentNullException(nameof(response));

            if (response.Headers.Location == null)
                throw new InvalidOperationException("The response does not contain a 'Location' header.");

            var location = response.Headers.Location.ToString();

            while (iterationsFromEnd > 0)
            {
                location = location.Substring(0, location.LastIndexOf("/", StringComparison.Ordinal));
                iterationsFromEnd--;
            }

            var id = location.Substring(location.LastIndexOf("/", StringComparison.Ordinal) + 1);
            return id;
        }
    }
}
