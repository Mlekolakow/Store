using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    internal class CatalogController
    {
        public static void Menu()
        {
            MenuView.ShowCatalogMenu();
            string wybor = Console.ReadLine();
            Console.WriteLine("Twoj wybor to " + wybor + "\n");

            Console.Clear();
            string category_name;
            switch (wybor)
            {
                case "1":
                    Console.WriteLine("\nLista kategorii: ");
                    CatalogModel.ShowAll();
                    break;
                case "2":

                    Console.WriteLine("\nPodaj nazwę kategorii do wyświetlenia: ");
                    category_name = Console.ReadLine();
                    CatalogModel.ShowCategory(category_name);

                    break;
                case "3":

                    Console.WriteLine("\nPodaj nazwę nowej kategorii: ");
                    category_name = Console.ReadLine();
                    CatalogModel.AddCategory(category_name);
                    Console.WriteLine("\nKategoria ' " + category_name + " ' została utworzona");

                    break;
                case "4":

                    Console.WriteLine("\nPodaj nazwę kategorii do której chcesz dodać produkt: ");
                    category_name = Console.ReadLine();
                    CatalogModel.AddProduct(category_name);

                    break;
                case "5":

                    Console.WriteLine("\nPodaj nazwę kategorii z której chcesz usunąć produkt: ");
                    category_name = Console.ReadLine();
                    Console.WriteLine("\nPodaj indeks produktu: ");
                    int product_id = Convert.ToInt32(Console.ReadLine());
                    CatalogModel.RemoveProduct(category_name, product_id);

                    break;
                case "6":

                    Console.WriteLine("\nPodaj nazwę kategorii którą chcesz usunąć ( wraz z wszystkimi produktami ): ");
                    category_name = Console.ReadLine();
                    CatalogModel.RemoveCategory(category_name);

                    break;
                case "x": //finish
                    return;
                default:
                    Console.WriteLine("Podana komenda nie istnieje.");
                    break;
            }
        }
    }
}
