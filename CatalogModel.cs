using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    internal static class CatalogModel
    {
        static List<Category> categories = new List<Category>();
        public static void ShowCategory(string name)
        {

            foreach (var category in categories)
            {
                if (name == category.getName())
                {
                   category.ShowCategoryParameters();
                    return;
                }
               }
        }
        public static void AddCategory(string name)
        {
            categories.Add(new Category(name));
        }
        public static void RemoveCategory(string name)
        {
            for (int i = 0; i < categories.Count; i++)
            {
                if (name == categories[i].getName())
                {
                    categories.RemoveAt(i);
                }
            }
        }
        public static void AddProduct(string category_name)
        {

            foreach (var category in categories)
            {
                if(category_name==category.getName())
                {
                    Product item = new();
                    item.SetProductParameters();
                    category.AddProduct(item);
                    return;
                }
            }
        }
        public static void RemoveProduct(string category_name, int product_id)
        {

            foreach (var category in categories)
            {
                if (category_name == category.getName())
                {
                    Product item = new();
                    category.RemoveProduct(product_id);
                    return;
                }
            }
        }
        public static void ShowAll()
        {
            foreach (var category in categories)
            {
                Console.WriteLine(category.getName());
            }
        }
    }
}
