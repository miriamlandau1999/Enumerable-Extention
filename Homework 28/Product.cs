using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_28
{
    public class Product
    {
        public string Title { get; set; }
        public string Brand { get; set; }
        public double price { get; set; }
        public override string ToString()
        {
            return $"{Title}, {Brand}, {price}";
        }
    }
    public class Category
    {
        public Category()
        {
           products =  new List<Product>();
        }
        public string Name { get; set; }
        public bool IsFragile { get; set; }
        public List<Product> products { get; private set; }
        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
