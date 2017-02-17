using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApplication1.Box
{
    class BoxOfBoxes:IBox
    {
        private List<IBox> inner_boxxes;
        private ISize my_size;

        public BoxOfBoxes(List<IBox> inner_boxxes)
        {
            this.my_size = BoxCompressor.GetSize(inner_boxxes);
            this.inner_boxxes = inner_boxxes;
        }

        public ISize ISize
        {
            get
            {
                return this.my_size;
            }

            set
            {
                throw new NotImplementedException();
            }
        }

      
    }
}
