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
    public partial class MainPageUser : Form
    {
        public MainPageUser()
        {
            InitializeComponent();
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
