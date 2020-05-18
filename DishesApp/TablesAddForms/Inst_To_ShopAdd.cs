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
    public partial class Inst_To_ShopAdd : Form
    {
        public Inst_To_ShopAdd()
        {
            InitializeComponent();
        }

        private void Inst_To_ShopAdd_Load(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            // Создаем и открываем соединение с MS SQL Server ...
            string strConn = "Data Source = USER-DNS\\SQLEXPRESS; Initial Catalog = Dishes; Integrated Security=True";
            SqlConnection Conn = new SqlConnection(@strConn);
            Conn.Open();

            // Заготовка Sql-предложения Insert ...
            string sInsSql = "Insert into Inst_To_Shop(ID_INSTRUMENT, ID_SHOP) Values({0}, {1})";

            // Считываем данные с формы ...
            int ID_INSTRUMENT = Convert.ToInt32(ID_INSTRUMENT_Box.Text);
            int ID_SHOP = Convert.ToInt32(ID_SHOP_Box.Text);

            // Формируем запрос на вставку данных с формы ...
            string sInsSotr = string.Format(sInsSql, ID_INSTRUMENT, ID_SHOP);

            // Создаем команду ...
            SqlCommand cmdIns = new SqlCommand(sInsSotr, Conn);

            // Выполняем команду на вставку записи ..
            cmdIns.ExecuteNonQuery();

            // Выводим сообщение ...
            MessageBox.Show(string.Format("Запись {0} - {1} успешно вставлена !", ID_INSTRUMENT, ID_SHOP), "Сообщение");
        }
    }
}
