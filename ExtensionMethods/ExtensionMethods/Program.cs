using System;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle t = new Triangle(
                new Point(10, 10),
                new Point(20, 30),
                new Point(100, 250));

            Rectangle r = new Rectangle(
                new Point(10, 10),
                100,
                200);

            t.Rotate(10);
            r.Rotate(30);
        }



    }
}
