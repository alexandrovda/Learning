using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using MyPhotoshop.Data;

namespace MyPhotoshop.Filters
{
    public abstract class PixelFilter: IFilter
    {
        protected IList<FilterParameter> Parameters { get; set; }

        public ParameterInfo[] GetParameters()
        {
            return Parameters.Select(p => p.Info ).ToArray();
        }

        protected PixelFilter()
        {
            Parameters = new List<FilterParameter>();
        }

        public Photo Process(Photo original, IList<FilterParameter> parameters)
        {
            var result = new Photo(original.Width, original.Height);

            for (int x = 0; x < result.Width; x++)
                for (int y = 0; y < result.Height; y++)
                {
                    result[x, y] = ProcessPixel(original[x, y], parameters);
                }
            return result;
        }

        protected abstract Pixel ProcessPixel(Pixel original, IList<FilterParameter> parameters);
    }
}
