using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using MyPhotoshop.Data;

namespace MyPhotoshop.Filters
{
    public abstract class PixelFilter<T> : ParametrisedFilter<T>
        where T: IParameters, new()
    {
        protected override Photo Process(Photo original, T parameters)
        {
            var result = new Photo(original.Width, original.Height);

            for (int x = 0; x < result.Width; x++)
                for (int y = 0; y < result.Height; y++)
                {
                    result[x, y] = ProcessPixel(original[x, y], parameters);
                }
            return result;
        }

        protected abstract Pixel ProcessPixel(Pixel original, T parameters);
    }
}
