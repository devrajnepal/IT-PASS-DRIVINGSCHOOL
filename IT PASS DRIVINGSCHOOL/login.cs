namespace IT_PASS_DRIVINGSCHOOL
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtusername.Text == "Admin" && txtpassword.Text == "Admin")
            {
                Frmmainpage frmmainpage = new Frmmainpage();
                frmmainpage.ShowDialog();

            }
            else
            {
                lblmessage.Text = "invalid username / password";


            }

        }

        private void txtusername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {

                e.Handled = true;
            }
        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
