namespace _05_OverrideEqualityOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var p1 = new Point(2, 3);
            var p2 = new Point(2, 3);

            Console.WriteLine($"p1.Equals(p2): {p1.Equals(p2)}"); // True

            Console.WriteLine($"p1 == p2: {p1 == p2}"); // True

            Console.WriteLine($"p1 != p2: {p1 != p2}"); // False

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

        public static bool operator ==(Point lhs, Point rhs)
        {
            if (lhs is null)
            {
                if (rhs is null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            return lhs.Equals(rhs);
        }

        public static bool operator !=(Point lhs, Point rhs)
        {
            return !(lhs == rhs);
        }
    }
}
