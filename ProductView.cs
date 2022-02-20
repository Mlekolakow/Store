using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    internal class ProductView
    {
        public static void Show(Product item) {

            Console.WriteLine(" Parametry produktu: ");
            Console.WriteLine(" -> nazwa: " + item.GetName());
            Console.WriteLine(" -> cena: " + item.GetPrice());
            Console.WriteLine(" -> zapas: " + item.GetStock());
        }
    }
}
