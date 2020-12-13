using System;
using System.Windows.Forms;

namespace Shop
{
    public partial class Error : Form
    {
        public Error(String msg)
        {
            InitializeComponent();
            this.errorLabel.Text = msg;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
