namespace SitecoreJobViewer.UI
{
    using SitecoreJobViewer.Models;
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;

    public class JobStatusStripUI : IJobUI
    {
        ToolStripStatusLabel serverStatusLabel;
        ToolStripStatusLabel lastUpdatedStatusLabel;
        ToolStripStatusLabel messageStatusLabel;

        public JobStatusStripUI(ToolStripStatusLabel serverStatusLabel, ToolStripStatusLabel lastUpdatedStatusLabel, ToolStripStatusLabel messageStatusLabel, Settings settings) 
        { 
            this.serverStatusLabel = serverStatusLabel;
            this.lastUpdatedStatusLabel = lastUpdatedStatusLabel;
            this.messageStatusLabel = messageStatusLabel;

            WriteServer(settings.Server);
            WriteLastUpdated();
        }

        public void WriteServer(string server)
        {
            serverStatusLabel.Text = $"Server: {server}";
        }

        public void WriteLastUpdated(DateTime? now = null)
        {
            lastUpdatedStatusLabel.Text = $"Last updated: {(now.HasValue ? now.Value.ToString() : "Never")}";
        }

        public void WriteMessage(string text)
        {
            messageStatusLabel.Text = text;
        }

        public void UpdateJobs(IEnumerable<Job> jobs)
        {
            WriteLastUpdated(DateTime.Now);
        }

        public void Clear()
        {
        }
    }
}
