using MiNET;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lesson_6_Class;

namespace Lesson_6_Class
{
    internal class Initializator
    {

        internal Inventorycs Initialize()
        {
            Inventorycs inventory = new Inventorycs();
            inventory.products = new List<Product>();
            Food apple = new Food(12, "Apple", 20, 12.2m);
            inventory.AddProduct(apple);
            return inventory;
        }
    }
}
