using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mayhem
{
    public partial class NonBlockingMessageBoxForm : Form
    {
        private readonly string title;
        private readonly string message;
        private readonly MessageBoxButtons buttons;

        public NonBlockingMessageBoxForm(string title, string message, MessageBoxButtons buttons)
        {
            InitializeComponent();
            this.title = title;
            this.message = message;
            this.buttons = buttons;

            // Set the DialogResult based on the MessageBoxButtons
            switch (buttons)
            {
                case MessageBoxButtons.OK:
                    this.DialogResult = DialogResult.OK;
                    break;
                case MessageBoxButtons.OKCancel:
                    this.DialogResult = DialogResult.Cancel;
                    break;
                case MessageBoxButtons.AbortRetryIgnore:
                    this.DialogResult = DialogResult.Abort;
                    break;
                case MessageBoxButtons.YesNoCancel:
                    this.DialogResult = DialogResult.Cancel;
                    break;
                case MessageBoxButtons.YesNo:
                    this.DialogResult = DialogResult.No;
                    break;
                case MessageBoxButtons.RetryCancel:
                    this.DialogResult = DialogResult.Cancel;
                    break;
                default:
                    this.DialogResult = DialogResult.None;
                    break;
            }
        }

        private async void NonBlockingMessageBoxForm_Load(object sender, EventArgs e)
        {
            // Wait for 1 second
            await Task.Delay(2000);

            // When the form loads, show the non-blocking message box
            MessageBox.Show(this.message, this.title, this.buttons, MessageBoxIcon.Information);

            // Close only the instance of NonBlockingMessageBoxForm that triggered the message box
            Close();
        }
    }
}
