namespace SitecoreJobViewer.UI
{
    using SitecoreJobViewer.Models;
    using System.Collections.Generic;
    using System.Linq;
    using System.Windows.Forms.DataVisualization.Charting;

    public class JobStatusUI : IJobUI
    {
        Chart chart;

        public JobStatusUI(Chart chart, Settings settings) 
        { 
            this.chart = chart;
            var chartArea = chart.ChartAreas["ChartArea"];

            chartArea.AxisX.Minimum = chartArea.AxisX2.Minimum = 0;
            chartArea.AxisX.Maximum = chartArea.AxisX2.Maximum = Constants.SamplesToKeep;
            chartArea.AxisY.Minimum = chartArea.AxisY2.Minimum = 0;
            chartArea.AxisY.Maximum = chartArea.AxisY2.Maximum = settings.MaxJobs;

            foreach (var serie in chart.Series)
            {
                if (Constants.Colors.TryGetValue(serie.Name, out var color))
                    serie.Color = color;
            }

            Clear();
        }

        public void UpdateJobs(IEnumerable<Job> jobs)
        {
            foreach (var serie in chart.Series)
            {
                if (serie.Points.Count > Constants.SamplesToKeep * 2)
                    serie.Points.RemoveAt(0);
                
                foreach (var point in serie.Points)
                    point.XValue--;

                var y = jobs.Where(j => j.Status.JobState.Equals(serie.Name)).Count();

                serie.Points.AddXY(Constants.SamplesToKeep - 1, y);
                serie.Points.AddXY(Constants.SamplesToKeep, y);
            }
        }

        public void Clear()
        {
            foreach (var serie in chart.Series)
            {
                serie.Points.Clear();
            }
        }
    }
}
