using System;
using System.Drawing;

using MyPhotoshop.Data;


namespace MyPhotoshop
{
	public static class Convertors
	{
        
		public static Photo Bitmap2Photo(Bitmap bmp)
		{
		    var photo = new Photo( bmp.Width, bmp.Height );
		    for (var x=0;x<bmp.Width;x++)
				for (var y=0;y<bmp.Height;y++)
				{
				    var pixel=bmp.GetPixel (x,y);
				    photo.SetPixelColor(x,y,(double)pixel.R/255, (double)pixel.G/255, (double)pixel.B/255);
				}
			return photo;
		}
		
		static int ToChannel(double val)
		{
            return (int)(val * 255);
		}
		
		public static Bitmap Photo2Bitmap(Photo photo)
		{
			var bmp=new Bitmap(photo.Width,photo.Height);
			for (int x=0;x<bmp.Width;x++)
			    for( int y = 0; y < bmp.Height; y++ )
			        bmp.SetPixel(
			            x,
			            y,
			            Color.FromArgb(
			                ToChannel( photo[ x, y ].R ),
			                ToChannel( photo[ x, y ].G ),
			                ToChannel( photo[ x, y ].B ) ) );

		    return bmp;
		}
	}
}
