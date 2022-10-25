using MiNET;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_6_Class
{
    internal class Initializator
    {
      Food apple = new Food(12, "Apple", 20, 12.2m);
      Inventorycs inventory = new Inventorycs();
      inventory.AddProduct(apple); // не работает
    }
}
