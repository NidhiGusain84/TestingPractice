using System;

namespace OddEvenProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int.TryParse(Console.ReadLine(), out int num);
            Console.WriteLine();
            Console.WriteLine(OddEvenClass.PrimeEvenOrOdd(num));


        }
    }
}
