using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication1.Box;
using ConsoleApplication1.Car;
using ConsoleApplication1.Size;

namespace ConsoleApplication1.Dyadchenko
{
    public static class Dyadchenko
    {
        public static double DyadchenkoMethod()
        {
            List<IBox> boxes = new List<IBox>
            {
                new BoxMetal(),
                new BoxMetal(),
                new BoxMetal()
            };

            var pakege = new BoxOfBoxes(boxes);

            ICar car = new SmallCar();
            return car.CountPrice(boxes);
        }
    }
}
