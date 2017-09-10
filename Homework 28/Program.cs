using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_28
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager pm = new ProductManager();
            Category crystals = new Category { Name = "Crystal", IsFragile = true };
            Category shoes = new Category { Name = "Shoes", IsFragile = false };
            Category Groceries = new Category { Name = "Groceries", IsFragile = false };

            pm.Add(crystals);
            pm.Add(shoes);
            pm.Add(Groceries);

            pm.AddProduct(new Product{Brand = "Sterns", price = 5.99, Title = "Rugelach"}, Groceries.Name);
            pm.AddProduct(new Product { Brand = "Kleenex", price = 2.49, Title = "Tissue" }, Groceries.Name);
            pm.AddProduct(new Product { Brand = "CrystalClear", price = 15.99, Title = "pitcher" }, crystals.Name);
            pm.AddProduct(new Product { Brand = "Frye", price = 109, Title = "Oxfords" }, shoes.Name);
            pm.AddProduct(new Product { Brand = "Coach", price = 149, Title = "Loafers" }, shoes.Name);
            pm.AddProduct(new Product { Brand = "pretty ballerinas", price = 145, Title = "bellet flats" }, shoes.Name);
            Console.WriteLine(pm.AreAllFragile());
            pm.GetAllFragileCategories().Foreach(Console.WriteLine);
            pm.GetAllProductsSortedByPrice().Foreach(Console.WriteLine);
            Console.WriteLine(pm.GetFirstCategoryWithMoreThanFiveProducts());
            pm.GetProductsForFragileCategories().Foreach(Console.WriteLine);
            Console.WriteLine(pm.GetAverageProductPrice());
            Console.ReadKey(true);

        }
       
    }
    public static class EnumerableExtentions
    {
        public static void Foreach<T>(this IEnumerable<T> enumerable, Action<T> action)
        {
            foreach (T obj in enumerable)
            {
                action(obj);
            }
        }
    }

}
