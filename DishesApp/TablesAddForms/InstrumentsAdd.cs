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
    public partial class InstrumentsAdd : Form
    {
        public InstrumentsAdd()
        {
            InitializeComponent();
        }

        private void InstrumentsAdd_Load(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            // Создаем и открываем соединение с MS SQL Server ...
            string strConn = "Data Source = USER-DNS\\SQLEXPRESS; Initial Catalog = Dishes; Integrated Security=True";
            SqlConnection Conn = new SqlConnection(@strConn);
            Conn.Open();

            // Заготовка Sql-предложения Insert ...
            string sInsSql = "Insert into Instruments(INSTRUMENT_NAME, INSTRUMENT_DESCRIPTION, PRICE) Values('{0}', '{1}', {2})";

            // Считываем данные с формы ...
            string INSTRUMENT_NAME = INSTRUMENT_NAME_Box.Text;
            string INSTRUMENT_DESCRIPTION = INSTRUMENT_DESCRIPTION_Box.Text;
            string PRICE = PRICE_Box.Text;

            // Формируем запрос на вставку данных с формы ...
            string sInsSotr = string.Format(sInsSql, INSTRUMENT_NAME, INSTRUMENT_DESCRIPTION, PRICE);

            // Создаем команду ...
            SqlCommand cmdIns = new SqlCommand(sInsSotr, Conn);

            // Выполняем команду на вставку записи ..
            cmdIns.ExecuteNonQuery();

            // Выводим сообщение ...
            MessageBox.Show(string.Format("Запись {0} успешно вставлена !", INSTRUMENT_NAME), "Сообщение");
        }
    }
}
