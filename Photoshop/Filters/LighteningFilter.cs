using System;
using System.Collections.Generic;
using System.Linq;

using MyPhotoshop.Data;
using MyPhotoshop.Filters;

namespace MyPhotoshop
{
	public class LighteningFilter: PixelFilter, IFilter
	{
	    public LighteningFilter()
	    {
            Parameters.Add(new FilterParameter( ){Info = new ParameterInfo { Name = "Коэффициент", MaxValue = 10, MinValue = 0, Increment = 0.1, DefaultValue = 1 }} );
	    }

	    public override string ToString ()
		{
			return "Осветление/затемнение";
		}
		

	    protected override Pixel ProcessPixel( Pixel original, IList< FilterParameter > parameters )
	    {
            return original * parameters.First(p => p.Info.Name == "Коэффициент").Value;
	    }
	}
}

