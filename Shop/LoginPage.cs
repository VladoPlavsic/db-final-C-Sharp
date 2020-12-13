using System;
using System.Windows.Forms;

namespace Shop
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = this.loginUsername.Text;
            string passworod = this.loginPassword.Text;

            int response = SQL.IsAdmin(username, passworod);

            if (response == 0)
            {
                AdminPage admin = new AdminPage(username, passworod, this);
                this.Hide();
                admin.Show();
            }
            else if (response == 1)
            {
                Courier courier = new Courier(username, passworod, this);

                this.Hide();
                courier.Show();
            }
            else if (response == 2)
            {
                Guest guest = new Guest(username, passworod, this);

                this.Hide();
                guest.Show();
            }
            else
            {
                Error error = new Error("Looks like you've enterted wrong credientals. Please try again! Or register.");
                error.ShowDialog();
            }
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            Register register = new Register(this);
            this.Hide();
            var response = register.ShowDialog();
            if (response == DialogResult.OK)
            {
                Guest guest = new Guest(register.Username, register.Password, this);

                register.Close();
                this.Hide();
                guest.Show();
            }
            else
            {
                return;
            }
        }
    }
}
