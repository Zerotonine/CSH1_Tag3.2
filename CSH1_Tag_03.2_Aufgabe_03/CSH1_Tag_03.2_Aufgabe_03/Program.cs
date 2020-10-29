using System;
using System.Collections.Generic;
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
                string monat = "";
                switch (datum.Month)
                {
                    case 1:
                        monat = "Januar";
                        break;
                    case 2:
                        monat = "Februar";
                        break;
                    case 3:
                        monat = "März";
                        break;
                    case 4:
                        monat = "April";
                        break;
                    case 5:
                        monat = "Mai";
                        break;
                    case 6:
                        monat = "Juni";
                        break;
                    case 7:
                        monat = "Juli";
                        break;
                    case 8:
                        monat = "August";
                        break;
                    case 9:
                        monat = "September";
                        break;
                    case 10:
                        monat = "Oktober";
                        break;
                    case 11:
                        monat = "November";
                        break;
                    case 12:
                        monat = "Dezember";
                        break;
                }
                datumText += datum.Day + "." + monat + " " + datum.Year;
                return true;
            }
            datumText = null;
            return false;
        }

    }

    
}
