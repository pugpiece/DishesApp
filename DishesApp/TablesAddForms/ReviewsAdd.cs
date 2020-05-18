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
    public partial class ReviewsAdd : Form
    {
        public ReviewsAdd()
        {
            InitializeComponent();
        }

        private void ReviewsAdd_Load(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            // Создаем и открываем соединение с MS SQL Server ...
            string strConn = "Data Source = USER-DNS\\SQLEXPRESS; Initial Catalog = Dishes; Integrated Security=True";
            SqlConnection Conn = new SqlConnection(@strConn);
            Conn.Open();

            // Заготовка Sql-предложения Insert ...
            string sInsSql = "Insert into Reviews(ID_CUSTOMER, ID_DISH, RATING, PLUSES, MINUSES, OVERVIEW, PUBLISH_DATE) Values({0}, {1}, {2}, '{3}', '{4}', '{5}', '{6}')";

            // Считываем данные с формы ...
            string ID_CUSTOMER = ID_CUSTOMER_Box.Text;
            string ID_DISH = ID_DISH_Box.Text;
            string RATING = RATING_Box.Text;
            string PLUSES = PLUSES_Box.Text;
            string MINUSES = MINUSES_Box.Text;
            string OVERVIEW = OVERVIEW_Box.Text;
            string PUBLISH_DATE = PUBLISH_DATE_Box.Text;

            // Формируем запрос на вставку данных с формы ...
            string sInsSotr = string.Format(sInsSql, ID_CUSTOMER, ID_DISH, RATING, PLUSES, MINUSES, OVERVIEW, PUBLISH_DATE);

            // Создаем команду ...
            SqlCommand cmdIns = new SqlCommand(sInsSotr, Conn);

            // Выполняем команду на вставку записи ..
            cmdIns.ExecuteNonQuery();

            // Выводим сообщение ...
            MessageBox.Show(string.Format("Запись {0} - {1} успешно вставлена !", ID_CUSTOMER, ID_DISH), "Сообщение");
        }
    }
}
