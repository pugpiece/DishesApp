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

namespace DishesApp.TablesAddForms
{
    public partial class SeeTables : Form
    {

        public SeeTables()
        {
            InitializeComponent();
            string[] tables = { "Products", "Dishes", "Instruments", "Shops", "Dish_Types", "Countries", "Reviews", "Customers", "Inst_To_Shop", "Prod_To_Shop", "Inst_To_Dish", "Prod_To_Dish" };
            TablesList.Items.AddRange(tables);
        }

        private void SeeTables_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strConn = "Data Source = USER-DNS\\SQLEXPRESS; Initial Catalog = Dishes; Integrated Security=True";
            SqlConnection Conn = new SqlConnection(@strConn);
            Conn.Open();

            string table = Convert.ToString(TablesList.Items[TablesList.SelectedIndex]);
            SqlDataAdapter da;

            if (TablesList.SelectedIndex == 0)
            {
                if (DishesApp.Globals.isAdmin == true)
                    da = new SqlDataAdapter("SELECT * FROM " + table, strConn);
                else
                    da = new SqlDataAdapter("SELECT PRODUCT_NAME, FATS_PER_GRAMM, PROTEINS_PER_GRAMM, CARBOHYDRATES_PER_GRAMM, CALORIES_PER_GRAMM FROM " + table, strConn);
            }
            else if (TablesList.SelectedIndex == 1)
            {
                if (DishesApp.Globals.isAdmin == true)
                    da = new SqlDataAdapter("SELECT * FROM " + table, strConn);
                else
                    da = new SqlDataAdapter("SELECT DISH_NAME, RECIPE, DTYPE_NAME FROM Dishes INNER JOIN Dish_Types ON Dishes.ID_DISH_TYPE = Dish_Types.ID", strConn);
            }
            else if (TablesList.SelectedIndex == 2)
            {
                if (DishesApp.Globals.isAdmin == true)
                    da = new SqlDataAdapter("SELECT * FROM " + table, strConn);
                else
                    da = new SqlDataAdapter("SELECT INSTRUMENT_NAME, INSTRUMENT_DESCRIPTION FROM " + table, strConn);
            }
            else if (TablesList.SelectedIndex == 3)
            {
                if (DishesApp.Globals.isAdmin == true)
                    da = new SqlDataAdapter("SELECT * FROM " + table, strConn);
                else
                    da = new SqlDataAdapter("SELECT SHOP_NAME, SHOP_DESCRIPTION, RATING FROM " + table, strConn);
            }
            else if (TablesList.SelectedIndex == 4)
            {
                if (DishesApp.Globals.isAdmin == true)
                    da = new SqlDataAdapter("SELECT * FROM " + table, strConn);
                else
                    da = new SqlDataAdapter("SELECT DTYPE_NAME, DTYPE_DESCRIPTION FROM " + table, strConn);
            }
            else if (TablesList.SelectedIndex == 5)
            {
                if (DishesApp.Globals.isAdmin == true)
                    da = new SqlDataAdapter("SELECT * FROM " + table, strConn);
                else
                    da = new SqlDataAdapter("SELECT COUNTRY_NAME, COUNTRY_DESCRIPTION FROM " + table, strConn);
            }
            else if (TablesList.SelectedIndex == 6)
            {
                if (DishesApp.Globals.isAdmin == true)
                    da = new SqlDataAdapter("SELECT * FROM " + table, strConn);
                else
                    da = new SqlDataAdapter("SELECT  DISH_NAME, RATING, PLUSES, MINUSES, OVERVIEW, PUBLISH_DATE FROM Reviews INNER JOIN Dishes ON Reviews.ID_DISH = Dishes.ID", strConn);
            }
            else if (TablesList.SelectedIndex == 7)
            {
                if (DishesApp.Globals.isAdmin == true)
                    da = new SqlDataAdapter("SELECT * FROM " + table, strConn);
                else
                    da = new SqlDataAdapter("SELECT CUSTOMER_LOGIN, RATING FROM " + table, strConn);
            }
            else if (TablesList.SelectedIndex == 8)
            {
                if (DishesApp.Globals.isAdmin == true)
                    da = new SqlDataAdapter("SELECT * FROM " + table, strConn);
                else
                    da = new SqlDataAdapter("SELECT * FROM " + table, strConn);
            }
            else if (TablesList.SelectedIndex == 9)
            {
                if (DishesApp.Globals.isAdmin == true)
                    da = new SqlDataAdapter("SELECT * FROM " + table, strConn);
                else
                    da = new SqlDataAdapter("SELECT * FROM " + table, strConn);
            }
            else if (TablesList.SelectedIndex == 10)
            {
                if (DishesApp.Globals.isAdmin == true)
                    da = new SqlDataAdapter("SELECT * FROM " + table, strConn);
                else
                    da = new SqlDataAdapter("SELECT * FROM " + table, strConn);
            }
            else
            {
                if (DishesApp.Globals.isAdmin == true)
                    da = new SqlDataAdapter("SELECT * FROM " + table, strConn);
                else
                    da = new SqlDataAdapter("SELECT * FROM " + table, strConn);
            }

            DataSet ds = new DataSet();
            da.Fill(ds, table);

            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = table;

            Conn.Close();
        }
    }
}
