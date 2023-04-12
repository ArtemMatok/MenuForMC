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
    public partial class CreaterFood : Form
    {
        private Food _food;
        public CreaterFood(Food food)
        {
            InitializeComponent();
           if(food == null)
            {
                food = new Food();
            }
            else
            {
                tbName.Text = food.Name;
            }
           _food = food;
        }

        private void CreaterFood_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
          Random random = new Random();
          
            var Name= tbName.Text;
            decimal Price = random.Next(50,100);
           
                    new Food(Name, Price);
                    this.Close();
                
         
            
        }

       
    }
}
