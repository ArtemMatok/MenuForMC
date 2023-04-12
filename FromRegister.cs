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
    public partial class FromRegister : System.Windows.Forms.Form
    {
        public FromRegister()
        {
            InitializeComponent();

            tbLoginR.Text = "Введіть своє ім'я";
            tbLoginR.ForeColor = Color.Gray;
            tbNumberR.Text = "Введіть номер";
            tbNumberR.ForeColor = Color.Gray;
        }

        private void FromRegister_Load(object sender, EventArgs e)
        {

        }


        public bool checkNumber()
        {
            var tx = tbNumberR.Text;

            if (tx[0] == '+')
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
           
             var tx = tbNumberR.Text;
           if(tbLoginR.Text == "Введіть ім'я")
            {
                MessageBox.Show("Введіть ім'я");
            }
           //if(tbNumberR.Text == "Введіть номер")
           // {
           //     MessageBox.Show("Введіть номер");
           // }
            if (tx[0] !='+')
            {
                MessageBox.Show("Введіть номер");
            }

            if (checkUsers())
            {
                return;
            }

            DB db = new DB();
            MySqlCommand command = new MySqlCommand($"INSERT INTO `userslogin`(`login`, `pass`, `number`) VALUES ('{tbLoginR.Text}','{tbPassR.Text}','{tbNumberR.Text}')", db.getConnection()); 


            db.openConnection();

            if(command.ExecuteNonQuery() == 1 && checkNumber()==true)
            {
                MessageBox.Show("Акаунт був створений");
                this.Hide();
                FormLogin fLogin = new FormLogin();
                fLogin.Show();
            }
            else
            {
                MessageBox.Show("Помилка");
            }

            db.closeConnection();
        }


        public bool checkUsers()
        {
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `userslogin` WHERE `login` = @uL ", db.getConnection());

            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = tbLoginR.Text;


            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Такий логін вже є");
                return true;
            }
            else
            {
                return false;
            }
        }



        
        private void tbLoginR_Enter(object sender, EventArgs e)
        {
            if (tbLoginR.Text == "Введіть своє ім'я")
            {
                tbLoginR.Text = "";
                tbLoginR.ForeColor = Color.Black;
              
            }
        }

        private void tbLoginR_Leave(object sender, EventArgs e)
        {
            if(tbLoginR.Text == "")
            {
                tbLoginR.Text = "Введіть своє ім'я";
                tbLoginR.ForeColor = Color.Gray;
            }
        }

        private void tbNumberR_Enter(object sender, EventArgs e)
        {
            if(tbNumberR.Text == "Введіть номер")
            {
                tbNumberR.Text = "";
                tbNumberR.ForeColor = Color.Black;
            }
        }

        private void tbNumberR_Leave(object sender, EventArgs e)
        {
            if(tbNumberR.Text =="")
            {
                tbNumberR.Text = "Введіть номер";
                tbNumberR.ForeColor = Color.Gray;
            }
        }

        private void btnRegister_MouseEnter(object sender, EventArgs e)
        {
            btnRegister.ForeColor = Color.Red;
        }

        private void btnRegister_MouseLeave(object sender, EventArgs e)
        {
            btnRegister.ForeColor = Color.Black;
        }
    }
}
