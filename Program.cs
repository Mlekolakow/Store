using System;

namespace Store
{

    class Program
    {
        static void Main(string[] args)
        {
            bool endApp = false;

            Console.Title = "Baza produktów: Grzegorz Mikuszewski 17859";
            Console.WriteLine("Start programu");

            Console.WriteLine("Autor Grzegorz Mikuszewski");

            CatalogModel.AddCategory("Food");
            CatalogModel.AddCategory("Clothes");

            while (!endApp)
            {
                endApp = MainController.Menu();
            }
            return;
        }
    }
}