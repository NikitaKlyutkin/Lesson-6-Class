using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_6_Class
{
    internal class Food : Product
    {
        public int BestBeforeDate { get; private set; }
        public Food(int bestbe, string name, int quantity, decimal price):base(name, quantity, price)
        {
            
            BestBeforeDate = bestbe;
        }
           
    }
}
