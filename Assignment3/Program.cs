using System;

namespace Assignment3
{
    class Program
    {
        static String intToRoman(int num)
        {
            String[] m = { "", "M", "MM", "MMM" };
            String[] c = { "",  "C",  "CC",  "CCC",  "CD",
                       "D", "DC", "DCC", "DCCC", "CM" };
            String[] x = { "",  "X",  "XX",  "XXX",  "XL",
                       "L", "LX", "LXX", "LXXX", "XC" };
            String[] i = { "",  "I",  "II",  "III",  "IV",
                       "V", "VI", "VII", "VIII", "IX" };

            String thousands = m[num / 1000];
            String hundereds = c[(num % 1000) / 100];
            String tens = x[(num % 100) / 10];
            String ones = i[num % 10];

            String ans = thousands + hundereds + tens + ones;

            return ans;
        }
        public static void Main()
        {
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(intToRoman(number));
        }
    }
}
