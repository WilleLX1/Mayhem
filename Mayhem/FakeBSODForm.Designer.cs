namespace Mayhem
{
    partial class FakeBSODForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FakeBSODForm));
            gbAll = new GroupBox();
            pictureBox1 = new PictureBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            txtTitle = new TextBox();
            gbAll.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // gbAll
            // 
            gbAll.BackColor = SystemColors.Highlight;
            gbAll.Controls.Add(pictureBox1);
            gbAll.Controls.Add(textBox3);
            gbAll.Controls.Add(textBox2);
            gbAll.Controls.Add(textBox1);
            gbAll.Controls.Add(txtTitle);
            gbAll.Cursor = Cursors.AppStarting;
            gbAll.Dock = DockStyle.Fill;
            gbAll.ForeColor = SystemColors.ActiveCaptionText;
            gbAll.Location = new Point(0, 0);
            gbAll.Name = "gbAll";
            gbAll.Size = new Size(1519, 1055);
            gbAll.TabIndex = 0;
            gbAll.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(278, 690);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(132, 144);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.Highlight;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.ForeColor = SystemColors.Window;
            textBox3.Location = new Point(416, 690);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(1198, 207);
            textBox3.TabIndex = 3;
            textBox3.Text = "For more information about this issue and possible fixes, visit: https://www.windows.com/stopcode\r\n\r\n\r\nIf you call a support person, give them this info:\r\nStop code: CRITICAL_PROCESS_DIED";
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.Highlight;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.ForeColor = SystemColors.Window;
            textBox2.Location = new Point(267, 613);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(970, 71);
            textBox2.TabIndex = 2;
            textBox2.Text = "20% Complete";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Highlight;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 154.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.ForeColor = SystemColors.Window;
            textBox1.Location = new Point(278, 43);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(250, 377);
            textBox1.TabIndex = 1;
            textBox1.Text = ":(";
            // 
            // txtTitle
            // 
            txtTitle.BackColor = SystemColors.Highlight;
            txtTitle.BorderStyle = BorderStyle.None;
            txtTitle.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTitle.ForeColor = SystemColors.Window;
            txtTitle.Location = new Point(267, 426);
            txtTitle.Multiline = true;
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(970, 181);
            txtTitle.TabIndex = 0;
            txtTitle.Text = "Your PC ran into a problem and needs to restart. We're just collecting some error info, and then we'll restart for you.";
            // 
            // FakeBSODForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1519, 1055);
            Controls.Add(gbAll);
            Name = "FakeBSODForm";
            Text = "FakeBSODForm";
            Load += FakeBSODForm_Load;
            gbAll.ResumeLayout(false);
            gbAll.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbAll;
        private TextBox txtTitle;
        private TextBox textBox1;
        private TextBox textBox3;
        private TextBox textBox2;
        private PictureBox pictureBox1;
    }
}