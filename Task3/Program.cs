namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 14;
            int y = 1;
            int z = 5;

            x += y - x++ * z;
            Console.WriteLine($"{x} {y} {z}");
            z = --x - y * 5;
            Console.WriteLine($"{x} {y} {z}");
            y /= x + 5 % z;
            Console.WriteLine($"{x} {y} {z}");
            z = x++ + y * 5;
            Console.WriteLine($"{x} {y} {z}");
            x = y - x++ * z;
            Console.WriteLine($"{x} {y} {z}");

            Console.ReadKey();
        }
    }
}