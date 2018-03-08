using System;
using NCalc;

namespace new_calculator
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Write math expression or \"quit\"");
            while (true)
            {
                var mathString = Console.ReadLine();
                if (mathString == "quit")
                {
                    break;
                }

                Expression exp = new Expression(mathString);
                try
                {
                    var result = exp.Evaluate();

                    Console.WriteLine(result);
                }

                catch
                {
                    Console.WriteLine("Invalid expression");
                }

            }
        }

    }
}
