using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace Shop
{
    public partial class AdminPage : Form
    {
        private String m_Username;
        private String m_Password;

        private Form m_Parent;

        private SqlConnection m_Connection;

        private Dictionary<String, String> m_GridQuery = new Dictionary<String, String>();
        private Dictionary<String, DataGridView> m_Grids = new Dictionary<String, DataGridView>();

        private Dictionary<String, String> m_Query = new Dictionary<String, String>();
        private Dictionary<String, TextBox> m_TextBoxes = new Dictionary<String, TextBox>();

        public AdminPage(String username ,String password, Form parent)
        {
            this.m_Username = username;
            this.m_Password = password;

            this.m_Parent = parent;

            this.m_Connection = SQL.Connect(this.m_Username, this.m_Password);

            InitializeComponent();

            FillQuery();

            LoadData();

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.m_Parent.Show();
            this.Close();
        }

        private void FillQuery()
        {
            this.m_GridQuery.Add("colors",   "SELECT * FROM Colors");
            this.m_GridQuery.Add("paint",    "SELECT * FROM Paint");
            this.m_GridQuery.Add("category", "SELECT * FROM Category");
            this.m_GridQuery.Add("wood",     "SELECT * FROM Wood");
            this.m_GridQuery.Add("couriers", "SELECT * FROM couriers");
            this.m_GridQuery.Add("addresses","SELECT * FROM Delivery");
            this.m_GridQuery.Add("clients",  "SELECT * FROM Clients");

            this.m_Grids.Add("colors",   this.colorGrid);
            this.m_Grids.Add("paint",    this.paintGrid);
            this.m_Grids.Add("category", this.categoryGrid);
            this.m_Grids.Add("wood",     this.woodGrid);
            this.m_Grids.Add("couriers", this.couriersGrid);
            this.m_Grids.Add("addresses",this.addressesGrid);
            this.m_Grids.Add("clients",  this.clientsGrid);

            this.m_Query.Add("addCategory", "EXECUTE insert_category @category='");
            this.m_Query.Add("addColor",    "EXECUTE insert_colors @color='");
            this.m_Query.Add("addCourier",  "EXECUTE insert_courier @address='placeholder', @courier='");
            this.m_Query.Add("addDelivery", "EXECUTE insert_delivery @address='");
            this.m_Query.Add("addPaint",    "EXECUTE insert_paint @paint='");
            this.m_Query.Add("addWood",     "EXECUTE insert_wood @wood='");

            this.m_Query.Add("removeCategory", "EXECUTE delete_category @id=");
            this.m_Query.Add("removeColor",    "EXECUTE delete_colors @id=");
            this.m_Query.Add("removeCourier",  "EXECUTE delete_courier @id=");
            this.m_Query.Add("removeDelivery", "EXECUTE delete_delivery @id=");
            this.m_Query.Add("removePaint",    "EXECUTE delete_paint @id=");
            this.m_Query.Add("removeWood",     "EXECUTE delete_wood @id=");
            this.m_Query.Add("removeClient",   "EXECUTE delete_client @id=");

            this.m_TextBoxes.Add("addCategory", this.addCategoryTB); 
            this.m_TextBoxes.Add("addColor",    this.addColorTB);
            this.m_TextBoxes.Add("addCourier",  this.addCourierTB);
            this.m_TextBoxes.Add("addDelivery", this.addDeliveryTB);
            this.m_TextBoxes.Add("addPaint",    this.addPaintTB);
            this.m_TextBoxes.Add("addWood",     this.addWoodTB);

            this.m_TextBoxes.Add("removeCategory", this.removeCategoryTB); 
            this.m_TextBoxes.Add("removeColor",    this.removeColorTB);
            this.m_TextBoxes.Add("removeCourier",  this.removeCourierTB);
            this.m_TextBoxes.Add("removeDelivery", this.removeDeliveryTB);
            this.m_TextBoxes.Add("removePaint",    this.removePaintTB);
            this.m_TextBoxes.Add("removeWood",     this.removeWoodTB);
            this.m_TextBoxes.Add("removeClient",   this.removeClientTB);
        }

        private void LoadData()
        {
            foreach (KeyValuePair<String, String> item in this.m_GridQuery) 
            {
                var grid = SQL.GetTable(item.Value, this.m_Connection);
                if(grid == null)
                {
                    Console.WriteLine("Ooops!. Something went wrong! This is message from AdminPage.cs LoadData()");
                    return;
                }
                this.m_Grids[item.Key].DataSource = grid;
            }

            String addresses = String.Format("SELECT adress FROM unavailable_adreses");

            List<String> list = SQL.GetAll(addresses, this.m_Connection);

            if (list == null)
                return;

            this.courierCB.Items.Clear();

            this.courierCB.Items.AddRange(list.Cast<Object>().ToArray());
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            String buttonName = button.Name;
            buttonName = buttonName.Replace("Button", "");

            Console.WriteLine(buttonName);

            if (buttonName == "addCourier")
                this.m_Query[buttonName] = this.m_Query[buttonName].Replace("placeholder", this.courierCB.SelectedItem.ToString());

            SQL.ExecuteQuery(this.m_Query[buttonName] + this.m_TextBoxes[buttonName].Text.ToString() + "'", this.m_Connection);
            LoadData();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            String buttonName = button.Name;
            buttonName = buttonName.Replace("Button", "");

            SQL.ExecuteQuery(this.m_Query[buttonName] + this.m_TextBoxes[buttonName].Text.ToString(), this.m_Connection);
            LoadData();
        }
    }
}
