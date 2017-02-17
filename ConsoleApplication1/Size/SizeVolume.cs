using ConsoleApplication1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Size
{
    public class SizeVolume : Size
    {
        public double Volume()
        {
            return Length * Width * Height;
        }
    }
}
