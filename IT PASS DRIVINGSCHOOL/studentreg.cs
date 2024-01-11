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
    public partial class studentreg : Form
    {
        public studentreg()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            listView1.Columns.Add("First Name", 150);
            listView1.Columns.Add("Last Name Date", 150);
            listView1.Columns.Add("Phone Number", 180);
            listView1.Columns.Add("Address", 250);
            listView1.Columns.Add("Date", 150);
            listView1.Columns.Add("Gender", 120);
        }

        private void tbfirstname_KeyPress(object sender, KeyPressEventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtfirstname.Text == "" && txtlastname.Text == "" && txtphon.Text=="")
            {
                MessageBox.Show("All fields are  required...");
            }
            else
            {
                ListViewItem newItem = new ListViewItem(txtfirstname.Text);
                newItem.SubItems.Add(txtlastname.Text);
                newItem.SubItems.Add(cmbGender.Text);
                newItem.SubItems.Add(txtphon.Text);
                newItem.SubItems.Add(txtaddress.Text);
                newItem.SubItems.Add(dtpDOB.Text);
                listView1.Items.Add(newItem);
                MessageBox.Show("Students details saved successfully.");
            }
        }

        private void txtfirstname_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
