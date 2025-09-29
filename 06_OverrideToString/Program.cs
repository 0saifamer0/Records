namespace _06_OverrideToString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var p1 = new Point(2, 3);
            var p2 = new Point(2, 3);

            // Internally calls ToString()
            Console.WriteLine(p1);
            Console.WriteLine(p2);

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

        public override string ToString()
        {
            return $"{{ X = {X}, Y = {Y} }}";
        }
    }
}
