using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Size
{
    public class Size : ISize
    {
        private double _height;
        private double _width;
        private double _lenght;
        public double Height
        {
            get
            {
                return _height;
            }

            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Error");
                }
                else
                {
                    _height = value;
                }
            }
        }

        public double Length
        {
            get
            {
                return _lenght;
            }

            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Error");
                }
                else
                {
                    _lenght = value;
                }
            }
        }

        public double Width
        {
            get
            {
                return _width;
            }

            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Error");
                }
                else
                {
                    _width = value;
                }
            }
        }
    }
}
