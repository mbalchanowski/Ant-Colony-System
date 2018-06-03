namespace AntColonySystem
{
    public struct Point
    {
        public float X;
        public float Y;
        public int Id;

        public Point(int id, float x, float y)
        {
            X = x;
            Y = y;
            Id = id;
        }

        public double DistanceTo(Point anotherPoint)
        {
            return Distance.Euclidean(X, Y, anotherPoint.X, anotherPoint.Y);
        }
    }
}
