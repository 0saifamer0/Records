namespace _04_OverrideEquality
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var p1 = new Point(2, 3);
            var p2 = new Point(2, 3);

            // p1 and p2 are equal, as we override Equals()
            Console.WriteLine($"p1.Equals(p2): {p1.Equals(p2)}"); // True

            // p1 and p2 have the same hash code, as we override GetHashCode()
            Console.WriteLine($"p1.GetHashCode(): {p1.GetHashCode()}");
            Console.WriteLine($"p2.GetHashCode(): {p2.GetHashCode()}");

            // Using Dictionary
            var points = new Dictionary<Point, string>();
            points.Add(p1, "2D Point X: 2, Y: 3");
            // ArgumentException: As key of the Dictionary must be unique
            // p1, p2 have the same hash code, and the Dictionary internally uses hashing
            points.Add(p2, "2D Point X: 2, Y: 3");

            Console.ReadKey();
        }
    }

    class Point : IEquatable<Point>
    {
        public int X;
        public int Y;

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public bool Equals(Point? point)
        {
            if (point is null)
                return false;

            return this.X == point.X && this.Y == point.Y;
        }

        public override bool Equals(object? obj)
        {
            var point = obj as Point;

            return this.Equals(point);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(X, Y);
        }
    }
}
