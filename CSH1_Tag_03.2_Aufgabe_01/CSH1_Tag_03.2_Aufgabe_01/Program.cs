using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSH1_Tag_03._2_Aufgabe_01
{
    class Program
    {
        static void Main(string[] args)
        {
            string nachname = "Meyer";
            string vorname = "unbekannt";

            fragUndFuell(nachname, out vorname, out string kurzForm);
            Console.WriteLine($"Vorname: {vorname}\nNachname: {nachname}\nKurzform: {kurzForm}");
            Console.ReadKey();
        }

        static void fragUndFuell(string nachname, out string vorname, out string vorPunktNach)
        {
            Console.Write("Bitte Vornamen eingeben: ");
            vorname = Console.ReadLine();

            vorPunktNach = vorname[0] + "." + nachname;
        }
    }
}
