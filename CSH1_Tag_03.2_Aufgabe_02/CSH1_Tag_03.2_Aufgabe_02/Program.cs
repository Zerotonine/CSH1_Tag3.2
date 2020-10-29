using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSH1_Tag_03._2_Aufgabe_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int summe = 0;
            bool check;
            while (true)
            {
                int i = 0;
                do
                {
                    check = InputINT("Bitte Zahl eingeben", out i);
                } while (!check);
                summe += i;
                Console.WriteLine($"Summe: {summe}");

                if (Console.ReadKey().Key == ConsoleKey.Escape)
                    break;
                Console.Clear();
            }

        }

        static bool InputINT(string s, out int x)
        {
            string eingabe;
            Console.WriteLine(s);
            eingabe = Console.ReadLine();

            return Int32.TryParse(eingabe, out x);
        }
    }
}
