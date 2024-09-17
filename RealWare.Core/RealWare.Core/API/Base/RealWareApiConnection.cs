namespace RealWare.Core.API.Connection
{
    public class RealWareApiConnection
    {
        public string BaseUrl { get; private set; }
        public string ApiKey { get; private set; }
        public string Username { get; private set; }
        internal string Password { get; private set; }

        public RealWareApiConnection(string url, string key)
        {
            setBaseUrl(url);
            SetApiKey(key);
        }

        public RealWareApiConnection(string url, string username, string password)
        {
            setBaseUrl(url);

            this.Username = username;
            this.Password = password;
        }

        public void SetApiKey(string key)
        {
            this.ApiKey = key;
        }

        private void setBaseUrl(string url)
        {
            if (!url.EndsWith("/"))
                this.BaseUrl = url + "/";
            else
                this.BaseUrl = url;
        }
    }
}
