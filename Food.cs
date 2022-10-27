using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_6_Class
{
    internal class Food : Product
    {
        public int _bestBeforeDate { get; private set; }
        public Food(int bestBeforeDate, string name, int quantity, decimal price):base(name, quantity, price)
        {
            
            _bestBeforeDate = bestBeforeDate;
        }
           
    }
}
