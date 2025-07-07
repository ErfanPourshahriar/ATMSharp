using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    class Program
    {
        static void Main(string[] args)
        {
            bool available = false;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("[>>]: Enter your Withdraw amount (e.g. 100000): ");
            int enteredAmount = int.Parse(Console.ReadLine());
            if (enteredAmount >= 10000 && enteredAmount % 10 == 0)
            {
                Console.WriteLine("[...]: Please wait..., The system is counting money...");

                for (int i = 0; i <= 30; i++)
                {
                    for (int g = 0; g <= 25; g++)
                    {
                        if (50000 * i + 10000 * g == enteredAmount)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                            Console.WriteLine("───────────────────────────────────────────────────────");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("50,000T => [{0}] | 10,000T => [{1}] == {2}T", i, g, enteredAmount.ToString("#,0"));
                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                            Console.WriteLine("───────────────────────────────────────────────────────");
                            available = true;
                        }

                    }
                }
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("[!!]: The value of amount wasn't valid.");

            }

            if (available == false) {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("[!!]: There is not enough ATM balance. The operation was canceled.");
            }

            Console.ReadKey();
        }
    }
}
