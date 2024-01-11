namespace IT_PASS_DRIVINGSCHOOL
{
    partial class Frmmainpage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmmainpage));
            menuStrip1 = new MenuStrip();
            homeToolStripMenuItem = new ToolStripMenuItem();
            studentRegisterToolStripMenuItem = new ToolStripMenuItem();
            instructorRegisterToolStripMenuItem = new ToolStripMenuItem();
            lesonBookingToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { homeToolStripMenuItem, studentRegisterToolStripMenuItem, instructorRegisterToolStripMenuItem, lesonBookingToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 2, 0, 2);
            menuStrip1.Size = new Size(881, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            homeToolStripMenuItem.Size = new Size(108, 29);
            homeToolStripMenuItem.Text = " About Us";
            homeToolStripMenuItem.Click += homeToolStripMenuItem_Click;
            // 
            // studentRegisterToolStripMenuItem
            // 
            studentRegisterToolStripMenuItem.Name = "studentRegisterToolStripMenuItem";
            studentRegisterToolStripMenuItem.Size = new Size(157, 29);
            studentRegisterToolStripMenuItem.Text = "Student Register";
            studentRegisterToolStripMenuItem.Click += studentRegisterToolStripMenuItem_Click;
            // 
            // instructorRegisterToolStripMenuItem
            // 
            instructorRegisterToolStripMenuItem.Name = "instructorRegisterToolStripMenuItem";
            instructorRegisterToolStripMenuItem.Size = new Size(172, 29);
            instructorRegisterToolStripMenuItem.Text = "Instructor Register";
            instructorRegisterToolStripMenuItem.Click += instructorRegisterToolStripMenuItem_Click;
            // 
            // lesonBookingToolStripMenuItem
            // 
            lesonBookingToolStripMenuItem.Name = "lesonBookingToolStripMenuItem";
            lesonBookingToolStripMenuItem.Size = new Size(153, 29);
            lesonBookingToolStripMenuItem.Text = "Lesson Booking";
            lesonBookingToolStripMenuItem.Click += lesonBookingToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(207, 84);
            label1.Name = "label1";
            label1.Size = new Size(562, 45);
            label1.TabIndex = 1;
            label1.Text = "Wel-Come To IT Pass Driving School";
            // 
            // Frmmainpage
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(881, 552);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            DoubleBuffered = true;
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "Frmmainpage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main Page";
            WindowState = FormWindowState.Maximized;
            Load += Frmmainpage_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem homeToolStripMenuItem;
        private ToolStripMenuItem studentRegisterToolStripMenuItem;
        private ToolStripMenuItem instructorRegisterToolStripMenuItem;
        private ToolStripMenuItem lesonBookingToolStripMenuItem;
        private Label label1;
    }
}