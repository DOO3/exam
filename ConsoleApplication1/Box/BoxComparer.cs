using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Box
{
    public class BoxComparer : IComparer<IBox>
    {
        public int Compare(IBox x, IBox y)
        {
            double res = GetSize(x) - GetSize(y);

            if (res < 0)
                return -1;
            else if (res > 0)
                return 1;
            else
                return 0;
        }

        protected double GetSize(IBox box)
        {
            return box.ISize.Height * box.ISize.Length * box.ISize.Width;
        }
    }
}
