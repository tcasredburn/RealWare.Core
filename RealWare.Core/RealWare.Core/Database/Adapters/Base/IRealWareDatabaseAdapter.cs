namespace RealWare.Core.Database.Adapters.Base
{
    public interface IRealWareDatabaseAdapter
    {
        string TableName { get; }
        string[] IdentifierColumns { get; }
        string[] SortColums { get; }
    }
}
