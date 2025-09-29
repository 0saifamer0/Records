namespace _11_StructRecord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var p1 = new Point(2, 3);
            Console.WriteLine(p1);

            // Positional record struct is mutable by default
            p1.X = 10;

            // Deconstruction
            var (x, y) = p1;
            Console.WriteLine($"x = {x}, y = {y}");

            Console.ReadKey();
        }
    }

    // Compiler automatically:
    // Make two properties X, Y (Mutable by default)
    // Make constructor properties X, Y
    // Make deconstruction method
    record struct Point(int X, int Y);
}
