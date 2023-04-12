using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace menu
{
    public partial class Manager : Form
    {
        public Manager()
        {
            InitializeComponent();
            tbManageLogin.Text = "Введіть логін";
            tbManageLogin.ForeColor = Color.Gray;
            

        }

        private void btnLoginManager_Click(object sender, EventArgs e)
        {
            string loginUser = tbManageLogin.Text;
            string passUser = tbManagerPassword.Text;
            

            DataBase db = new DataBase();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `manager` WHERE `Login` = @uL AND `Pass` = @uP ", db.getConnection());

            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passUser;
            

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                ////////////Написать шото
                this.Hide();
                new FormsForManager().Show();
            }
            else
            {
                MessageBox.Show("Не правильний логін або пароль");
            }
        }

        private void lbBack_MouseEnter(object sender, EventArgs e)
        {
            lbBack.ForeColor = Color.White;
        }

        private void lbBack_MouseLeave(object sender, EventArgs e)
        {
            lbBack.ForeColor = Color.Yellow;
        }

        private void lbBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            var formlogin = new FormLogin();
            formlogin.Show();
        }

       

        private void tbManageLogin_Leave(object sender, EventArgs e)
        {
            if(tbManageLogin.Text == "")
            {
                tbManageLogin.Text = "Введіть логін";
                tbManageLogin.ForeColor = Color.Gray;
            }
        }

        private void tbManageLogin_Enter(object sender, EventArgs e)
        {
            if (tbManageLogin.Text == "Введіть логін")
            {
                tbManageLogin.Text = "";
                tbManageLogin.ForeColor = Color.Black;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
