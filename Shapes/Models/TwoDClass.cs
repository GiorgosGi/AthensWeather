using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.Models
{
    class TwoDClass : Shape
    {
        public int MyProperty { get; set; }

        public TwoDClass()
        {
            Console.WriteLine("2D");
        }

    }
}
