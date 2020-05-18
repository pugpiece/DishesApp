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
    public partial class ShopsAdd : Form
    {
        public ShopsAdd()
        {
            InitializeComponent();
        }

        private void ShopsAdd_Load(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            // Создаем и открываем соединение с MS SQL Server ...
            string strConn = "Data Source = USER-DNS\\SQLEXPRESS; Initial Catalog = Dishes; Integrated Security=True";
            SqlConnection Conn = new SqlConnection(@strConn);
            Conn.Open();

            // Заготовка Sql-предложения Insert ...
            string sInsSql = "Insert into Shops(SHOP_NAME, SHOP_DESCRIPTION, RATING) Values('{0}', '{1}', {2})";

            // Считываем данные с формы ...
            string SHOP_NAME = SHOP_NAME_Box.Text;
            string SHOP_DESCRIPTION = SHOP_DESCRIPTION_Box.Text;
            string RATING = RATING_Box.Text;

            // Формируем запрос на вставку данных с формы ...
            string sInsSotr = string.Format(sInsSql, SHOP_NAME, SHOP_DESCRIPTION, RATING);

            // Создаем команду ...
            SqlCommand cmdIns = new SqlCommand(sInsSotr, Conn);

            // Выполняем команду на вставку записи ..
            cmdIns.ExecuteNonQuery();

            // Выводим сообщение ...
            MessageBox.Show(string.Format("Запись {0} успешно вставлена !", SHOP_NAME), "Сообщение");
        }
    }
}
