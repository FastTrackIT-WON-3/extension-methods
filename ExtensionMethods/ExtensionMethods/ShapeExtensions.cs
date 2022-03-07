namespace ExtensionMethods
{
    public static class ShapeExtensions
    {
        public static void Rotate(this IShape shape, double angle)
        {
            if (shape is not null && shape.Points is not null)
            {
                foreach (Point p in shape.Points)
                {
                    p.Rotate(angle);
                }
            }
        }
    }
}
