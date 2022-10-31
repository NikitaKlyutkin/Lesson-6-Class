using MiNET.Blocks;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
        public void PrintAllProduct()
        {
            
            foreach (Product product in products)
            {
                Food? food = product as Food;
                Chemical? chemical = product as Chemical;
                Machinery? machinery = product as Machinery;
                Console.WriteLine("______________");
                Console.WriteLine(product._name);
                Console.WriteLine(product._price);
                Console.WriteLine(product._quantity);
                if (food == product)
                {
                    Console.WriteLine(food._bestBeforeDate);
                }
                else if(chemical == product)
                {
                    Console.WriteLine(chemical._notForChildren);
                }
                else if(machinery == product)
                {
                    Console.WriteLine(machinery._forHome);
                }
            }

        }

        public List<T> SortByType<T>() where T : Product
        {
            var resultSortedList = new List<T>();
            
            foreach (var product in products)
            {
                var castedProduct = product as T;
                if(castedProduct != null)
                    resultSortedList.Add(castedProduct);
            }
            foreach(var product in resultSortedList)
            {
                Food? food = product as Food;
                Chemical? chemical = product as Chemical;
                Machinery? machinery = product as Machinery;
                Console.WriteLine("______________");
                Console.WriteLine(product._name);
                Console.WriteLine(product._price);
                Console.WriteLine(product._quantity);
                if (food == product)
                {
                    Console.WriteLine(food._bestBeforeDate);
                }
                else if (chemical == product)
                {
                    Console.WriteLine(chemical._notForChildren);
                }
                else if (machinery == product)
                {
                    Console.WriteLine(machinery._forHome);
                }
            }
            return resultSortedList;
        }

    }

}
