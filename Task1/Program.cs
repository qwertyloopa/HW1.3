namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double pi = Math.PI;
            Console.WriteLine("Введите радиус");
            int r = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите образующую");
            int I = Int32.Parse(Console.ReadLine());
            double s = pi * r * (r + I);
            Console.WriteLine($"Площадь круга равна {s}");
        }
    }
}