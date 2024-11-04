namespace RealWare.Core.API.Models
{
    /// <summary>
    /// This is used in place of KeyValuePair to allow for serialization and weird duplicate returned data issues.
    /// </summary>
    public class RWKeyValuePair<T1, T2>
    {
        public T1 Key { get; set; }
        public T2 Value { get; set; }

        public RWKeyValuePair()
        {
        }

        public RWKeyValuePair(T1 key, T2 value)
        {
            Key = key;
            Value = value;
        }
    }
}
