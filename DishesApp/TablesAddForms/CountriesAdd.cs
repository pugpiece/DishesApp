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
    public partial class CountriesAdd : Form
    {
        public CountriesAdd()
        {
            InitializeComponent();
        }

        private void CountriesAdd_Load(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            // Создаем и открываем соединение с MS SQL Server ...
            string strConn = "Data Source = USER-DNS\\SQLEXPRESS; Initial Catalog = Dishes; Integrated Security=True";
            SqlConnection Conn = new SqlConnection(@strConn);
            Conn.Open();

            // Заготовка Sql-предложения Insert ...
            string sInsSql = "Insert into Countries(COUNTRY_NAME, COUNTRY_DESCRIPTION) Values('{0}', '{1}')";

            // Считываем данные с формы ...
            string COUNTRY_NAME = COUNTRY_NAME_Box.Text;
            string COUNTRY_DESCRIPTION = COUNTRY_NAME_Box.Text;

            // Формируем запрос на вставку данных с формы ...
            string sInsSotr = string.Format(sInsSql, COUNTRY_NAME, COUNTRY_DESCRIPTION);

            // Создаем команду ...
            SqlCommand cmdIns = new SqlCommand(sInsSotr, Conn);

            // Выполняем команду на вставку записи ..
            cmdIns.ExecuteNonQuery();

            // Выводим сообщение ...
            MessageBox.Show(string.Format("Запись {0} успешно вставлена !", COUNTRY_NAME), "Сообщение");

        }
    }
    }
