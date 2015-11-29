using Logic.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            NumberConverter converter = new NumberConverter();

            System.Console.WriteLine("Type \"exit\" to close the application...");

            while (true)
            {
                System.Console.WriteLine("\nEnter a number:");

                string input = System.Console.ReadLine();

                if (input == "exit")
                {
                    break;
                }
                else
                {
                    int value = 0;

                    if (!int.TryParse(input, out value))
                    {
                        System.Console.WriteLine("Error");
                    }
                    else
                    {
                        System.Console.WriteLine(converter.Convert(value));
                    }
                }
            }
        }
    }
}
