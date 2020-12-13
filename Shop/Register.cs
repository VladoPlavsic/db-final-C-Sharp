﻿using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Shop
{
    public partial class Register : Form
    {
        private SqlConnection m_Connection;
        private Form m_Parent;
        public String Username;
        public String Password;

        public Register(Form parent)
        {
            this.m_Connection = SQL.Connect("register","register");
            this.m_Parent = parent;
            InitializeComponent();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            if(this.adressTB.TextLength == 0 || this.telTB.TextLength == 0 || this.fioTB.TextLength == 0 || this.emailTB.TextLength == 0)
            {
                Error error = new Error("Error! Please Fill all the fileds!");
                error.ShowDialog();
                return;
            }

            Username = this.usernameTB.Text.ToString();
            Password = this.passwordTB.Text.ToString();
            String query = String.Format("EXECUTE register_client @fio='{0}', @adress='{1}', @tel='{2}', @email='{3}', @username='{4}', @password='{5}'",this.fioTB.Text.ToString(), this.adressTB.Text.ToString(), this.telTB.Text.ToString(), this.emailTB.Text.ToString(), Username, Password);
            try
            {
                SQL.ExecuteQuery(query, this.m_Connection);
                this.m_Parent.Show();
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex) 
            {
                Console.WriteLine(String.Format("Error in Register, executing register. Exited With\n{0}", ex));
                this.DialogResult = DialogResult.Cancel;
            }
            this.Close();
        }
    }
}
