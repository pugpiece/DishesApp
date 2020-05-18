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
    public partial class ProductsAdd : Form
    {
        public ProductsAdd()
        {
            InitializeComponent();
        }

        private void ProductsAdd_Load(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            // Создаем и открываем соединение с MS SQL Server ...
            string strConn = "Data Source = USER-DNS\\SQLEXPRESS; Initial Catalog = Dishes; Integrated Security=True";
            SqlConnection Conn = new SqlConnection(@strConn);
            Conn.Open();

            // Заготовка Sql-предложения Insert ...
            string sInsSql = "Insert into Products(PRODUCT_NAME, FATS_PER_GRAMM, PROTEINS_PER_GRAMM, CARBOHYDRATES_PER_GRAMM, CALORIES_PER_GRAMM, COST) Values('{0}', {1}, {2}, {3}, {4}, {5})";

            // Считываем данные с формы ...
            string PRODUCT_NAME = PRODUCT_NAME_Box.Text;
            string FATS_PER_GRAMM = FATS_PER_GRAMM_Box.Text;
            string PROTEINS_PER_GRAMM = PROTEINS_PER_GRAMM_Box.Text;
            string CARBOHYDRATES_PER_GRAMM = CARBOHYDRATES_PER_GRAMM_Box.Text;
            string CALORIES_PER_GRAMM = CALORIES_PER_GRAMM_Box.Text;
            string COST = COST_Box.Text;

            // Формируем запрос на вставку данных с формы ...
            string sInsSotr = string.Format(sInsSql, PRODUCT_NAME, FATS_PER_GRAMM, PROTEINS_PER_GRAMM, CARBOHYDRATES_PER_GRAMM, CALORIES_PER_GRAMM, COST);

            // Создаем команду ...
            SqlCommand cmdIns = new SqlCommand(sInsSotr, Conn);

            // Выполняем команду на вставку записи ..
            cmdIns.ExecuteNonQuery();

            // Выводим сообщение ...
            MessageBox.Show(string.Format("Запись {0} успешно вставлена !", PRODUCT_NAME), "Сообщение");
        }
    }
}
