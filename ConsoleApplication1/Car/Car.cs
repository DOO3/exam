using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication1.Size;
using ConsoleApplication1.Box;

namespace ConsoleApplication1.Car
{
    class Car : ICar
    {
        double _price;
       public Car(double Price)
            
        {

        _price=Price;

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
                return _price + (_price * 1.1); //+10% за использование автомобиля
            }

            set
            {
               if (value<0 && value==_price) return;
                _price = value;
               
            }
        }

        public virtual double CountPrice(List<IBox> Boxes)
        {
            var result_size = BoxCompressor.GetSize(Boxes);
            var carsize = new Car();
            var result = new SizeComparer();

            if (result.Compare(result_size, carsize.ISize))
            {
                return 0;
            }
            else
            {
                return 5;
            }
        }
    }
}
