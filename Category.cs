using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    internal class Category
    {
        private string name;
        List<Product> products = new List<Product>();

        public Category(string name)
        {
            this.name = name;
        }
        public string getName()
        {
            return name;
        }
        public int getProductCount()
        {
            return products.Count;
        }
        public virtual void SetParameters() 
        {
            this.SetCategoryParameters(); 
        }
        public virtual void ShowParameters()
        {
            this.ShowCategoryParameters();
        }
        public void SetCategoryParameters() 
        {
            Console.WriteLine("Podaj nazwe kategorii: ");
            this.name = Console.ReadLine();
        }
        public void ShowCategoryParameters()
        {
            CategoryView.Show(this);
        }
        public void ShowProduct(int product_id)
        {
            this.products[product_id].ShowParameters();

        }
        public void AddProduct(Product item)
        {
            this.products.Add(item);
        }
        public void RemoveProduct(int product_id)
        {
            if (product_id >= 0 && product_id < this.products.Count)
            {
                string tmp_name = this.products[product_id].GetName();
                this.products.RemoveAt(product_id);
                Console.WriteLine("\n Produkt ' " + tmp_name + " ' zostal usuniety");
            }
            Console.WriteLine("\n Produkt nie istnieje!");
        }
    }
}
