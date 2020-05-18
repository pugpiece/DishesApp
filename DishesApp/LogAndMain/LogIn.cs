using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DishesApp
{
    public partial class LogIn : Form
    {

        public LogIn()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void PasswordBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            if (LoginBox.Text == "admin" && PasswordBox.Text == "admin")
            {
                DishesApp.Globals.isAdmin = true;
                MainPageAdmin f = new MainPageAdmin();
                f.Show();
                this.Hide();
            }
            else if (LoginBox.Text == "user" && PasswordBox.Text == "user")
            {
                DishesApp.Globals.isAdmin = false;
                MainPageUser f = new MainPageUser();
                f.Show();
                this.Hide();
            }
        }
    }
}
