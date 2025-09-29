namespace _09_ImmutableRecordUsingInit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var p1 = new Point(2, 3);
            var p2 = new Point(2, 3);

            var p3 = new Point
            {
                X = 10,
                Y = 20
            };

            //p3.X = 30; // Compile time error = init-only property

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

        public int X { get; init; }
        public int Y { get; init; }

        public Point()
        {

        }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}

