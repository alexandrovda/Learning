using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyPhotoshop.Data
{
    public struct Pixel
    {
        private double _r;
        private double _g;
        private double _b;

        public Pixel( double r, double g, double b )
        {
            _r = _g = _b = 0;
            R = r;
            G = g;
            B = b;
        }

        public double R
        {
            get { return _r; }
            set
            {
                CheckColorChanelValue( value );
                _r = value;
            }
        }
        public double G
        {
            get { return _g; }
            set
            {
                CheckColorChanelValue( value );
                _g = value;
            }
        }
        public double B
        {
            get { return _b; }
            set
            {
                CheckColorChanelValue( value );
                _b = value;
            }
        }

        private static void CheckColorChanelValue( double value )
        {
            if( value < 0 || value > 1 )
            {
                throw new Exception( string.Format( "Wrong channel value {1} (the value must be between 0 and 1", value ) );
            }
        }

        public static Pixel operator *( Pixel px, double val )
        {
            return new Pixel(px.R * val, px.G * val, px.B * val);
        }

        public static Pixel operator *( double val, Pixel px )
        {
            return px * val;
        }
    }
}
