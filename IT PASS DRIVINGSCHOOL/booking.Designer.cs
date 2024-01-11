namespace IT_PASS_DRIVINGSCHOOL
{
    partial class booking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(booking));
            label2 = new Label();
            label1 = new Label();
            txtbookingtime = new TextBox();
            txtfirstname = new TextBox();
            label3 = new Label();
            dtpbookingdate = new DateTimePicker();
            label4 = new Label();
            cmblessiontype = new ComboBox();
            label5 = new Label();
            cmbvechiletype = new ComboBox();
            button1 = new Button();
            listView1 = new ListView();
            button2 = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 84);
            label2.Name = "label2";
            label2.Size = new Size(125, 25);
            label2.TabIndex = 8;
            label2.Text = "Booking Time:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 30);
            label1.Name = "label1";
            label1.Size = new Size(129, 25);
            label1.TabIndex = 7;
            label1.Text = "Student Name:";
            // 
            // txtbookingtime
            // 
            txtbookingtime.Location = new Point(170, 78);
            txtbookingtime.Name = "txtbookingtime";
            txtbookingtime.Size = new Size(274, 31);
            txtbookingtime.TabIndex = 6;
            // 
            // txtfirstname
            // 
            txtfirstname.Location = new Point(170, 27);
            txtfirstname.Name = "txtfirstname";
            txtfirstname.Size = new Size(274, 31);
            txtfirstname.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(515, 30);
            label3.Name = "label3";
            label3.Size = new Size(124, 25);
            label3.TabIndex = 9;
            label3.Text = "Booking Date:";
            // 
            // dtpbookingdate
            // 
            dtpbookingdate.Format = DateTimePickerFormat.Short;
            dtpbookingdate.Location = new Point(662, 25);
            dtpbookingdate.Name = "dtpbookingdate";
            dtpbookingdate.Size = new Size(274, 31);
            dtpbookingdate.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(515, 87);
            label4.Name = "label4";
            label4.Size = new Size(112, 25);
            label4.TabIndex = 11;
            label4.Text = "Lesson Type:";
            // 
            // cmblessiontype
            // 
            cmblessiontype.FormattingEnabled = true;
            cmblessiontype.Items.AddRange(new object[] { "Standard", "Introductory", "Pass Plus", "Driving Test" });
            cmblessiontype.Location = new Point(662, 79);
            cmblessiontype.Name = "cmblessiontype";
            cmblessiontype.Size = new Size(278, 33);
            cmblessiontype.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 144);
            label5.Name = "label5";
            label5.Size = new Size(112, 25);
            label5.TabIndex = 13;
            label5.Text = "Vechile Type:";
            // 
            // cmbvechiletype
            // 
            cmbvechiletype.FormattingEnabled = true;
            cmbvechiletype.Items.AddRange(new object[] { "Bike", "Car", "Heavy" });
            cmbvechiletype.Location = new Point(170, 136);
            cmbvechiletype.Name = "cmbvechiletype";
            cmbvechiletype.Size = new Size(278, 33);
            cmbvechiletype.TabIndex = 14;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(282, 194);
            button1.Name = "button1";
            button1.Size = new Size(112, 50);
            button1.TabIndex = 15;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listView1
            // 
            listView1.Location = new Point(12, 272);
            listView1.Name = "listView1";
            listView1.Size = new Size(1071, 227);
            listView1.TabIndex = 16;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.ColumnClick += listView1_ColumnClick;
            listView1.Click += listView1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(515, 194);
            button2.Name = "button2";
            button2.Size = new Size(112, 50);
            button2.TabIndex = 17;
            button2.Text = "Edit";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // booking
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1084, 511);
            Controls.Add(button2);
            Controls.Add(listView1);
            Controls.Add(button1);
            Controls.Add(cmbvechiletype);
            Controls.Add(label5);
            Controls.Add(cmblessiontype);
            Controls.Add(label4);
            Controls.Add(dtpbookingdate);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtbookingtime);
            Controls.Add(txtfirstname);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "booking";
            Text = "booking";
            Load += booking_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private TextBox txtbookingtime;
        private TextBox txtfirstname;
        private Label label3;
        private DateTimePicker dtpbookingdate;
        private Label label4;
        private ComboBox cmblessiontype;
        private Label label5;
        private ComboBox cmbvechiletype;
        private Button button1;
        private ListView listView1;
        private Button button2;
    }
}