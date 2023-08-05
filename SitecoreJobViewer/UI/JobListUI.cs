namespace SitecoreJobViewer.UI
{
    using SitecoreJobViewer.Models;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Windows.Forms;

    public class JobListUI : IJobUI
    {
        DataGridView dataGridView;

        public JobListUI(DataGridView dataGridView) 
        { 
            this.dataGridView = dataGridView;
            Clear();
        }

        public void UpdateJobs(IEnumerable<Job> jobs)
        {
            Clear();

            foreach (Job job in jobs) 
            {
                var row = dataGridView.Rows.Add();

                dataGridView.Rows[row].Cells[0].Value = job.Name;
                dataGridView.Rows[row].Cells[1].Value = job.Handle;
                dataGridView.Rows[row].Cells[2].Value = $"{job.Status.Processed} processed";               
                dataGridView.Rows[row].Cells[3].Value = job.Status.JobState;

                if (Constants.Colors.TryGetValue(job.Status.JobState, out var color))
                {
                    dataGridView.Rows[row].Cells[3].Style.BackColor = color;
                    dataGridView.Rows[row].Cells[3].Style.ForeColor = Color.Black;
                }
            }
        }

        public void Clear()
        {
            dataGridView.Rows.Clear();
        }
    }
}
