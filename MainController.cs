using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    internal class MainController
    {
        public static bool Menu()
        {
            MenuView.ShowMainMenu();
            string wybor = Console.ReadLine(); 
            Console.WriteLine("Twoj wybor to " + wybor + "\n");

            Console.Clear();

            switch (wybor) 
            {
                case "1":
                    CatalogController.Menu();
                    break;
                case "x": //finish
                    return true;
                default:
                    Console.WriteLine("Podana komenda nie istnieje.");
                    break;
            }
            return false;

        }

    }
}
