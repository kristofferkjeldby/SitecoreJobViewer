namespace SitecoreJobViewer.Services
{
    using GraphQL.Client.Http;
    using GraphQL.Client.Serializer.Newtonsoft;
    using IdentityModel.Client;
    using SitecoreJobViewer.Models;
    using System;
    using System.Linq;
    using System.Net.Http;
    using System.Threading.Tasks;

    public class GraphQLService : IDisposable
    {
        HttpClient httpClient;
        GraphQLHttpClient graphQLHttpClient;

        public GraphQLService(Settings settings, string accessToken) 
        {
            httpClient = new HttpClient();
            GraphQLHttpClientOptions options = new GraphQLHttpClientOptions()
            {
                EndPoint = new Uri($"{settings.Server}/sitecore/api/authoring/graphql/v1")
            };

            graphQLHttpClient = new GraphQLHttpClient(options, new NewtonsoftJsonSerializer(), httpClient);
            graphQLHttpClient.HttpClient.SetBearerToken(accessToken);
        }

        public async Task<GetJobsResponse> GetJobs()
        {
            var getJobsResponse = await graphQLHttpClient.SendQueryAsync<GetJobsResponse>(Constants.GetJobsRequest);
            getJobsResponse.Data.StatusCode = getJobsResponse.AsGraphQLHttpResponse().StatusCode;
            getJobsResponse.Data.Error = getJobsResponse.AsGraphQLHttpResponse().Errors?.Select(e => e.Message).FirstOrDefault();
            return getJobsResponse.Data;
        }

        public void Dispose()
        {
            this.httpClient.Dispose();
            this.graphQLHttpClient.Dispose();
        }
    }
}
