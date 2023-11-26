namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int a = Int32.Parse(Console.ReadLine());

            if (a % 2 == 0)
            {
                Console.WriteLine($"Число {a} чётное");
            }
            else
            {
                Console.WriteLine($"Число {a} нечётное");
            }

            Console.ReadKey();
        }
    }
}