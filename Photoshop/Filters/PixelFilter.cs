using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using MyPhotoshop.Data;

namespace MyPhotoshop.Filters
{
    public abstract class PixelFilter<T>: IFilter
        where T: class, IParameters, new()
    {
        protected T Parameters { get; set; }

        public ParameterInfo[] GetParameters()
        {
            return Parameters.GetParameters();
        }

        protected PixelFilter()
        {
            Parameters = new T();
        }

        public Photo Process(Photo original, double[] values)
        {
            var result = new Photo(original.Width, original.Height);

            for (int x = 0; x < result.Width; x++)
                for (int y = 0; y < result.Height; y++)
                {
                    Parameters.SetValues(values);
                    result[x, y] = ProcessPixel(original[x, y]);
                }
            return result;
        }

        protected abstract Pixel ProcessPixel(Pixel original);
    }
}
