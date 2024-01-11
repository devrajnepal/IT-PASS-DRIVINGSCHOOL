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
    public partial class booking : Form
    {
        public booking()
        {
            InitializeComponent();
        }

        private void booking_Load(object sender, EventArgs e)
        {
            listView1.Columns.Add("Student Name", 200);
            listView1.Columns.Add("Boking Date", 200);
            listView1.Columns.Add("Booking Time", 200);
            listView1.Columns.Add("Lession Type", 250);
            listView1.Columns.Add("Vechile Type", 250);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListViewItem newItem = new ListViewItem(txtfirstname.Text);
            newItem.SubItems.Add(dtpbookingdate.Text);
            newItem.SubItems.Add(txtbookingtime.Text);
            newItem.SubItems.Add(cmblessiontype.Text);
            newItem.SubItems.Add(cmbvechiletype.Text);
            listView1.Items.Add(newItem);
            MessageBox.Show("Booking completed successfully!!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                listView1.SelectedItems[0].SubItems[0].Text = txtfirstname.Text;
                listView1.SelectedItems[0].SubItems[1].Text = dtpbookingdate.Text;
                listView1.SelectedItems[0].SubItems[2].Text = txtbookingtime.Text;
                listView1.SelectedItems[0].SubItems[3].Text = cmblessiontype.Text;
                listView1.SelectedItems[0].SubItems[4].Text = cmbvechiletype.Text;
                MessageBox.Show("Record updated successfully");
            }
        }

        private void listView1_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                txtfirstname.Text = listView1.SelectedItems[0].SubItems[0].Text;
                dtpbookingdate.Text = listView1.SelectedItems[0].SubItems[1].Text;
                txtbookingtime.Text = listView1.SelectedItems[0].SubItems[2].Text;
                cmblessiontype.Text = listView1.SelectedItems[0].SubItems[3].Text;
                cmbvechiletype.Text = listView1.SelectedItems[0].SubItems[4].Text;
            }
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                txtfirstname.Text = listView1.SelectedItems[0].SubItems[0].Text;
                dtpbookingdate.Text = listView1.SelectedItems[0].SubItems[1].Text;
                txtbookingtime.Text = listView1.SelectedItems[0].SubItems[2].Text;
                cmblessiontype.Text = listView1.SelectedItems[0].SubItems[3].Text;
                cmbvechiletype.Text = listView1.SelectedItems[0].SubItems[4].Text;
            }
        }
    }
}
