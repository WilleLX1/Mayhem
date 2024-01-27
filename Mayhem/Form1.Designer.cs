namespace Mayhem
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnWallpaper = new Button();
            btnMsgbox = new Button();
            btnWeb = new Button();
            btnMouse = new Button();
            btnTaskmgr = new Button();
            btnResize = new Button();
            btnSound = new Button();
            btnFiles = new Button();
            btnFakeBSOD = new Button();
            btnBSOD = new Button();
            btnKill = new Button();
            txtOutput = new TextBox();
            btnMayhem = new Button();
            SuspendLayout();
            // 
            // btnWallpaper
            // 
            btnWallpaper.Location = new Point(12, 12);
            btnWallpaper.Name = "btnWallpaper";
            btnWallpaper.Size = new Size(140, 29);
            btnWallpaper.TabIndex = 0;
            btnWallpaper.Text = "Wallpaper";
            btnWallpaper.UseVisualStyleBackColor = true;
            btnWallpaper.Click += btnWallpaper_Click;
            // 
            // btnMsgbox
            // 
            btnMsgbox.Location = new Point(12, 47);
            btnMsgbox.Name = "btnMsgbox";
            btnMsgbox.Size = new Size(140, 29);
            btnMsgbox.TabIndex = 1;
            btnMsgbox.Text = "Messagebox";
            btnMsgbox.UseVisualStyleBackColor = true;
            btnMsgbox.Click += btnMsgbox_Click;
            // 
            // btnWeb
            // 
            btnWeb.Location = new Point(12, 82);
            btnWeb.Name = "btnWeb";
            btnWeb.Size = new Size(140, 29);
            btnWeb.TabIndex = 2;
            btnWeb.Text = "Web browser";
            btnWeb.UseVisualStyleBackColor = true;
            btnWeb.Click += btnWeb_Click;
            // 
            // btnMouse
            // 
            btnMouse.Location = new Point(12, 117);
            btnMouse.Name = "btnMouse";
            btnMouse.Size = new Size(140, 29);
            btnMouse.TabIndex = 3;
            btnMouse.Text = "Move Mouse";
            btnMouse.UseVisualStyleBackColor = true;
            btnMouse.Click += btnMouse_Click;
            // 
            // btnTaskmgr
            // 
            btnTaskmgr.Location = new Point(12, 152);
            btnTaskmgr.Name = "btnTaskmgr";
            btnTaskmgr.Size = new Size(140, 29);
            btnTaskmgr.TabIndex = 4;
            btnTaskmgr.Text = "Fake Taskmgr";
            btnTaskmgr.UseVisualStyleBackColor = true;
            btnTaskmgr.Click += btnTaskmgr_Click;
            // 
            // btnResize
            // 
            btnResize.Location = new Point(12, 187);
            btnResize.Name = "btnResize";
            btnResize.Size = new Size(140, 29);
            btnResize.TabIndex = 5;
            btnResize.Text = "Resize...";
            btnResize.UseVisualStyleBackColor = true;
            btnResize.Click += btnResize_Click;
            // 
            // btnSound
            // 
            btnSound.Location = new Point(12, 222);
            btnSound.Name = "btnSound";
            btnSound.Size = new Size(140, 29);
            btnSound.TabIndex = 6;
            btnSound.Text = "Random Sound";
            btnSound.UseVisualStyleBackColor = true;
            btnSound.Click += btnSound_Click;
            // 
            // btnFiles
            // 
            btnFiles.Location = new Point(12, 257);
            btnFiles.Name = "btnFiles";
            btnFiles.Size = new Size(140, 29);
            btnFiles.TabIndex = 7;
            btnFiles.Text = "File Manipulation";
            btnFiles.UseVisualStyleBackColor = true;
            btnFiles.Click += btnFiles_Click;
            // 
            // btnFakeBSOD
            // 
            btnFakeBSOD.Location = new Point(12, 292);
            btnFakeBSOD.Name = "btnFakeBSOD";
            btnFakeBSOD.Size = new Size(140, 29);
            btnFakeBSOD.TabIndex = 8;
            btnFakeBSOD.Text = "Fake BSOD";
            btnFakeBSOD.UseVisualStyleBackColor = true;
            btnFakeBSOD.Click += btnFakeBSOD_Click;
            // 
            // btnBSOD
            // 
            btnBSOD.Location = new Point(12, 327);
            btnBSOD.Name = "btnBSOD";
            btnBSOD.Size = new Size(140, 29);
            btnBSOD.TabIndex = 9;
            btnBSOD.Text = "Fr BSOD";
            btnBSOD.UseVisualStyleBackColor = true;
            btnBSOD.Click += btnBSOD_Click;
            // 
            // btnKill
            // 
            btnKill.Location = new Point(12, 362);
            btnKill.Name = "btnKill";
            btnKill.Size = new Size(140, 29);
            btnKill.TabIndex = 10;
            btnKill.Text = "Suicide";
            btnKill.UseVisualStyleBackColor = true;
            btnKill.Click += btnKill_Click;
            // 
            // txtOutput
            // 
            txtOutput.Dock = DockStyle.Right;
            txtOutput.Location = new Point(189, 0);
            txtOutput.Multiline = true;
            txtOutput.Name = "txtOutput";
            txtOutput.ScrollBars = ScrollBars.Vertical;
            txtOutput.Size = new Size(611, 646);
            txtOutput.TabIndex = 11;
            // 
            // btnMayhem
            // 
            btnMayhem.Location = new Point(12, 605);
            btnMayhem.Name = "btnMayhem";
            btnMayhem.Size = new Size(140, 29);
            btnMayhem.TabIndex = 12;
            btnMayhem.Text = "Mayhem";
            btnMayhem.UseVisualStyleBackColor = true;
            btnMayhem.Click += btnMayhem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 646);
            Controls.Add(btnMayhem);
            Controls.Add(txtOutput);
            Controls.Add(btnKill);
            Controls.Add(btnBSOD);
            Controls.Add(btnFakeBSOD);
            Controls.Add(btnFiles);
            Controls.Add(btnSound);
            Controls.Add(btnResize);
            Controls.Add(btnTaskmgr);
            Controls.Add(btnMouse);
            Controls.Add(btnWeb);
            Controls.Add(btnMsgbox);
            Controls.Add(btnWallpaper);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnWallpaper;
        private Button btnMsgbox;
        private Button btnWeb;
        private Button btnMouse;
        private Button btnTaskmgr;
        private Button btnResize;
        private Button btnSound;
        private Button btnFiles;
        private Button btnFakeBSOD;
        private Button btnBSOD;
        private Button btnKill;
        private TextBox txtOutput;
        private Button btnMayhem;
    }
}
