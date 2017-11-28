using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_EnterNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbersCount = 10;
            int startValue = 1;
            int endValue = 100;
            List<int> numbers = new List<int>();

            try
            {
                for (int i = 0; i < numbersCount; i++)
                {
                    numbers.Add(ReadNumbers(startValue, endValue));
                }

                for (int i = 1; i < numbersCount; i++)
                {
                    if (numbers[i] <= numbers[i - 1])
                    {
                        throw new Exception();
                    }
                }

                Console.Write("{0} < ", startValue);
                for (int i = 0; i < numbersCount; i++)
                {
                    Console.Write(numbers.Min() + " < ");
                    numbers.Remove(numbers.Min());
                }
                Console.WriteLine(endValue);
            }
            catch (Exception)
            {
                Console.WriteLine("Exception");
            }
        }


        static int ReadNumbers(int start, int end)
        {
            string input = Console.ReadLine();
            int number = 0;
            try
            {
                number = int.Parse(input);
                if (number < start || number > end)
                {
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                throw new Exception();
            }
            return number;
        }
    }
}
