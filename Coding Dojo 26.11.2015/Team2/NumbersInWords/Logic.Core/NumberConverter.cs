using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Core
{
    public class NumberConverter
    {
        private readonly Dictionary<int, string> Mapping = new Dictionary<int, string>
        {
            { 0, "null" },
            { 1, "eins" },
            { 2, "zwei" },
            { 3, "drei" },
            { 4, "vier" },
            { 5, "fünf" },
            { 6, "sechs" },
            { 7, "sieben" },
            { 8, "acht" },
            { 9, "neun" },
            { 10, "zehn" },
            { 11, "elf" },
            { 12, "zwölf" },
            { 13, "dreizehn" },
            { 14, "vierzehn" },
            { 15, "fünfzehn" },
            { 16, "sechzehn" },
            { 17, "siebzehn" },
            { 18, "achtzehn" },
            { 19, "neunzehn" },
            { 20, "zwanzig" },
            { 30, "dreißig" },
            { 40, "vierzig" },
            { 50, "fünfzig" },
            { 60, "sechzig" },
            { 70, "siebzig" },
            { 80, "achtzig" },
            { 90, "neunzig" },
            { 100, "hundert" },
            { 1000, "tausend" },
            { 1000000, "million" },
            { 1000000000, "milliarde" },
        };

        private const string And = " und ";

        public string Convert(int value)
        {
            string output = string.Empty;

            output += reduceValueByFactor(ref value, 1000000000);
            output += reduceValueByFactor(ref value, 1000000);
            output += reduceValueByFactor(ref value, 1000);

            if (String.IsNullOrEmpty(output) || value > 0)
            {
                output += convertBlock(value);
            }

            return output;
        }

        private string reduceValueByFactor(ref int value, int factor)
        {
            string output = string.Empty;

            if (value >= factor)
            {
                var count = value / factor;
                value -= count * factor;

                output = convertBlock(count);

                if (count == 1)
                {
                    output = output.TrimEnd('s');

                    if (factor > 1000)
                    {
                        output += "e";
                    }
                }

                output += string.Concat(" ", Mapping[factor]);

                if (count > 1 && factor > 1000)
                {
                    output += factor == 1000000 ? "en" : "n";
                }

                if (value > 0)
                {
                    output += " ";
                }
            }

            return output;
        }

        private string convertBlock(int value)
        {
            string output = string.Empty;

            if (value <= 999)
            {
                if (value >= 100)
                {
                    output += reduceValueByFactor(ref value, 100);
                }

                if (value >= 20)
                {
                    var tensCount = value / 10;
                    value -= tensCount * 10;

                    if (value > 0)
                    {
                        output += value > 1 ? Mapping[value]
                                            : Mapping[value].TrimEnd('s');
                            
                        output += And;
                    }

                    output += Mapping[tensCount * 10];
                }
                else
                {
                    output += Mapping[value];
                }
            }

            return output;
        }
    }
}
