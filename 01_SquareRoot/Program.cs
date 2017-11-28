using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_SquareRoot
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            try
            {
                double number = double.Parse(input);
                if (number < 0)
                {
                    throw new Exception();
                }
                else
                {
                    double squareRoot = Math.Sqrt(number);
                    Console.WriteLine("{0:f3}", squareRoot);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid number");
            }
            finally
            {
                Console.WriteLine("Good bye");
            }
        }
    }
}
