using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using MyPhotoshop.Data;

namespace MyPhotoshop.Filters
{
    class BlackWhiteFilter: PixelFilter<EmptyParameters>
    {
        protected override Pixel ProcessPixel(Pixel original, double[] parameters)
        {
            var avg = (original.R + original.G + original.B) / 3;
            return new Pixel(avg, avg, avg);
        }

        public override string ToString()
        {
            return "Оттенки серого";
        }
    }
}
