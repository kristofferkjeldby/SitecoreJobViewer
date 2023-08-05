namespace SitecoreJobViewer.UI
{
    using SitecoreJobViewer.Models;
    using System.Collections.Generic;
    using System.Linq;
    using System.Windows.Forms.DataVisualization.Charting;

    public class JobRangeUI : IJobUI
    {
        JobRangeCollection jobRangeCollection;
        Series serie;

        public JobRangeUI(Chart chart, Settings settings)
        { 
            this.serie = chart.Series[0];
            var chartArea = chart.ChartAreas[0];

            chartArea.AxisY.Minimum = chartArea.AxisY2.Minimum = 0;
            chartArea.AxisY.Maximum = chartArea.AxisY2.Maximum = Constants.SamplesToKeep;
            chartArea.AxisX.Minimum = chartArea.AxisX2.Minimum = 0;
            chartArea.AxisX.Maximum = chartArea.AxisX2.Maximum = settings.MaxJobs;

            this.jobRangeCollection = new JobRangeCollection(Constants.SamplesToKeep);

            Clear();
        }

        public void UpdateJobs(IEnumerable<Job> jobs)
        {
            jobRangeCollection.UpdateJobStates(jobs);

            var jobRanges = jobRangeCollection.GetJobRanges();
            var jobNames = jobRanges.Keys.ToList();
            serie.Points.Clear();

            foreach (var kv in jobRangeCollection.GetJobRanges()) 
            {
                foreach (var jobRange in kv.Value)
                {
                    // To ensure that multiple segments are shown on the same line, the segments cannot be overlapping, and must be added with an index
                    var points = serie.Points.AddXY(jobNames.IndexOf(kv.Key) + 1, jobRange.Start.GetValueOrDefault(0), jobRange.End.GetValueOrDefault(Constants.SamplesToKeep) - Constants.Delta);
                    if (Constants.Colors.TryGetValue(jobRange.JobState, out var color))
                        serie.Points[points].Color = color;
                    serie.Points[points].AxisLabel = kv.Key;
                }
            }
        }

        public void Clear()
        {
            serie.Points.Clear();
            this.jobRangeCollection = new JobRangeCollection(Constants.SamplesToKeep);
        }
    }
}
