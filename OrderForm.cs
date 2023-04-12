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
    public partial class OrderForm : Form
    {
        public OrderForm(decimal sum)
        {
            InitializeComponent();
            res = sum;
          
        }
       static decimal res = 0;
        private void OrderForm_Load(object sender, EventArgs e)
        {
            lbOrder.DataSource = Food.orders;

            lbRes.Text = res.ToString()+" грн.";
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            res -= ((Food)lbOrder.SelectedItem).Price;
            Food.orders.Remove((Food)lbOrder.SelectedItem);
            lbOrder.DataSource = null;
            lbOrder.DataSource = Food.orders;
            
            lbRes.Text = res.ToString()+" грн";

            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        static int k = 1;
        private void btnTakeOrder_Click(object sender, EventArgs e)
        {
            if(res==0)
            {
                
                MessageBox.Show("Ви нічого не замовили");
                
            }
            else
            {
                MessageBox.Show("Ваше замовлення прийняте! До сплати:" + res + "грн");
                Food.AllOrders.Add($"Замовлення #{k}");
                lbOrder.DataSource = null;
                res = res - res;
                lbRes.Text = res.ToString() + " грн";
                k++;
                
            }
            
        }

        private void btnCancel_MouseEnter(object sender, EventArgs e)
        {
            btnCancel.ForeColor = Color.DarkSlateGray;
        }

        private void btnCancel_MouseLeave(object sender, EventArgs e)
        {
            btnCancel.ForeColor = Color.Black;
        }

        private void btnTakeOrder_MouseEnter(object sender, EventArgs e)
        {
            btnTakeOrder.ForeColor = Color.DarkSlateGray;
        }

        private void btnTakeOrder_MouseLeave(object sender, EventArgs e)
        {
            btnTakeOrder.ForeColor= Color.Black;
        }

        private void lbRes_Click(object sender, EventArgs e)
        {

        }
    }
}
