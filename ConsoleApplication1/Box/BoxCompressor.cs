using System;
using System.Collections.Generic;

namespace ConsoleApplication1.Box
{
    public static class BoxCompressor
    {
        public static ISize GetSize(List<IBox> boxes)
        {
            ISize size = new Size.Size();

            foreach (var box in boxes)
            {
                size.Height += box.ISize.Height;

                if (size.Length < box.ISize.Length)
                    size.Length = box.ISize.Length;

                if (size.Width < box.ISize.Width)
                    size.Width = box.ISize.Width;
            }

            return size;
        }

        public static List<IBox> Pack(List<IBox> boxes)
        {
            List<IBox> packed = new List<IBox>(boxes.Count);

            for (int i = 0; i < boxes.Count; ++i)
                packed.Add(boxes[i]);
            
            packed.Sort(new BoxComparer());

            return packed;
        }
    }
}
