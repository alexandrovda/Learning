using MyPhotoshop.Data;

namespace MyPhotoshop.Filters
{
    public class LighteningFilter : PixelFilter<LightningParameters>
	{
	    public override string ToString ()
		{
			return "Осветление/затемнение";
		}
		

	    protected override Pixel ProcessPixel( Pixel original, LightningParameters parameters )
	    {
            return original * parameters.Coefficient;
	    }
	}
}

