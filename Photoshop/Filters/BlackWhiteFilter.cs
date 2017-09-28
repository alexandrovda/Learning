using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using MyPhotoshop.Data;

namespace MyPhotoshop.Filters
{
    class BlackWhiteFilter: PixelFilter
    {
        protected override Pixel ProcessPixel(Pixel original, IParameters parameters)
        {
            var avg = (original.R + original.G + original.B) / 3;
            return new Pixel(avg, avg, avg);
        }

        public override string ToString()
        {
            return "Оттенки серого";
        }

        public BlackWhiteFilter() : base( new EmptyParameters() )
        {
        }
    }
}
