using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    internal class Product
    {
        private string name; 
        private double price;
        private int stock;

        public string GetName() { return name; }
        public double GetPrice() { return price; }
        public int GetStock() { return stock; }
        public virtual void SetParameters() 
        {
            this.SetProductParameters(); 
        }
        public virtual void ShowParameters()
        {
            this.ShowProductParameters();
        }
        public void SetProductParameters() 
        {
            Console.WriteLine("Podaj nazwe produktu: ");
            this.name = Console.ReadLine();
            Console.WriteLine("Podaj cene produktu: ");
            this.price= Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj zapas: ");
            this.stock = Convert.ToInt32(Console.ReadLine());
        }
        public void ShowProductParameters() 
        {
            ProductView.Show(this);
        }
    }

}
