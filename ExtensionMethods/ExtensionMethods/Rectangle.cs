using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    public class Rectangle : IShape
    {
        public Rectangle(Point topLeft, int width, int height)
        {
            Points = new[]
            {
                topLeft,
                   new Point(topLeft.X + width, topLeft.Y), // topRight
                   new Point(topLeft.X + width, topLeft.Y + height), // bottomRight
                   new Point(topLeft.X, topLeft.Y + height) // bottomLeft
            };

            Width = width;
            Height = height;
        }

        public int Height { get; }

        public int Width { get; }

        public Point[] Points { get; private set; }
    }
}
