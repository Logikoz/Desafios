/*
 Fizzbuzz sem if/switch/ternário

Fizzbuzz é uma função que recebe um número e retorna "fizz" se o número for divisível por 3, 
"buzz"  se for divisível por 5 e "fizzbuzz" se for divisível por 3 e 5. Se o número não for divisível 
nem por 3 e nem por 5, retorna o número.

Faça a função fizzbuzz sem usar if, switch ou  ternário
*/

using System;

namespace Logikoz.Desafios
{
    class FizzBuzz
    {
        public static string Fizzbuzz(int value)
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
