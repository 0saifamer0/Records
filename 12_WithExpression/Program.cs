namespace _12_WithExpression
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var p1 = new Point(2, 3);

            // If i want to copy p1 with changing in X property
            // Solution 1 (not recommended)
            var p2 = new Point(10, p1.Y);
            // Solution 2 (recommended) (with expression) (copy from p1 to p3 with changing in X property)
            var p3 = p1 with { X = 10 };

            Console.WriteLine(p1);
            Console.WriteLine(p2);
            Console.WriteLine(p3);

            Console.ReadKey();
        }
    }

    record Point(int X, int Y);
}
