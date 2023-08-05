namespace SitecoreJobViewer.UI
{
    using SitecoreJobViewer.Models;
    using System.Collections.Generic;

    public interface IJobUI
    {
        void UpdateJobs(IEnumerable<Job> jobs);

        void Clear();
    }
}
