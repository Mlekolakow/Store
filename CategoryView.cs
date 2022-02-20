using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    internal class CategoryView
    {
        public static void Show(Category item)
        {

            Console.WriteLine(" Parametry kategorii: ");
            Console.WriteLine(" -> nazwa: " + item.getName());
            Console.WriteLine(" -> produkty: ");
            for (int i = 0; i < item.getProductCount(); i++)
            {
                Console.WriteLine("#Produkt nr " + (i + 1));
                item.ShowProduct(i);
            }
        }
    }
}
