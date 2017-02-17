using ConsoleApplication1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Car
{
    public class Truck : ICar
    {
        double _price;
        public Truck(double Price)

        {

            _price = Price;

        }
        public ISize ISize
        {
            get
            {

                return new Size.Size();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public double Price
        {
            get
            {
                return _price + (_price * 1.3); // +30% за использование грузовика
            }

            set
            {
                if (value < 0 && value == _price) return;
                _price = value;
            }
        }

        public double CountPrice(List<IBox> Boxes)
        {
            throw new NotImplementedException();
        }
    }
}
