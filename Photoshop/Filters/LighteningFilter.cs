using MyPhotoshop.Data;

namespace MyPhotoshop.Filters
{
    public class LighteningFilter : PixelFilter<LightningParameters>
	{
	    public override string ToString ()
		{
			return "Осветление/затемнение";
		}
		

	    protected override Pixel ProcessPixel( Pixel original, double[] values )
	    {
	        Parameters.ParseParameters( values );
            return original * Parameters.Coefficient;
	    }
	}
}

