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

            if (response == 1)
            {
                AdminPage admin = new AdminPage(username, passworod, this);
                this.Hide();
                admin.Show();
            }
            else if (response == 0)
            {
                Courier courier = new Courier(username, passworod, this);

                this.Hide();
                courier.Show();
            }
            else
            {
                Error error = new Error("Looks like you've enterted wrong credientals. Please try again!");
                error.ShowDialog();
            }
        }

       



        /*GUEST LOGIN*/
        private void loginGuestIDButton_Click(object sender, EventArgs e)
        {
            if(this.identificationTextBox.Text.Length == 0)
            {
                Error error = new Error("Error: Please don't leave field empty");
                error.Show();
                return;
            }

            try
            {
                int ID = Convert.ToInt32(this.identificationTextBox.Text.ToString());
                Guest guest = new Guest(ID, this);
                if (!guest.IsDisposed)
                {
                    this.Hide();
                    guest.Show();
                }
            }
            catch
            {
                Error error = new Error("Error: Please enter valid ID");
                error.Show();
                return;
            };
        }

        private void loginGuestEmailButton_Click(object sender, EventArgs e)
        {

            String email = this.identificationTextBox.Text.ToString();

            Console.WriteLine(SQL.UseCLR(String.Format("SELECT dbo.custom_clr_function('{0}') reg", email)));
            /*
            if () 
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
            */
            if (this.identificationTextBox.Text.Length == 0)
            {
                Error error = new Error("Error: Please don't leave field empty");
                error.Show();
                return;
            }

            Guest guest = new Guest(email, this);
            if (!guest.IsDisposed)
            {
                this.Hide();
                guest.Show();
            }
        }
    }
}
