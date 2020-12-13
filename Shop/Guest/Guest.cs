using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Shop
{
    public partial class Guest : Form
    {
        private int m_ID;
        
        private String m_Username;
        private String m_Password;

        private Dictionary<String, String> m_Query = new Dictionary<String, String>();
        private Dictionary<String, ComboBox> m_Shop = new Dictionary<String, ComboBox>();

        private Form m_Parent;

        private SqlConnection m_Connection;

        public Guest(String username, String password, Form parent)
        {
            this.m_Parent = parent;
            this.m_Username = username;
            this.m_Password = password;
            this.m_Connection = SQL.Connect(this.m_Username, this.m_Password);

            if (this.m_Connection == null)
            {
                Preview preview = new Preview("Ooops! Looks like you are not in our Database yet. Would you like to register?", this);
                var result = preview.ShowDialog();

                if (result == DialogResult.OK)
                {
                    if (RegisterClient())
                    {
                        this.m_Connection = SQL.Connect(this.m_Username, this.m_Password);
                    }
                    else
                    {
                        parent.Show();
                        this.Close();
                        return;
                    }
                }
                else
                {
                    parent.Show();
                    this.Close();
                    return;
                }
            }

            this.m_Query.Add("getId", String.Format("SELECT * FROM get_id_from_username('{0}')", this.m_Username));

            this.m_ID = this.GetId();

            if (m_ID == -1)
            {
                Error error = new Error(String.Format("Error looks like something is bad"));
                error.ShowDialog();
                parent.Show();
                this.Close();
                return;
            }


            InitializeComponent();

            this.FillQuery();

            ShowOrders();
            ShowShop();
        }

        private bool RegisterClient()
        {
            try
            {
                Register register = new Register(this);
                this.Hide();
                var response = register.ShowDialog();
                if(response == DialogResult.OK)
                {
                    this.m_Username = register.Username;
                    this.m_Password = register.Password;
                    return true;
                }
                return false;
            }
            catch (Exception e)
            {
                Console.WriteLine(String.Format("Error trying to register client.\n Exited with\n{0}", e));
                return false;
            }
        }

        private int GetId()
        {
            return SQL.GetFirst(this.m_Query["getId"], this.m_Connection);
        }

        private void FillQuery()
        {
            this.m_Query.Add("orders", String.Format("SELECT * FROM clients_order_view_function_id({0})", this.m_ID));
            this.m_Query.Add("category", String.Format("SELECT category FROM Category"));
            this.m_Query.Add("paint", String.Format("SELECT paint FROM Paint"));
            this.m_Query.Add("color", String.Format("SELECT color FROM Colors"));
            this.m_Query.Add("wood", String.Format("SELECT wood FROM Wood"));
            this.m_Query.Add("adress", String.Format("SELECT adress FROM available_adreses"));


            this.m_Query.Add("get_id", String.Format("SELECT * FROM id_by_name('category_placeholder','paint_placeholder','color_placeholder','wood_placeholder','adress_placeholder')"));
            this.m_Query.Add("place_order", String.Format("EXEC make_order @client_id={0}, @category_id=category_placeholder, @paint_id=paint_placeholder, @frame_id=frame_placeholder, @delivery_id=delivery_placeholder", this.m_ID));
            this.m_Query.Add("drop_order", String.Format("EXEC drop_order @order_id=order_placeholder, @client_id={0}", this.m_ID));


            this.m_Shop.Add("category", this.categoryCB);
            this.m_Shop.Add("paint", this.paintCB);
            this.m_Shop.Add("color", this.colorCB);
            this.m_Shop.Add("wood", this.woodCB);
            this.m_Shop.Add("adress", this.adressCB);
        }


        private void ShowShop()
        {
            FillCB("category");
            FillCB("paint");
            FillCB("color");
            FillCB("wood");
            FillCB("adress");
        }


        private void FillCB(String key)
        {

            List<String> list = SQL.GetAll(this.m_Query[key], this.m_Connection);

            this.m_Shop.Count();

            if (list == null)
                return;

            this.m_Shop[key].Items.AddRange(list.Cast<Object>().ToArray());
        }

        
        private void ShowOrders()
        {
            try
            {
                using (SqlCommand command = new SqlCommand(this.m_Query["orders"], this.m_Connection))
                {

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {

                        using (DataTable table = new DataTable())
                        {

                            adapter.Fill(table);
                            this.ordersGrid.DataSource = table;
                        }
                    }
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(String.Format("Error trying to fill Client orders.\nExited with:\n{0}", e));
            }
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            this.m_Connection.Close();
            this.m_Parent.Show();
            this.Close();
        }

        private void makeOrderButton_Click(object sender, EventArgs e)
        {
            StringBuilder test = new StringBuilder();

            foreach (KeyValuePair<String, ComboBox> entity in this.m_Shop)
            {
                test.Append(entity.Key);
                test.Append(" : ");
                test.Append(entity.Value.SelectedItem.ToString());
                test.Append("\n");
            }

            Preview preview = new Preview(test.ToString(), this);
            var result = preview.ShowDialog();

            if(result == DialogResult.OK)
            {
                var query = this.m_Query["get_id"];
                query = query.Replace("category_placeholder", this.m_Shop["category"].SelectedItem.ToString());
                query = query.Replace("paint_placeholder",    this.m_Shop["paint"].SelectedItem.ToString());
                query = query.Replace("color_placeholder",    this.m_Shop["color"].SelectedItem.ToString());
                query = query.Replace("wood_placeholder",     this.m_Shop["wood"].SelectedItem.ToString());
                query = query.Replace("adress_placeholder",   this.m_Shop["adress"].SelectedItem.ToString());

                var insertQuery = this.m_Query["place_order"];

                List<String> ID = new List<String>(4);

                var table = SQL.GetTable(query,this.m_Connection);
                foreach(DataRow row in table.Rows)
                {
                    foreach(var item in row.ItemArray)
                    {
                        ID.Add(item.ToString());
                    }
                }
                insertQuery = insertQuery.Replace("category_placeholder", ID.ElementAt(0));
                insertQuery = insertQuery.Replace("paint_placeholder", ID.ElementAt(1));
                insertQuery = insertQuery.Replace("frame_placeholder", ID.ElementAt(2));
                insertQuery = insertQuery.Replace("delivery_placeholder", ID.ElementAt(3));

                SQL.ExecuteQuery(insertQuery, this.m_Connection);
                ShowOrders();
            }
            else
            {
                return;
            }

        }

        private void dropOrderButton_Click(object sender, EventArgs e)
        {
            SQL.ExecuteQuery(this.m_Query["drop_order"].Replace("order_placeholder", this.orderIDTextBox.Text.ToString()), this.m_Connection);
            ShowOrders();
        }
    }
}
