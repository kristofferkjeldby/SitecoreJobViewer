namespace SitecoreJobViewer
{
    using SitecoreJobViewer.Models;
    using SitecoreJobViewer.Services;
    using SitecoreJobViewer.UI;
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Net;
    using System.Threading;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    public partial class Form : System.Windows.Forms.Form
    {
        bool attached;
        Settings settings;
        JobStatusStripUI jobStatusStripUI;    
        List<IJobUI> jobUIs = new List<IJobUI>();
        FormService formService;

        public Form()
        {
            InitializeComponent();
            formService = new FormService(this.InvokeWriteMessage, AttachButton);
        }

        private void Form_Load(object sender, EventArgs e)
        {
            settings = new Settings();

            jobStatusStripUI = new JobStatusStripUI(ServerStatusLabel, LastUpdatedStatusLabel, MessageStatusLabel, settings);

            jobUIs.Add(new JobStatusUI(JobStatusChart, settings));
            jobUIs.Add(new JobRangeUI(JobRangeChart, settings));
            jobUIs.Add(new JobListUI(JobsDataGridView));
            jobUIs.Add(jobStatusStripUI);

            AttachButton.Select();
            this.MinimumSize = new Size(600, 550);

            formService.ChangeFormLayout(FormLayout.IsDetached);

            MessageStatusLabel.Text = string.Empty;
        }

        private void AttachButton_ClickAsync(object sender, EventArgs e)
        {
            if (attached)
                Detach("Detached from Sitecore");
            else
                Attach();
        }

        private async void Attach()
        {
            formService.ChangeFormLayout(FormLayout.IsAttaching);

            string accessToken;

            if (!string.IsNullOrEmpty(AccessTokenTextBox.Text))
            {
                accessToken = AccessTokenTextBox.Text;
            }
            else
            {
                if (string.IsNullOrEmpty(UsernameTextBox.Text))
                {
                    UsernameTextBox.Select();
                    formService.ChangeFormLayout(FormLayout.IsDetached, "Could not login: No user name entered");
                    return;
                }

                if (string.IsNullOrEmpty(PasswordTextBox.Text))
                {
                    PasswordTextBox.Select();
                    formService.ChangeFormLayout(FormLayout.IsDetached, "Could not login: No password entered");
                    return;
                }

                InvokeWriteMessage($"Getting access token - please wait ...");

                using (var accessTokenService = new AccessTokenService(settings))
                {
                    var tokenResponse = await accessTokenService.GetAccessTokenAsync(UsernameTextBox.Text, PasswordTextBox.Text);
                    accessToken = tokenResponse.AccessToken;

                    if (string.IsNullOrEmpty(accessToken))
                    {
                        formService.ChangeFormLayout(FormLayout.IsDetached, $"Could not login: {tokenResponse.ErrorDescription}");
                        return;
                    }
                }
            }

            formService.ChangeFormLayout(FormLayout.IsAttached, "Attached to Sitecore");

            jobUIs.ForEach(j => j.Clear());

            GetJobsAsync(settings, accessToken);

            attached = true;

            await Task.Run(() => GetJobsAsync(settings, accessToken));
        }

        private void Detach(string reason)
        {
            attached = false;
            formService.ChangeFormLayout(FormLayout.IsDetached, reason);
        }

        private async void GetJobsAsync(Settings settings, string accessToken)
        {
            using (var graphQLService = new GraphQLService(settings, accessToken))
            {
                while (attached)
                {
                    var graphQLResponse = await graphQLService.GetJobs();

                    if (graphQLResponse.StatusCode != HttpStatusCode.OK)
                    {
                        TryInvoke(() => Detach($"Endpoint returned: ${graphQLResponse.StatusCode}"));
                        break;
                    }

                    if (!string.IsNullOrEmpty(graphQLResponse.Error))
                    {
                        TryInvoke(() => Detach($"Endpoint returned: ${graphQLResponse.Error}"));
                        break;
                    }

                    InvokeUpdateJobs(graphQLResponse.AllJobs.Jobs);

                    Thread.Sleep(Constants.SampleFrequency);
                }
            }
        }

        private void InvokeUpdateJobs(IEnumerable<Job> jobs)
        {
            TryInvoke(() =>
                jobUIs.ForEach(j => j.UpdateJobs(jobs))
            );
        }

        private void InvokeWriteMessage(string text)
        {
            TryInvoke(() =>
                {
                    jobStatusStripUI.WriteMessage(text);
                }
            );
        }

        void TryInvoke(MethodInvoker action)
        {
            try
            {
                if (this.IsHandleCreated)
                    if (this.InvokeRequired)
                        this.Invoke(action);
                    else
                        action.Invoke();
            }

            catch
            {

            }
        }

        private void Control_Enter(object sender, EventArgs e)
        {
            formService.Enter(sender);
        }

        private void On_Leave(object sender, EventArgs e)
        {
            formService.Leave(sender);
        }
    }
}
