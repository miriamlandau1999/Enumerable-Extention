using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_28
{
    class ProductManager
    {
        private List<Category> _categories = new List<Category>();
        public void Add(Category category)
        {
            _categories.Add(category);
        }
        public void AddProduct(Product product, string CategoryName)
        {
            _categories.First(c => c.Name == CategoryName).products.Add(product);
        }
        public IEnumerable<Category> GetAllFragileCategories()
        {
            return _categories.Where(c => c.IsFragile);
        }
        public IEnumerable<Product> GetAllProducts()
        {
            return _categories.SelectMany(c => c.products);
        }
        public IEnumerable<Product> GetAllProductsSortedByPrice()
        {
            return GetAllProducts().OrderBy(p => p.price);
        }
        public Category GetFirstCategoryWithMoreThanFiveProducts()
        {
            return _categories.FirstOrDefault(c => c.products.Count() > 5);
        }
        public IEnumerable<Product> GetProductsForFragileCategories()
        {
            return GetAllFragileCategories().SelectMany(c => c.products);
        }
        public bool AreAllFragile()
        {
            return _categories.All(c => c.IsFragile);
        }
        public bool AnyCategoryWith100Products()
        {
            return _categories.Any(c => c.products.Count() >= 100);
        }
        public double GetAverageProductPrice()
        {
            return GetAllProducts().Average(p => p.price);
        }


    }
   
}
