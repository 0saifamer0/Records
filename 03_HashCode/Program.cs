namespace _03_HashCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var e1 = new Employee { Id = 100, Name = "Saif" };
            var e2 = new Employee { Id = 100, Name = "Saif" };

            // Different hash code as e1 and e2 not equal (reference types)
            Console.WriteLine($"e1.GetHashCode() = {e1.GetHashCode()}");
            Console.WriteLine($"e2.GetHashCode() = {e2.GetHashCode()}");

            var c1 = new Customer { Id = 100, Name = "Saif" };
            var c2 = new Customer { Id = 100, Name = "Saif" };

            // Same hash code as c1 and c2 equal (value types)
            Console.WriteLine($"c1.GetHashCode() = {c1.GetHashCode()}");
            Console.WriteLine($"c2.GetHashCode() = {c2.GetHashCode()}");

            Console.WriteLine(100.GetHashCode()); // 100

            Console.ReadKey();
        }
    }

    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    struct Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
