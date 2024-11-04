using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace RealWare.Core.Database.Adapters.Base
{
    public abstract class BaseRealWareDatabaseAdapter
    {
        internal readonly IDbConnection _connection;

        public BaseRealWareDatabaseAdapter(IDbConnection connection)
        {
            _connection = connection;
        }

        public string GetDefaultSelectQueryText(IRealWareDatabaseAdapter adapter, 
            string[] selectColumns = null, string[] whereClause = null, string[] orderBy = null)
        {
            string selectColumnsText = 
                selectColumns == null 
                ? "*" 
                : string.Join(", ", selectColumns);

            string whereClauseText =
                whereClause == null
                ? "1 = 1"
                : string.Join(" AND ", whereClause);

            string orderByText =
                orderBy == null
                ? string.Empty
                : "ORDER BY " + string.Join(", ", orderBy);

            return $@"
                SELECT {selectColumnsText}
                FROM {adapter.TableName}
                WHERE {whereClauseText}
                {orderByText}";
        }

        public List<T> ExecuteQuery<T>(string query, IDictionary<string, object> parameters = null) where T : new()
        {
            List<T> resultList = new List<T>();

            try
            {
                _connection.Open();
                using (IDbCommand command = _connection.CreateCommand())
                {
                    command.CommandText = query;

                    // Add parameters to the command
                    if (parameters != null)
                    {
                        foreach (var param in parameters)
                        {
                            IDbDataParameter dbParameter = command.CreateParameter();
                            dbParameter.ParameterName = param.Key;
                            dbParameter.Value = param.Value ?? DBNull.Value;
                            command.Parameters.Add(dbParameter);
                        }
                    }

                    using (IDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            T item = Helpers.Convert.ParseDataReader<T>(reader);
                            resultList.Add(item);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            finally
            {
                _connection.Close();
            }

            return resultList;
        }
    }
}
