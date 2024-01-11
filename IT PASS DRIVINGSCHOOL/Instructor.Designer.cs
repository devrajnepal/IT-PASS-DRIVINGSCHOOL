namespace IT_PASS_DRIVINGSCHOOL
{
    partial class Instructor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Instructor));
            txtfirstname = new TextBox();
            txtlastname = new TextBox();
            txtphone = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            comboBox1 = new ComboBox();
            label6 = new Label();
            button1 = new Button();
            listView1 = new ListView();
            SuspendLayout();
            // 
            // txtfirstname
            // 
            txtfirstname.Location = new Point(162, 40);
            txtfirstname.Name = "txtfirstname";
            txtfirstname.Size = new Size(292, 31);
            txtfirstname.TabIndex = 0;
            txtfirstname.KeyPress += textBox1_KeyPress;
            // 
            // txtlastname
            // 
            txtlastname.Location = new Point(162, 98);
            txtlastname.Name = "txtlastname";
            txtlastname.Size = new Size(292, 31);
            txtlastname.TabIndex = 1;
            txtlastname.KeyPress += textBox2_KeyPress;
            // 
            // txtphone
            // 
            txtphone.Location = new Point(162, 157);
            txtphone.Name = "txtphone";
            txtphone.Size = new Size(292, 31);
            txtphone.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 40);
            label1.Name = "label1";
            label1.Size = new Size(97, 25);
            label1.TabIndex = 4;
            label1.Text = "First Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 95);
            label2.Name = "label2";
            label2.Size = new Size(95, 25);
            label2.TabIndex = 5;
            label2.Text = "Last Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 154);
            label3.Name = "label3";
            label3.Size = new Size(132, 25);
            label3.TabIndex = 6;
            label3.Text = "Phone Number";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Male", "Female", "Other" });
            comboBox1.Location = new Point(162, 213);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(292, 33);
            comboBox1.TabIndex = 9;
            comboBox1.DropDown += comboBox1_DropDown;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(32, 221);
            label6.Name = "label6";
            label6.Size = new Size(69, 25);
            label6.TabIndex = 11;
            label6.Text = "Gender";
            // 
            // button1
            // 
            button1.Location = new Point(162, 284);
            button1.Name = "button1";
            button1.Size = new Size(222, 34);
            button1.TabIndex = 12;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listView1
            // 
            listView1.Location = new Point(476, 33);
            listView1.Name = "listView1";
            listView1.Size = new Size(613, 285);
            listView1.TabIndex = 13;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // Instructor
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveBorder;
            ClientSize = new Size(1114, 360);
            Controls.Add(listView1);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtphone);
            Controls.Add(txtlastname);
            Controls.Add(txtfirstname);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Instructor";
            Text = "Instructor Registration";
            Load += Instructor_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtfirstname;
        private TextBox txtlastname;
        private TextBox txtphone;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox comboBox1;
        private Label label6;
        private Button button1;
        private ListView listView1;
    }
}