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
    public partial class ViewOrder : Form
    {
        public ViewOrder()
        {
            InitializeComponent();
            
        }

        private void ViewOrder_Load(object sender, EventArgs e)
        {
            lbOrder.DataSource = Food.AllOrders; 
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            new ViewFoods().ShowDialog();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormLogin().Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
