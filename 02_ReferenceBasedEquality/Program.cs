namespace _02_ReferenceBasedEquality
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var p1 = new Point(2, 3);
            var p2 = new Point(2, 3);

            Console.WriteLine(p1.Equals(p2)); // False
            Console.WriteLine(Object.ReferenceEquals(p1, p2)); // False

            p1 = p2;

            Console.WriteLine(p1.Equals(p2)); // True
            Console.WriteLine(Object.ReferenceEquals(p1, p2)); // True

            Console.ReadKey();
        }
    }

    class Point
    {
        public int X;
        public int Y;

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
