using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_6_Class
{
    internal class Chemical :Product
    {
        public string _notForChildren { get; private set; }
        public Chemical(string notForChildren, string name, int quantity, decimal price) : base(name, quantity, price)
        {

            _notForChildren = notForChildren;
        }

    }
}
