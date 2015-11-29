using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Numbers
{
    public class NumberConverter
    {
        string[] numbers = new string[] { "null", "ein", "zwei", "drei", "vier", "fünf", "sechs", "sieben", "acht", "neun", "zehn", "elf", "zwölf" };
        string[] zehner = { "", "zehn", "zwanzig", "dreißig", "vierzig", "fünfzig", "sechzig", "siebzig", "achtig", "neunzig" };

        public string Convert(int number)
        {
            string rst = "";

            var tausender = number / 1000;
            var rest = number % 1000;
            if (tausender > 0)
            {
                rst = numbers[tausender] + "tausend";
            }

            var hunderter = rest / 100;
            if (hunderter > 0 && hunderter < 10)
            {
                rst += numbers[hunderter] + "hundert";
            }

            if (number % 100 == 0) return rst;


            rst += GetNumber2digit(rest % 100);
            return rst;
        }

        string GetNumber2digit(int number )
        {
            string rst = string.Empty;
            var index = number % 10;
            if (index > 0)
            {
                if (number == 12)
                    return numbers[number];
                if (number == 11)
                    return numbers[number];
                if (number == 1)
                    return numbers[number] + "s";
                rst += numbers[index];
            }
            if (number % 100 > 20 && index > 0)
            {
                rst += "und";
            }
            index = (number / 10) % 10;
            rst += zehner[index];

            return rst;
        }
    }
}
