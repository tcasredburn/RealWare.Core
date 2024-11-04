using RealWare.Core.Database.Models.Encompass.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Reflection;

namespace RealWare.Core.Database.Helpers
{
    public static class Convert
    {
        /// <summary>
        /// Returns a single column as a list of type T.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="dt"></param>
        /// <param name="column"></param>
        /// <returns></returns>
        public static List<T> DataTableColumnToList<T>(DataTable dt, int column = 0)
        {
            var lst = new List<T>();
            if (dt == null)
                return lst;
            foreach (DataRow dr in dt.Rows)
                lst.Add((T)dr[column]);
            return lst;
        }

        /// <summary>
        /// Returns a single column as a list of type T.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="dt"></param>
        /// <param name="columnName"></param>
        /// <returns></returns>
        public static List<T> DataTableColumnToList<T>(DataTable dt, string columnName)
        {
            var lst = new List<T>();
            if (dt == null)
                return lst;
            foreach (DataRow dr in dt.Rows)
                lst.Add((T)dr[columnName]);
            return lst;
        }

        /// <summary>
        /// Returns a single column as a list of type string.
        /// 
        /// Note: Calls the ToString() method.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="dt"></param>
        /// <param name="column"></param>
        /// <returns></returns>
        public static List<string> DataTableColumnToStringList(DataTable dt, int column = 0)
        {
            var lst = new List<string>();
            if (dt == null)
                return lst;
            foreach (DataRow dr in dt.Rows)
                lst.Add(dr[column].ToString());
            return lst;
        }

        /// <summary>
        /// Returns a single column as a list of type string.
        /// 
        /// Note: Calls the ToString() method.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="dt"></param>
        /// <param name="columnName"></param>
        /// <returns></returns>
        public static List<string> DataTableColumnToStringList(DataTable dt, string columnName)
        {
            var lst = new List<string>();
            if (dt == null)
                return lst;
            foreach (DataRow dr in dt.Rows)
                lst.Add(dr[columnName].ToString());
            return lst;
        }

        /// <summary>
        /// Returns a single value from a datatable.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="dt"></param>
        /// <returns></returns>
        public static T DataTableToSingle<T>(DataTable dt) where T : new()
        {
            if (dt == null)
                return default(T);
            if (dt.Rows.Count > 0)
                return dataTableToList<T>(dt)[0];
            return default(T);
        }

        /// <summary>
        /// Returns a single value from a datatable as a string.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="dt"></param>
        /// <returns></returns>
        public static string DataTableToSingleString(DataTable dt)
        {
            if (dt == null)
                return null;
            if (dt.Rows.Count > 0)
                return dt.Rows[0][0].ToString();
            return null;
        }

        /// <summary>
        /// Returns a single value from a datatable as an integer.
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public static int? DataTableToSingleInt(DataTable dt)
        {
            if (dt == null)
                return null;
            if (dt.Rows.Count > 0)
                return (int?)dt.Rows[0][0];
            return null;
        }

        /// <summary>
        /// Converts a datatable to a list of specified object and fills it.
        /// Note: Same as <see cref="Convert{T}(DataTable)"/> but returns empty list if no values exist.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="dt"></param>
        /// <returns></returns>
        public static List<T> ParseDataTable<T>(DataTable dt) where T : new()
        {
            if (dt == null)
                return new List<T>();
            if (dt.Rows.Count > 0)
                return dataTableToList<T>(dt);
            return new List<T>();
        }

        public static T ParseDataRow<T>(DataRow row, DataColumnCollection dataColumns) where T : new()
        {
            return CreateAndPopulateObject<T>(
                columnName => row[columnName],
                GetColumnNames(dataColumns)
            );
        }

        public static T ParseDataReader<T>(IDataReader reader) where T : new()
        {
            return CreateAndPopulateObject<T>(
                columnName => reader[columnName],
                GetColumnNames(reader)
            );
        }

        public static T CreateAndPopulateObject<T>(Func<string, object> getValueFunc, IEnumerable<string> columnNames) where T : new()
        {
            T newT = new T();
            Type typeofT = typeof(T);
            var propertyCache = new Dictionary<string, PropertyInfo>();

            foreach (string columnName in columnNames)
            {
                // Try to get the PropertyInfo from the cache
                if (!propertyCache.TryGetValue(columnName, out PropertyInfo prop))
                {
                    prop = typeofT.GetProperty(columnName, BindingFlags.Public | BindingFlags.Instance | BindingFlags.IgnoreCase);
                    propertyCache[columnName] = prop;
                }

                if (prop != null)
                {
                    try
                    {
                        var value = getValueFunc(columnName);

                        // Check for null or DBNull
                        if (value == null || value == DBNull.Value)
                        {
                            prop.SetValue(newT, null, null);
                            continue;
                        }

                        // Determine the target type, considering nullable types
                        var targetType = Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType;
                        object safeValue = null;

                        if (targetType.IsEnum)
                        {
                            // Handle enums and nullable enums
                            safeValue = Enum.Parse(targetType, value.ToString());
                        }
                        else if (typeof(RealWareDtoBase).IsAssignableFrom(targetType))
                        {
                            // Handle types derived from RealWareDTOBase
                            TypeConverter converter = TypeDescriptor.GetConverter(targetType);
                            if (converter.CanConvertFrom(typeof(string)))
                            {
                                safeValue = converter.ConvertFrom(value.ToString());
                            }
                            else
                            {
                                throw new InvalidOperationException($"Cannot convert from string to {targetType.Name}");
                            }
                        }
                        else
                        {
                            // Handle other types
                            safeValue = System.Convert.ChangeType(value, targetType);
                        }

                        prop.SetValue(newT, safeValue, null);
                    }
                    catch (Exception ex)
                    {
                        // Optionally log the exception
                        prop.SetValue(newT, null, null);
                    }
                }
            }

            return newT;
        }

        /// <summary>
        /// Use this function to convert a list of objects from a datatable into a list of the object type.
        /// </summary>
        /// <typeparam name="T">The object type</typeparam>
        /// <param name="dt">The Datatable to convert.</param>
        /// <returns>The data-filled objects.</returns>
        private static List<T> dataTableToList<T>(DataTable dt) where T : new()
        {
            var returnList = new List<T>();

            DataColumnCollection dataColumns = dt.Columns;

            foreach (DataRow row in dt.Rows)
            {
                T newT = ParseDataRow<T>(row, dataColumns);
                returnList.Add(newT);
            }

            return returnList;
        }

        private static IEnumerable<string> GetColumnNames(DataColumnCollection dataColumns)
        {
            foreach (DataColumn column in dataColumns)
            {
                yield return column.ColumnName;
            }
        }

        private static IEnumerable<string> GetColumnNames(IDataReader reader)
        {
            for (int i = 0; i < reader.FieldCount; i++)
            {
                yield return reader.GetName(i);
            }
        }

    }
}
