namespace Desafios
{
    class Decimal2Roman
    {
        public static string ToRoman(uint value)
        {
            (string, uint) a = (string.Empty, value);

            while (a.Item2 != 0)
            {
                if (a.Item2 >= 1000) a = (a.Item1 += "M", a.Item2 -= 1000);
                else if (a.Item2 >= 900) a = (a.Item1 += "CM", a.Item2 -= 900);
                else if (a.Item2 >= 500) a = (a.Item1 += "D", a.Item2 -= 500);
                else if (a.Item2 >= 100) a = (a.Item1 += "C", a.Item2 -= 100);
                else if (a.Item2 >= 90) a = (a.Item1 += "XC", a.Item2 -= 90);
                else if (a.Item2 >= 50) a = (a.Item1 += "L", a.Item2 -= 50);
                else if (a.Item2 >= 40) a = (a.Item1 += "XL", a.Item2 -= 40);
                else if (a.Item2 >= 10) a = (a.Item1 += "X", a.Item2 -= 10);
                else if (a.Item2 >= 9) a = (a.Item1 += "IX", a.Item2 -= 9);
                else if (a.Item2 >= 5) a = (a.Item1 += "V", a.Item2 -= 5);
                else if (a.Item2 >= 4) a = (a.Item1 += "IV", a.Item2 -= 4);
                else if (a.Item2 >= 1) a = (a.Item1 += "I", a.Item2 -= 1);
            }

            return a.Item1;
        }
    }
}
