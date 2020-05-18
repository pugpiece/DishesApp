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
    public partial class DishesAdd : Form
    {
        public DishesAdd()
        {
            InitializeComponent();
        }

        private void DishesAdd_Load(object sender, EventArgs e)
        {

        }

        private void CUSTOMER_LOGIN_Click(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            // Создаем и открываем соединение с MS SQL Server ...
            string strConn = "Data Source = USER-DNS\\SQLEXPRESS; Initial Catalog = Dishes; Integrated Security=True";
            SqlConnection Conn = new SqlConnection(@strConn);
            Conn.Open();

            // Заготовка Sql-предложения Insert ...
            string sInsSql = "Insert into Dishes(DISH_NAME, RECIPE, ID_DISH_TYPE, ID_COUNTRY) Values('{0}', '{1}', {2}, {3})";

            // Считываем данные с формы ...
            string DISH_NAME = DISH_NAME_Box.Text;
            string RECIPE = RECIPE_Box.Text;
            int ID_DISH_TYPE = Convert.ToInt32(ID_DISH_TYPE_Box.Text);
            int ID_COUNTRY = Convert.ToInt32(ID_COUNTRY_Box.Text);

            // Формируем запрос на вставку данных с формы ...
            string sInsSotr = string.Format(sInsSql, DISH_NAME, RECIPE, ID_DISH_TYPE, ID_COUNTRY);

            // Создаем команду ...
            SqlCommand cmdIns = new SqlCommand(sInsSotr, Conn);

            // Выполняем команду на вставку записи ..
            cmdIns.ExecuteNonQuery();

            // Выводим сообщение ...
            MessageBox.Show(string.Format("Запись {0} успешно вставлена !", DISH_NAME), "Сообщение");
        }
    }
}
