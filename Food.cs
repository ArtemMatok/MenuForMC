using DocumentFormat.OpenXml.Spreadsheet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace menu
{
     public class Food
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public string Price2 { get; set; }
       public Food() { }
       
        public Food(string name, decimal price)
        {
            Name = name;
          
            Price = price;
           
            foods.Add(this);
        }
        static public List<Food> foods = new List<Food>();

        static public List<Food> orders = new List<Food>();
        

        static public List<string> AllOrders = new List<string>();

        public override string ToString()
        {
           
                return $"Назва:{Name} Price:{Price} грн.";
            
            
        }

        
        
      
    }
}
