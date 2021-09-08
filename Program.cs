using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the calculator!");
            Console.WriteLine("===============================");

            Console.WriteLine("Enter an operator: ");
            string op = Console.ReadLine();
            Console.WriteLine("How many numbers do you want to " + op);
            int iterations = int.Parse(Console.ReadLine());

            int[] inputs = new int[iterations];

            for (int i = 0; i < iterations; i++)
            {
                Console.WriteLine("Enter number " + (i + 1));
                inputs[i] = int.Parse(Console.ReadLine());
            }

            int res = inputs[0];

            for (int i = 1; i < inputs.Length; i++)
            {
                switch (op)
                {
                    case "+":
                        res += inputs[i];
                        break;
                    case "-":
                        res -= inputs[i];
                        break;
                    case "*":
                        res *= inputs[i];
                        break;
                    case "/":
                        res /= inputs[i];
                        break;
                }
            }

            Console.WriteLine($"The answer is {res}");
        }
    }
}
