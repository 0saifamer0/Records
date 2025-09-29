namespace _08_RecordRescue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var p1 = new Point(2, 3);
            var p2 = new Point(2, 3);

            // Check Equality
            Console.WriteLine($"p1.Equals(p2): {p1.Equals(p2)}"); // True
            Console.WriteLine($"p1 == p2: {p1 == p2}"); // True
            Console.WriteLine($"p1 != p2: {p1 != p2}"); // False

            // Check Hash Code
            Console.WriteLine($"p1.GetHashCode(): {p1.GetHashCode()}");
            Console.WriteLine($"p2.GetHashCode(): {p2.GetHashCode()}");

            // Check ToString
            Console.WriteLine(p1);
            Console.WriteLine(p2);

            Console.ReadKey();
        }
    }

    record Point
    {
        // Record automatically:
        // Implement IEquatable<Point>
        // Override Equals()
        // Override GetHashCode()
        // Override ==, !=
        // Override ToString()

        public int X;
        public int Y;

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
