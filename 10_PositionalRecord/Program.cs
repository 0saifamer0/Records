namespace _10_PositionalRecord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var p1 = new Point(2, 3);
            Console.WriteLine(p1);

            // Positional record class is immutable by default
            //p1.X = 10; // Compile time error

            // Deconstruction
            var (x, y) = p1;
            Console.WriteLine($"x = {x}, y = {y}");

            Console.ReadKey();
        }
    }

    // Compiler automatically:
    // Make two init-only properties X, Y (Immutable by default)
    // Make constructor properties X, Y
    // Make deconstruction method
    record Point(int X, int Y);
}
