namespace SitecoreJobViewer.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class JobRangeCollection
    {
        int size;
        List<Tuple<JobNameHandle, List<string>>> jobStatesCollection;

        public JobRangeCollection(int size)
        {
            jobStatesCollection = new List<Tuple<JobNameHandle, List<string>>>();
            this.size = size;
        }

        public void UpdateJobStates(IEnumerable<Job> jobs)
        {
            // Add new jobs to job ranges
            foreach (var newJob in jobs.Where(j => !HasJob(j.Handle)))
            {
                jobStatesCollection.Add(new Tuple<JobNameHandle, List<string>>(new JobNameHandle(newJob.Name, newJob.Handle), Enumerable.Repeat(string.Empty, size).ToList()));
            }

            // Update job ranges
            foreach (var jobStates in jobStatesCollection)
            {
                jobStates.Item2.RemoveAt(0);
                var job = jobs.Where(j => j.Handle.Equals(jobStates.Item1.Handle)).FirstOrDefault();
                jobStates.Item2.Add(job?.Status.JobState ?? string.Empty);
            }

            // Remove empty job ranges
            jobStatesCollection.RemoveAll(jss => jss.Item2.All(js => string.IsNullOrEmpty(js)));
        }

        private bool HasJob(string jobHandle)
        {
            return jobStatesCollection.Select(jss => jss.Item1).Any(jnh => jnh.Handle.Equals(jobHandle));
        }

        private IEnumerable<JobRange> GetJobRanges(JobNameHandle jobNameHandle)
        {
            List<JobRange> jobRanges = new List<JobRange>();

            var jobRange = jobStatesCollection.FirstOrDefault(jss => jss.Item1.Equals(jobNameHandle));
            var jobStates = jobRange.Item2;

            if (jobStates == null)
                return jobRanges;

            for (int x = 0; x < jobStates.Count; x++)
            {
                var currentJobState = jobStates[x];
                var currentJobRange = jobRanges.LastOrDefault();

                if (string.IsNullOrEmpty(currentJobState))
                {
                    if (currentJobRange != null && !currentJobRange.End.HasValue)
                        currentJobRange.End = x;
                }
                else
                {
                    if (currentJobRange == null)
                    {
                        jobRanges.Add(new JobRange(jobRange.Item1, currentJobState, x));
                        continue;
                    }

                    if (currentJobRange != null && currentJobRange.JobState.Equals(currentJobState))
                    {
                        continue;
                    }
                    else
                    {
                        currentJobRange.End = x;
                        jobRanges.Add(new JobRange(jobRange.Item1, currentJobState, x));
                        continue;
                    }
                }
            }

            return jobRanges;
        }

        public IDictionary<string, IEnumerable<JobRange>> GetJobRanges()
        {
            var jobNameHandleRangesDictionary = new Dictionary<JobNameHandle, IEnumerable<JobRange>>();
            var jobRangesDictionary = new Dictionary<string, IEnumerable<JobRange>>();

            foreach (var jobNameHandle in jobStatesCollection.Select(jss => jss.Item1))
            {
                jobNameHandleRangesDictionary.Add(jobNameHandle, GetJobRanges(jobNameHandle));
            }

            foreach (var kv in jobNameHandleRangesDictionary)
            {
                int prefix = 1;
                string uniqueName;

                while(true)
                {
                    uniqueName = $"{kv.Key.Name}#{prefix}";
                 
                    if (!jobRangesDictionary.ContainsKey(uniqueName))
                        break;
                    
                    prefix++;
                }

                jobRangesDictionary.Add(uniqueName, kv.Value);
            }

            return jobRangesDictionary;
        }
    }
}
