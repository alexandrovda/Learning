using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyPhotoshop.Data
{
    public enum ColorChanels
    {
        Red = 0,
        Green = 1,
        Blue = 2
    }

    public class RgbColor
    {
        static readonly int ChanelsCount = Enum.GetNames(typeof(ColorChanels)).Length;
        private readonly double[] _color = new double[ChanelsCount];

        public double this[ColorChanels channel]
        {
            get { return _color[(int)channel]; }
            set { _color[(int)channel] = value; }
        }

        public static ColorChanels[] GetAllColorChanels()
        {
            return (ColorChanels[])Enum.GetValues(typeof(ColorChanels));
        }
    }
}
