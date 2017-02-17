using ConsoleApplication1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Car
{
    class SmallCar : Car
    {

        public SmallCar()
        {
            Price = 200;
            ISize = new Size.Size();
        }
        
        double _price;
        public SmallCar(double Price)

        {

            _price = Price;

        }
        public ISize ISize
        {
            get
            {
                return new ConsoleApplication1.Size.Size();
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
                return _price - (_price * 0.1); //-10% за использование автомобиля
            }

            set
            {
                if (value < 0 && value == _price) return;
                _price = value;
            }
        }

        public double CountPrice(List<IBox> Boxes)
        {
            //double len = Boxes.Sum(s => s.ISize.Length);
            throw new NotImplementedException();

        }
    }
}
