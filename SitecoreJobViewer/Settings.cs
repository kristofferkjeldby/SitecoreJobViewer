namespace SitecoreJobViewer
{
    using System.Configuration;

    public class Settings
    {
        public string Server => ConfigurationManager.AppSettings["Server"];

        public string IdentityServer => ConfigurationManager.AppSettings["IdentityServer"];

        public string ClientId => ConfigurationManager.AppSettings["ClientId"];

        public string ClientSecret => ConfigurationManager.AppSettings["ClientSecret"];

        public int MaxJobs => int.Parse(ConfigurationManager.AppSettings["MaxJobs"]);
    }
}
