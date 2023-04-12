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
    public partial class FormLogin : System.Windows.Forms.Form
    {
        public FormLogin()
        {
            InitializeComponent();

            this.tbPass.AutoSize = true;
            this.tbPass.Size = new Size(this.tbPass.Width, 90);


            tbLogin.Text = "Введіть своє ім'я";
            tbLogin.ForeColor = Color.Gray;
            tbNumber.Text = "Введіть номер";
            tbNumber.ForeColor = Color.Gray;

        }

        private void buttonLogin_MouseEnter(object sender, EventArgs e)
        {
            buttonLogin.ForeColor = Color.Red;
        }

        private void buttonLogin_MouseLeave(object sender, EventArgs e)
        {
            buttonLogin.ForeColor = Color.Black;
        }

       



        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string loginUser = tbLogin.Text;
            string passUser = tbPass.Text;
            string numUser = tbNumber.Text;

            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command  =new MySqlCommand("SELECT * FROM `userslogin` WHERE `login` = @uL AND `pass` = @uP AND `number` = @uN ",db.getConnection());

            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passUser;
            command.Parameters.Add("@uN", MySqlDbType.VarChar).Value = numUser;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if(table.Rows.Count > 0)
            {
                this.Hide();
                new Menu().Show();
            }
            else
            {
                MessageBox.Show("Не правильний логін або пароль");
            }
        }

        private void tbLogin_Enter(object sender, EventArgs e)
        {
            if(tbLogin.Text == "Введіть своє ім'я")
            {
                tbLogin.Text = "";
                tbLogin.ForeColor = Color.Black;
            }
        }

        private void tbLogin_Leave(object sender, EventArgs e)
        {
            if(tbLogin.Text == "")
            {
                tbLogin.Text = "Введіть своє ім'я";
                tbLogin.ForeColor = Color.Gray;
            }
        }

        private void tbNumber_Enter(object sender, EventArgs e)
        {
            if (tbNumber.Text == "Введіть номер")
            {
                tbNumber.Text = "";
                tbNumber.ForeColor = Color.Black;
            }

        }

        private void tbNumber_Leave(object sender, EventArgs e)
        {
            if(tbNumber.Text == "")
            {
                tbNumber.Text = "Введіть номер";
                tbNumber.ForeColor = Color.Gray;
            }
        }


        private void lbReg_MouseEnter(object sender, EventArgs e)
        {
            lbReg.ForeColor = Color.White;
        }

        private void lbReg_MouseLeave(object sender, EventArgs e)
        {
            lbReg.ForeColor = Color.Yellow;
        }

        private void lbReg_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            FromRegister registerForm = new FromRegister();
            registerForm.Show();
        }

        private void lbManager_Click(object sender, EventArgs e)
        {
            this.Hide();
            var managerForm = new Manager();
            managerForm.Show();
        }

        private void lbManager_MouseEnter(object sender, EventArgs e)
        {
            lbManager.ForeColor = Color.White;
        }

        private void lbManager_MouseLeave(object sender, EventArgs e)
        {
            lbManager.ForeColor =Color.Yellow;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbReg_Click(object sender, EventArgs e)
        {

        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            label2.ForeColor = Color.White;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.ForeColor = Color.Yellow;
        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {
            label3.ForeColor = Color.White;
           
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label3.ForeColor = Color.Yellow;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Menu().Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormsForManager().Show();
        }
    }
}
