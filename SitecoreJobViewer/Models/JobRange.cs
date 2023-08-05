namespace SitecoreJobViewer.Models
{
    public class JobRange
    {
        public JobRange(JobNameHandle jobNameHandle, string jobState, int start) 
        {
            this.JobNameHandle = jobNameHandle;
            this.JobState = jobState;
            this.Start = start;
        }

        public JobNameHandle JobNameHandle { get; private set; }

        public string JobState { get; set; }

        public int? Start { get; set; }

        public int? End { get; set; }
    }
}
