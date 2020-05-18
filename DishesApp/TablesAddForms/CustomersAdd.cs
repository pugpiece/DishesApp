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
    public partial class CustomersAdd : Form
    {
        public CustomersAdd()
        {
            InitializeComponent();
        }

        private void CustomersAdd_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            // Создаем и открываем соединение с MS SQL Server ...
            string strConn = "Data Source = USER-DNS\\SQLEXPRESS; Initial Catalog = Dishes; Integrated Security=True";
            SqlConnection Conn = new SqlConnection(@strConn);
            Conn.Open();

            // Заготовка Sql-предложения Insert ...
            string sInsSql = "Insert into Customers(CUSTOMER_LOGIN, CUSTOMER_PASSWORD, RATING) Values('{0}', '{1}', {2})";

            // Считываем данные с формы ...
            string CUSTOMER_LOGIN = CUSTOMER_LOGIN_Box.Text;
            string CUSTOMER_PASSWORD = CUSTOMER_PASSWORD_Box.Text;
            string RATING = RATING_Box.Text;

            // Формируем запрос на вставку данных с формы ...
            string sInsSotr = string.Format(sInsSql, CUSTOMER_LOGIN, CUSTOMER_PASSWORD, RATING);

            // Создаем команду ...
            SqlCommand cmdIns = new SqlCommand(sInsSotr, Conn);

            // Выполняем команду на вставку записи ..
            cmdIns.ExecuteNonQuery();

            // Выводим сообщение ...
            MessageBox.Show(string.Format("Запись {0} успешно вставлена !", CUSTOMER_LOGIN), "Сообщение");
        }
    }
}
