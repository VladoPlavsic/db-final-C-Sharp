using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Shop
{
    public partial class Courier : Form
    {

        private String m_Username;
        private String m_Password;

        private int m_ID;

        private Form m_Parent;

        private SqlConnection m_Connection;
        private Dictionary<String, String> m_Query = new Dictionary<String, String>();

        public Courier(String username, String password, Form parentForm)
        {
            InitializeComponent();
            this.m_Parent = parentForm;

            this.m_Username = username;
            this.m_Password = password;
            
            this.m_Connection = SQL.Connect(this.m_Username, this.m_Password);
            
            this.m_ID = Convert.ToInt32(username.Split('_')[1]);

            this.FillQuery();
            this.ShowData();
        }

        private void FillQuery()
        {
            this.m_Query.Add("data", String.Format("SELECT * FROM courier_view_function({0})", this.m_ID));
            this.m_Query.Add("deliver", String.Format("EXECUTE product_delivered @order_id=placeholder_order_id, @courier_id={0}", this.m_ID));
        }

        private void ShowData()
        {


            if (m_Connection == null)
            {
                Error popup = new Error("Error trying to obtain connection to database! Please check username and password.");
                popup.Show();
                return;
            }

            try
            {

                SqlCommand command = new SqlCommand(this.m_Query["data"], this.m_Connection);

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                DataTable table = new DataTable();

                adapter.Fill(table);

                this.dataGridView1.DataSource = table;
            }
            catch (Exception e)
            {
                Console.WriteLine(String.Format("Error trying to fill Courier delivery data!\nExited with:\n{0}", e));
            }
        }

        private void deliverButton_Click(object sender, EventArgs e)
        {


            String orderID = this.id_textBox.Text.ToString();
            SQL.ExecuteQuery(this.m_Query["deliver"].Replace("placeholder_order_id", orderID), this.m_Connection);
         
            ShowData();
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            this.m_Connection.Close();
            this.m_Parent.Show();
            this.Close();
        }
    }
}
