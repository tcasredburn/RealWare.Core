using System.Collections.Generic;
using System.Data;

namespace RealWare.Core.Database.Extensions
{
    public static class DataTableExtensions
    {
        public static List<T> ColumnToList<T>(this DataTable tbl, int column = 0) 
            => Helpers.Convert.DataTableColumnToList<T>(tbl, column);

        public static T ToSingle<T>(this DataTable tbl) where T : new()
            => Helpers.Convert.DataTableToSingle<T>(tbl);

        public static string ToSingleString(this DataTable tbl) 
            => Helpers.Convert.DataTableToSingleString(tbl);

        public static int? ToSingleInt(this DataTable tbl) 
            => Helpers.Convert.DataTableToSingleInt(tbl);

        public static List<T> ToList<T>(this DataTable tbl) where T : new()
            => Helpers.Convert.ParseDataTable<T>(tbl);

        public static List<string> ToStringList(this DataTable tbl, int column = 0) 
            => Helpers.Convert.DataTableColumnToStringList(tbl, column);

        public static List<string> ToStringList(this DataTable tbl, string columnName) 
            => Helpers.Convert.DataTableColumnToStringList(tbl, columnName);
    }
}
