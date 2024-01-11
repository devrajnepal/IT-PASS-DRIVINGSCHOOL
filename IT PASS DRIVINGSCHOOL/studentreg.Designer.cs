namespace IT_PASS_DRIVINGSCHOOL
{
    partial class studentreg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(studentreg));
            txtfirstname = new TextBox();
            txtlastname = new TextBox();
            txtphon = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtaddress = new TextBox();
            dtpDOB = new DateTimePicker();
            label5 = new Label();
            cmbGender = new ComboBox();
            label6 = new Label();
            Save = new Button();
            listView1 = new ListView();
            SuspendLayout();
            // 
            // txtfirstname
            // 
            txtfirstname.Location = new Point(145, 47);
            txtfirstname.Name = "txtfirstname";
            txtfirstname.Size = new Size(294, 31);
            txtfirstname.TabIndex = 0;
            txtfirstname.TextChanged += txtfirstname_TextChanged;
            txtfirstname.KeyPress += tbfirstname_KeyPress;
            // 
            // txtlastname
            // 
            txtlastname.Location = new Point(145, 101);
            txtlastname.Name = "txtlastname";
            txtlastname.Size = new Size(294, 31);
            txtlastname.TabIndex = 1;
            txtlastname.KeyPress += textBox2_KeyPress;
            // 
            // txtphon
            // 
            txtphon.Location = new Point(640, 50);
            txtphon.Name = "txtphon";
            txtphon.Size = new Size(294, 31);
            txtphon.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 50);
            label1.Name = "label1";
            label1.Size = new Size(97, 25);
            label1.TabIndex = 3;
            label1.Text = "First Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 104);
            label2.Name = "label2";
            label2.Size = new Size(95, 25);
            label2.TabIndex = 4;
            label2.Text = "Last Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(505, 53);
            label3.Name = "label3";
            label3.Size = new Size(132, 25);
            label3.TabIndex = 5;
            label3.Text = "Phone Number";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(505, 103);
            label4.Name = "label4";
            label4.Size = new Size(77, 25);
            label4.TabIndex = 6;
            label4.Text = "Address";
            // 
            // txtaddress
            // 
            txtaddress.Location = new Point(640, 97);
            txtaddress.Name = "txtaddress";
            txtaddress.Size = new Size(294, 31);
            txtaddress.TabIndex = 7;
            // 
            // dtpDOB
            // 
            dtpDOB.Format = DateTimePickerFormat.Short;
            dtpDOB.Location = new Point(640, 151);
            dtpDOB.Name = "dtpDOB";
            dtpDOB.Size = new Size(294, 31);
            dtpDOB.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(505, 154);
            label5.Name = "label5";
            label5.Size = new Size(115, 25);
            label5.TabIndex = 9;
            label5.Text = "Date Of Birth";
            // 
            // cmbGender
            // 
            cmbGender.FormattingEnabled = true;
            cmbGender.Items.AddRange(new object[] { "Male", "Female", "Other" });
            cmbGender.Location = new Point(145, 154);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(294, 33);
            cmbGender.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(10, 155);
            label6.Name = "label6";
            label6.Size = new Size(69, 25);
            label6.TabIndex = 11;
            label6.Text = "Gender";
            // 
            // Save
            // 
            Save.Location = new Point(444, 216);
            Save.Name = "Save";
            Save.Size = new Size(112, 34);
            Save.TabIndex = 14;
            Save.Text = "Save";
            Save.UseVisualStyleBackColor = true;
            Save.Click += button1_Click;
            // 
            // listView1
            // 
            listView1.Location = new Point(10, 273);
            listView1.Name = "listView1";
            listView1.Size = new Size(1064, 229);
            listView1.TabIndex = 15;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // studentreg
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1086, 514);
            Controls.Add(listView1);
            Controls.Add(Save);
            Controls.Add(label6);
            Controls.Add(cmbGender);
            Controls.Add(label5);
            Controls.Add(dtpDOB);
            Controls.Add(txtaddress);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtphon);
            Controls.Add(txtlastname);
            Controls.Add(txtfirstname);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "studentreg";
            Text = "Student Registration";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtfirstname;
        private TextBox txtlastname;
        private TextBox txtphon;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtaddress;
        private DateTimePicker dtpDOB;
        private Label label5;
        private ComboBox cmbGender;
        private Label label6;
        private Button Save;
        private ListView listView1;
    }
}