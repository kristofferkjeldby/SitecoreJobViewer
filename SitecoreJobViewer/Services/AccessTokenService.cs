namespace SitecoreJobViewer.Services
{
    using IdentityModel.Client;
    using System;
    using System.Net.Http;
    using System.Threading.Tasks;
    using static IdentityModel.OidcConstants;
    using TokenResponse = IdentityModel.Client.TokenResponse;

    public class AccessTokenService : IDisposable
    {
        HttpClient httpClient;
        Settings settings;

        public AccessTokenService(Settings settings)
        {
            this.settings = settings;
            this.httpClient = new HttpClient();
        }

        public async Task<TokenResponse> GetAccessTokenAsync(string username, string password)
        {
            var discoveryResponse = await httpClient.GetDiscoveryDocumentAsync(settings.IdentityServer);

            PasswordTokenRequest tokenRequest = new PasswordTokenRequest()
            {
                Address = discoveryResponse.TokenEndpoint,
                ClientId = settings.ClientId,
                ClientSecret = settings.ClientSecret,
                GrantType = GrantTypes.Password,
                Scope = Constants.Scope,
                UserName = username,
                Password = password
            };

            return await httpClient.RequestPasswordTokenAsync(tokenRequest);
        }

        public void Dispose()
        {
            httpClient.Dispose();
        }
    }
}
