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
    public partial class Frmmainpage : Form
    {
        public Frmmainpage()
        {
            InitializeComponent();
        }

        private void studentRegisterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            studentreg f3 = new studentreg();
            f3.Show();
        }

        private void aaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void instructorRegisterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Instructor instructor = new Instructor();
            instructor.Show();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lesonBookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            booking frmBook = new booking();
            frmBook.Show();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Frmmainpage_Load(object sender, EventArgs e)
        {

        }
    }
}
