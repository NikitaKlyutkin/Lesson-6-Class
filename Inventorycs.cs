using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_6_Class
{
    internal class Inventorycs
    {
        internal List<Product> products;
        public void AddProduct(Product product)
        {
            products.Add(product);
        }
        public void Print()
        {

            Console.WriteLine(products[0]._name);
            Console.WriteLine(products[0]._price);
            Console.WriteLine(products[0]._quantity);
            Console.WriteLine(products[0].)
        }
    }
}
