namespace SitecoreJobViewer.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using System.Net;

    public class GetJobsResponse
    {
        [JsonProperty("jobs")]
        public AllJobs AllJobs { get; set; }

        [JsonIgnore]
        public HttpStatusCode StatusCode { get; set; }

        [JsonIgnore]
        public string Error { get; set; }
    }

    public class AllJobs
    {
        [JsonProperty("nodes")]
        public IEnumerable<Job> Jobs { get; set; }
    }

    public class Job
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("handle")]
        public string Handle { get; set; }

        [JsonIgnore]
        public JobNameHandle JobNameHandle => new JobNameHandle(Name, Handle);

        [JsonProperty("status")]
        public Status Status { get; set; }

        [JsonProperty("done")]
        public bool Done { get; set; }

    }

    public class Status
    {
        [JsonProperty("processed")]
        public int Processed { get; set; }

        [JsonProperty("jobState")]
        public string JobState { get; set; }
    }
}
