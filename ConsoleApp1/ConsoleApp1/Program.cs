using System;

namespace ConsoleApp1
{
    class Program
    {
        private static int Som(int number1, int number2)
        {
            return number1 + number2;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("som 1 + 2: " + Som(1,2)  );
        }
    }
}
