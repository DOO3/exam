using ConsoleApplication1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Size
{
    public class SizeCar : Size
    {
        public double Size()
        {
            return Length * Width * Height;
        }
    }
}
