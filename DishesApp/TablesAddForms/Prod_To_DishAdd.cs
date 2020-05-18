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
    public partial class Prod_To_DishAdd : Form
    {
        public Prod_To_DishAdd()
        {
            InitializeComponent();
        }

        private void Prod_To_Dish_Load(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            // Создаем и открываем соединение с MS SQL Server ...
            string strConn = "Data Source = USER-DNS\\SQLEXPRESS; Initial Catalog = Dishes; Integrated Security=True";
            SqlConnection Conn = new SqlConnection(@strConn);
            Conn.Open();

            // Заготовка Sql-предложения Insert ...
            string sInsSql = "Insert into Prod_To_Dish(ID_PRODUCT, ID_DISH) Values({0}, {1})";

            // Считываем данные с формы ...
            int ID_INSTRUMENT = Convert.ToInt32(ID_PRODUCT_Box.Text);
            int ID_DISH = Convert.ToInt32(ID_DISH_Box.Text);

            // Формируем запрос на вставку данных с формы ...
            string sInsSotr = string.Format(sInsSql, ID_INSTRUMENT, ID_DISH);

            // Создаем команду ...
            SqlCommand cmdIns = new SqlCommand(sInsSotr, Conn);

            // Выполняем команду на вставку записи ..
            cmdIns.ExecuteNonQuery();

            // Выводим сообщение ...
            MessageBox.Show(string.Format("Запись {0} - {1} успешно вставлена !", ID_INSTRUMENT, ID_DISH), "Сообщение");
        }
    }
}
