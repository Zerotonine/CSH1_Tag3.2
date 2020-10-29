using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSH1_Tag_03._2_Aufgabe_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Datum eingeben: ");
            StringZuDatum(Console.ReadLine(), out string ausgabe);
            Console.WriteLine($"Umgewandelt: {ausgabe}");
            Console.ReadKey();
        }

        static bool StringZuDatum(string datumZahl, out string datumText)
        {
            DateTime datum = new DateTime();

            if (DateTime.TryParse(datumZahl, out datum))
            {
                datumText = "";
                datumText += datum.Day + "." + CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(datum.Month) + " " + datum.Year;
                return true;
            }
            datumText = null;
            return false;
        }

    }

    
}
