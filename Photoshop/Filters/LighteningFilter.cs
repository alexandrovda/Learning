using MyPhotoshop.Data;

namespace MyPhotoshop.Filters
{
	public class LighteningFilter: PixelFilter
	{
	    public LighteningFilter() : base(new LightningParameters()){}

	    public override string ToString ()
		{
			return "Осветление/затемнение";
		}
		

	    protected override Pixel ProcessPixel( Pixel original, IParameters parameters )
	    {
            return original * ((LightningParameters)parameters).Coefficient;
	    }
	}
}

