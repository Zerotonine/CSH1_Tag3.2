using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSH1_Tag_03._2_Aufgabe_00
{
    class Program
    {
        static void Main(string[] args)
        {
            int zahl1, zahl2;

            while(true)
            {
                Console.Write("Dividend angeben: ");
                zahl1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Divisor angeben: ");
                zahl2 = Convert.ToInt32(Console.ReadLine());

                if(Teilen(zahl1, zahl2, out double ergebnis))
                {
                    Console.WriteLine($"Das Ergebnis lautet: {ergebnis}");
                } else
                {
                    Console.WriteLine("Teilen durch 0 nicht möglich!");
                }

                if (Console.ReadKey().Key == ConsoleKey.Escape)
                    break;
                Console.Clear();
            }
        }

        static bool Teilen(int dividend, int divisor, out double quotient)
        {
            if (divisor == 0)
            {
                quotient = 0;
                return false;
            }
            quotient = (double)dividend / (double)divisor;
            return true;
        }
    }
}
