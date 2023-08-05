namespace SitecoreJobViewer
{
    using GraphQL;
    using System.Collections.Generic;
    using System.Drawing;

    public static class Constants
    {
        public static GraphQLRequest GetJobsRequest = new GraphQLRequest
        {
            Query = @"query {
                    jobs(input: { jobName: ""*"" })
                    {
                        nodes {
                            name
                            handle
                            status {
                                processed
                                jobState
                            }
                            done
                        }
                    }
                }"
        };

        public static string Scope = "openid sitecore.profile sitecore.profile.api";

        public static int SampleFrequency = 2000;

        public static int SamplesToKeep = 100;

        public static Dictionary<string, Color> Colors = new Dictionary<string, Color> {
            { "RUNNING", Color.Yellow },
            { "FINISHED", Color.LightBlue },
            { "QUEUED", Color.LightPink },
        };

        public static double Delta = 0.01; 
    }
}
