using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mayhem
{
    public partial class FakeBSODForm : Form
    {
        [DllImport("user32.dll")]
        private static extern int ShowWindow(int hwnd, int nCmdShow);

        private const int SW_HIDE = 0;
        private const int SW_SHOW = 1;

        public FakeBSODForm()
        {
            InitializeComponent();
        }

        private void FakeBSODForm_Load(object sender, EventArgs e)
        {
            // Set the form to full screen including the taskbar area
            this.FormBorderStyle = FormBorderStyle.None;
            this.Bounds = Screen.PrimaryScreen.Bounds;

            // Hide the entire taskbar
            HideTaskbar();
        }

        private void HideTaskbar()
        {
            IntPtr hwnd = FindWindow("Shell_TrayWnd", "");
            ShowWindow((int)hwnd, SW_HIDE);
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            // Show the taskbar when the form is closed
            ShowTaskbar();
            base.OnFormClosed(e);
        }

        private void ShowTaskbar()
        {
            IntPtr hwnd = FindWindow("Shell_TrayWnd", "");
            ShowWindow((int)hwnd, SW_SHOW);
        }

        [DllImport("user32.dll", SetLastError = true)]
        private static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
    }
}
