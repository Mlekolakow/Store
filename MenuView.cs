using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    internal class MenuView
    {
        public static void ShowMainMenu()
        {
            Console.WriteLine("" +
                "\nWybierz operacje: " +
                "\n 1 - Katalog produktow " +
                "\n x - zamknij program");
        }
        public static void ShowCatalogMenu()
        {
            Console.WriteLine("\nWybierz operacje: " +
                "\n 1 - Wyświetl wszystkie kategorie " +
                "\n 2 - Wyświetl kategorie " +
                "\n 3 - Dodaj kategorie " +
                "\n 4 - Dodaj Produkt " +
                "\n 5 - Usun Produkt " +
                "\n 6 - Usun Kategorie " +
                "\n x - Menu główne");
        }
    }
}
