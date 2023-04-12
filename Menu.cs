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
   
    public partial class Menu : Form
    {
        public Menu()
        {
         
            InitializeComponent();
            
        }

        static public int counter = 0;
        private void Menu_Load(object sender, EventArgs e)
        {
           if(counter==0)
            {
                Food gamburger = new Food("Гамбургер", 123);
                Food cheesburger = new Food("Чізбургер", 100);
                Food ice = new Food("МакФлурі", 40);
                lbMenu.DataSource = Food.foods;
                counter++;
            }
            else
            {
                lbMenu.DataSource = Food.foods;
            }
          
            
        }

        static public decimal sum = 0;
        
        private void btnAddToOrder_Click(object sender, EventArgs e)
        {
            sum+= ((Food)lbMenu.SelectedItem).Price;
          
            Food.orders.Add((Food)lbMenu.SelectedItem);
           
           
        }

        private void btnAddToOrder_MouseEnter(object sender, EventArgs e)
        {
            btnAddToOrder.ForeColor = Color.DarkSlateGray;
        }

        private void btnAddToOrder_MouseLeave(object sender, EventArgs e)
        {
            btnAddToOrder.ForeColor = Color.Black;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
            new OrderForm(sum).ShowDialog();
            sum = 0;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormLogin().Show();
        }

        private void btnExit_MouseEnter(object sender, EventArgs e)
        {
            btnExit.ForeColor = Color.DarkSlateGray;
        }

        private void btnExit_MouseLeave(object sender, EventArgs e)
        {
            btnExit.ForeColor = Color.Black;
        }
    }
}
