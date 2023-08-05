namespace SitecoreJobViewer.Services
{
    using SitecoreJobViewer.Models;
    using System;
    using System.Drawing;
    using System.Windows.Forms;

    public class FormService
    {

        private readonly Action<string> invokeWriteMessage;
        private readonly Button attachButton;

        public FormService(Action<string> invokeWriteMessage, Button attachButton)
        {
            this.invokeWriteMessage = invokeWriteMessage;
            this.attachButton = attachButton;
        }

        public void ChangeFormLayout(FormLayout applicationLayout, string message = null)
        {
            if (!string.IsNullOrEmpty(message))
                invokeWriteMessage(message);

            switch (applicationLayout)
            {
                case FormLayout.IsAttached:
                    attachButton.Enabled = true;
                    attachButton.Text = "Detach";
                    break;
                case FormLayout.IsAttaching:
                    attachButton.Enabled = false;
                    attachButton.Text = "Attaching";
                    break;
                case FormLayout.IsDetached:
                    attachButton.Enabled = true;
                    attachButton.Text = "Attach";
                    break;
            }
        }
        public void Enter(object control)
        {
            if (control is Button)
            {
                var button = control as Button;
                button.BackColor = Color.Orange;
                button.ForeColor = Color.White;
            }

            if (control is TextBox)
            {
                var textBox = control as TextBox;
                textBox.BackColor = Color.Orange;
                textBox.ForeColor = Color.White;
                textBox.Select(textBox.Text.Length, 0);
            }
        }

        public void Leave(object control)
        {
            if (control is Button)
            {
                var button = control as Button;
                button.BackColor = Color.Gray;
                button.ForeColor = Color.Gainsboro;
            }

            if (control is TextBox)
            {
                var textBox = control as TextBox;
                textBox.BackColor = Color.Gray;
                textBox.ForeColor = Color.Gainsboro;
            }
        }
    }
}
