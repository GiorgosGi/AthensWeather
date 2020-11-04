using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.Models
{
    class ThreeDClass : Shape
    {
        public int MyProperty { get; set; }

        public ThreeDClass()
        {
            Console.WriteLine("3D");
        }
    }
}
