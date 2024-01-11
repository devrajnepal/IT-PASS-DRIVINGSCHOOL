namespace IT_PASS_DRIVINGSCHOOL
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            button1 = new Button();
            lbuser = new Label();
            lbpassword = new Label();
            txtusername = new TextBox();
            txtpassword = new TextBox();
            lblmessage = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(344, 298);
            button1.Name = "button1";
            button1.Size = new Size(112, 50);
            button1.TabIndex = 0;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lbuser
            // 
            lbuser.AutoSize = true;
            lbuser.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbuser.Location = new Point(95, 81);
            lbuser.Name = "lbuser";
            lbuser.RightToLeft = RightToLeft.No;
            lbuser.Size = new Size(139, 32);
            lbuser.TabIndex = 1;
            lbuser.Text = "User Name";
            // 
            // lbpassword
            // 
            lbpassword.AutoSize = true;
            lbpassword.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbpassword.Location = new Point(95, 152);
            lbpassword.Name = "lbpassword";
            lbpassword.Size = new Size(122, 32);
            lbpassword.TabIndex = 2;
            lbpassword.Text = "Password";
            // 
            // txtusername
            // 
            txtusername.Location = new Point(240, 75);
            txtusername.Multiline = true;
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(412, 40);
            txtusername.TabIndex = 3;
            txtusername.TextChanged += txtusername_TextChanged;
            txtusername.KeyPress += txtusername_KeyPress;
            // 
            // txtpassword
            // 
            txtpassword.Location = new Point(240, 144);
            txtpassword.Multiline = true;
            txtpassword.Name = "txtpassword";
            txtpassword.PasswordChar = '*';
            txtpassword.Size = new Size(412, 43);
            txtpassword.TabIndex = 4;
            // 
            // lblmessage
            // 
            lblmessage.AutoSize = true;
            lblmessage.Location = new Point(349, 236);
            lblmessage.Name = "lblmessage";
            lblmessage.Size = new Size(0, 25);
            lblmessage.TabIndex = 5;
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.LOGO_ICO;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(874, 395);
            Controls.Add(lblmessage);
            Controls.Add(txtpassword);
            Controls.Add(txtusername);
            Controls.Add(lbpassword);
            Controls.Add(lbuser);
            Controls.Add(button1);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login page";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label lbuser;
        private Label lbpassword;
        private TextBox txtusername;
        private TextBox txtpassword;
        private Label lblmessage;
    }
}
