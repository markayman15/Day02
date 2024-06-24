namespace Day02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter your name: ");
            string Name = Console.ReadLine() ?? "NA";

            Console.Write("enter your age: ");
            int.TryParse(Console.ReadLine() ?? "0", out int Age);

            Console.Write("enter your salary: ");
            double.TryParse(Console.ReadLine() ?? "0", out double Salary);

            Console.Clear();

            Console.WriteLine($"Your Name Is {Name}");
            Console.WriteLine($"Your Age Is {Age}");
            Console.WriteLine($"Your Salary Is {Salary}");
        }
    }
}
