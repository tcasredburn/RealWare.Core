namespace RealWare.Core.Database.Helpers
{
    public static class RealWareSqlJoinsHelper
    {
        public static string GetActiveAccountOnlyJoin(string sourceAccountAliasAndName, 
            string alias = "a", string version = "@Version")
            => $@"
                INNER JOIN Encompass.TblAcct AS {alias}
                        ON {alias}.AccountNo = {sourceAccountAliasAndName}
                    AND {version} between {alias}.VERSTART and {alias}.VEREND
                    AND {alias}.ACCTSTATUSCODE = 'A'";
    }
}
