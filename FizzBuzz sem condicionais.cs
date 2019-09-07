using System;

namespace FizzBuzz
{

    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine(FizzBuzz(Convert.ToInt32(Console.ReadLine())));
            }
        }

        static string FizzBuzz(int value)
        {
            string[] a = new[] { "Fizz", "Buzz", "FizzBuzz", value.ToString() };

            bool isFizz = value % 3 == 0;
            bool isBuzz = value % 5 == 0;

            int t = Convert.ToInt32(isFizz);
            int g = Convert.ToInt32(isBuzz);

            int? aux = null;

            try
            {
                aux = 1 / t;

                try
                {
                    aux = 1 / g;
                }
                catch (ArithmeticException)
                {
                    return a[0];
                }
            }
            catch (ArithmeticException)
            {
                try
                {
                    aux = 1 / g;
                }
                catch (ArithmeticException)
                {
                    return a[3];
                }
                return a[1];
            }
            return a[2];
        }
    }
}