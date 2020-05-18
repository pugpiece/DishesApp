using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;


namespace DishesApp
{
    public partial class MainPageAdmin : Form
    {

        public MainPageAdmin()
        {
            InitializeComponent();
            string[] tables = { "Products", "Dishes", "Instruments", "Shops", "DishTypes", "Countries", "Reviews", "Customers", "Inst_To_Shop", "Prod_To_Shop", "Inst_To_Dish", "Prod_To_Dish","Inst_No_Description"};
            TablesList.Items.AddRange(tables);
        }

        private void TablesList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void GoChangeButton_Click(object sender, EventArgs e)
        {
            if (TablesList.SelectedIndex == 0)
            {
                DishesApp.TablesAddForms.ProductsAdd f = new DishesApp.TablesAddForms.ProductsAdd();
                f.Show();
            }
            else if (TablesList.SelectedIndex == 1)
            {
                DishesApp.TablesAddForms.DishesAdd f = new DishesApp.TablesAddForms.DishesAdd();
                f.Show();
            }
            else if (TablesList.SelectedIndex == 2)
            {
                DishesApp.TablesAddForms.InstrumentsAdd f = new DishesApp.TablesAddForms.InstrumentsAdd();
                f.Show();
            }
            else if (TablesList.SelectedIndex == 3)
            {
                DishesApp.TablesAddForms.ShopsAdd f = new DishesApp.TablesAddForms.ShopsAdd();
                f.Show();
            }
            else if (TablesList.SelectedIndex == 4)
            {
                DishesApp.TablesAddForms.DishTypesAdd f = new DishesApp.TablesAddForms.DishTypesAdd();
                f.Show();
            }
            else if (TablesList.SelectedIndex == 5)
            {
                DishesApp.TablesAddForms.CountriesAdd f = new DishesApp.TablesAddForms.CountriesAdd();
                f.Show();
            }
            else if (TablesList.SelectedIndex == 6)
            {
                DishesApp.TablesAddForms.ReviewsAdd f = new DishesApp.TablesAddForms.ReviewsAdd();
                f.Show();
            }
            else if (TablesList.SelectedIndex == 7)
            {
                DishesApp.TablesAddForms.CustomersAdd f = new DishesApp.TablesAddForms.CustomersAdd();
                f.Show();
            }
            else if (TablesList.SelectedIndex == 8)
            {
                DishesApp.TablesAddForms.Inst_To_ShopAdd f = new DishesApp.TablesAddForms.Inst_To_ShopAdd();
                f.Show();
            }
            else if (TablesList.SelectedIndex == 9)
            {
                DishesApp.TablesAddForms.Prod_To_ShopAdd f = new DishesApp.TablesAddForms.Prod_To_ShopAdd();
                f.Show();
            }
            else if (TablesList.SelectedIndex == 10)
            {
                DishesApp.TablesAddForms.Inst_To_DishAdd f = new DishesApp.TablesAddForms.Inst_To_DishAdd();
                f.Show();
            }
            else if (TablesList.SelectedIndex == 11)
            {
                DishesApp.TablesAddForms.Prod_To_DishAdd f = new DishesApp.TablesAddForms.Prod_To_DishAdd();
                f.Show();
            }
            else if (TablesList.SelectedIndex == 12)
            {
                DishesApp.TablesAddForms.Inst_No_DescAdd f = new DishesApp.TablesAddForms.Inst_No_DescAdd();
                f.Show();
            }
        }

        private void MainPageAdmin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DishesApp.TablesAddForms.SeeTables f = new DishesApp.TablesAddForms.SeeTables();
            f.Show();
        }

        private void ProdShowButton_Click(object sender, EventArgs e)
        {
            string strConn = "Data Source = USER-DNS\\SQLEXPRESS; Initial Catalog = Dishes; Integrated Security=True";
            SqlConnection Conn = new SqlConnection(@strConn);
            Conn.Open();
            SqlDataAdapter da;

            string table = "Products";
            string fatsmin = fats_min.Text;
            string fatsmax = fats_max.Text;
            string protmin = prot_min.Text;
            string protmax = prot_max.Text;
            string carbsmin = carbs_min.Text;
            string carbsmax = carbs_max.Text;
            string callmin = call_min.Text;
            string callmax = call_max.Text;
            string pricemin = cost_min.Text;
            string pricemax = cost_max.Text;

            string sInsSql = "EXEC GET_PRODUCTS {0},{1},{2},{3},{4},{5},{6},{7},{8},{9}";
            string sInsSotr = string.Format(sInsSql, fatsmin, fatsmax, protmin, protmax, carbsmin, carbsmax, callmin, callmax, pricemin, pricemax);
            da = new SqlDataAdapter(sInsSotr, strConn);

            DataSet ds = new DataSet();
            da.Fill(ds, table);

            ProductShow.DataSource = ds;
            ProductShow.DataMember = table;

            Conn.Close();
        }

        private void ShowRecipeButton_Click(object sender, EventArgs e)
        {

            string strConn = "Data Source = USER-DNS\\SQLEXPRESS; Initial Catalog = Dishes; Integrated Security=True";
            SqlConnection Conn = new SqlConnection(@strConn);
            Conn.Open();
            SqlDataAdapter da;

            da = new SqlDataAdapter("EXEC GET_REVIEWS " + dishNumber.Text, strConn);

            DataSet ds = new DataSet();
            da.Fill(ds, "Products");

            ShowRecipe.DataSource = ds;
            ShowRecipe.DataMember = "Products";

            Conn.Close();
        }
    }
}
