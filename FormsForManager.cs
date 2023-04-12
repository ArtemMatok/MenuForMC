using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace menu
{
    public partial class FormsForManager : Form
    {
        public FormsForManager()
        {
            InitializeComponent();
        }

        private void btnAddToMenu_MouseEnter(object sender, EventArgs e)
        {
            btnAddToMenu.ForeColor = Color.DarkSlateGray;
        }

        private void btnAddToMenu_MouseLeave(object sender, EventArgs e)
        {
            btnAddToMenu.ForeColor = Color.Black;

        }

        private void btnDeleteFromMenu_MouseEnter(object sender, EventArgs e)
        {
            btnDeleteFromMenu.ForeColor = Color.DarkSlateGray;
        }

        private void btnDeleteFromMenu_MouseLeave(object sender, EventArgs e)
        {
            btnDeleteFromMenu.ForeColor = Color.Black;
        }

        private void btnViewMenu_MouseEnter(object sender, EventArgs e)
        {
            btnViewMenu.ForeColor = Color.DarkSlateGray;
        }

        private void btnViewMenu_MouseLeave(object sender, EventArgs e)
        {
            btnViewMenu.ForeColor = Color.Black;
        }

        private void FormsForManager_Load(object sender, EventArgs e)
        {
            lbMenuManager.DataSource = Food.foods;
        }

        private void btnAddToMenu_Click(object sender, EventArgs e)
        {
            new CreaterFood(null).ShowDialog();
            Refreshing();
        }

        private void Refreshing()
        {
            lbMenuManager.DataSource = null;
            lbMenuManager.DataSource = Food.foods;
        }

        private void btnChangeInMenu_Click(object sender, EventArgs e)
        {
            new CreaterFood((Food)lbMenuManager.SelectedItem).ShowDialog();
            Refreshing();
        }

        private void btnDeleteFromMenu_Click(object sender, EventArgs e)
        {
            Food.foods.Remove((Food)lbMenuManager.SelectedItem);
            Refreshing();
        }

        private void btnViewMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ViewOrder().Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormLogin().Show();
        }
    }
}
