using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a second number: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"{num1} x {num2} = {num1 * num2}");
        }
    }
}
