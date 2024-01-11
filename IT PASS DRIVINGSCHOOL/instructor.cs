using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IT_PASS_DRIVINGSCHOOL
{
    public partial class Instructor : Form
    {
        public Instructor()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            else { e.Handled = false; }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            else { e.Handled = false; }
        }

        private void comboBox1_DropDown(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtfirstname.Text == "" && txtlastname.Text == "" && txtphone.Text == "" )
            {
                MessageBox.Show("All fields are required...");
            }
            else
            {
                ListViewItem newItem = new ListViewItem(txtfirstname.Text);
                newItem.SubItems.Add(txtlastname.Text);
                newItem.SubItems.Add(txtphone.Text);
                newItem.SubItems.Add(comboBox1.Text);
                listView1.Items.Add(newItem);
                MessageBox.Show("Instructors details saved successfully.");
            }
        }

        private void Instructor_Load(object sender, EventArgs e)
        {
            listView1.Columns.Add("First Name", 150);
            listView1.Columns.Add("Last Name", 150);
            listView1.Columns.Add("Phone", 180);
            listView1.Columns.Add("Gender", 150);
        }
    }
}