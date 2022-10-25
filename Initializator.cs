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
            Food apple = new Food(12, "Apple", 20, 12.2m);
            Inventorycs inventory = new Inventorycs();
            inventory.AddProduct(apple);
            return inventory;
        }
    }
}
