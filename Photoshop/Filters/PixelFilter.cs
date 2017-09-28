using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using MyPhotoshop.Data;

namespace MyPhotoshop.Filters
{
    public abstract class PixelFilter: IFilter
    {
        protected IParameters Parameters { get; set; }

        public ParameterInfo[] GetParameters()
        {
            return Parameters.GetParameters();
        }

        protected PixelFilter(IParameters parameters)
        {
            Parameters = parameters;
        }

        public Photo Process(Photo original, double[] parameters)
        {
            var result = new Photo(original.Width, original.Height);

            for (int x = 0; x < result.Width; x++)
                for (int y = 0; y < result.Height; y++)
                {
                    result[x, y] = ProcessPixel(original[x, y], Parameters.ParseParameters(parameters));
                }
            return result;
        }

        protected abstract Pixel ProcessPixel(Pixel original, IParameters parameters);
    }
}
