using System;

using MyPhotoshop.Data;

namespace MyPhotoshop
{
    public class Photo
	{
        private readonly Pixel[,] _pixels;

        public Photo( int width, int height )
        {
            Width = width;
            Height = height;
            _pixels = new Pixel[Width, Width];

            InitializePixels();
        }

        private void InitializePixels()
        {
        }

        public int Width { get; protected set; }
        public int Height { get; protected set; }


        public Pixel this[int x, int y]
        {
            get { return _pixels[x, y]; }
            set { _pixels[ x, y ] = value; }
        }

        public void SetPixelColor(int x, int y, double r, double g, double b)
        {
            _pixels[x, y].R = r;
            _pixels[x, y].G = g;
            _pixels[x, y].B = b;
        }
	}
}

