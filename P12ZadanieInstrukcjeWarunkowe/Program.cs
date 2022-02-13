using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P12ZadanieInstrukcjeWarunkowe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Proszę o wpisanie dowolnego równania");

            string rownanie = Console.ReadLine();

            //15*3

            int pozPlus = rownanie.IndexOf("+"); // jezeli nie znalazł to wynik -1
            int pozMinus = rownanie.IndexOf("-");
            int pozMnozenie = rownanie.IndexOf("*");
            int pozDzielenie = rownanie.IndexOf("/");

            //2*2
            //012
            int wynik;
            if (pozPlus > -1)
                wynik = Convert.ToInt32(rownanie.Substring(0, pozPlus)) +
                    Convert.ToInt32(rownanie.Substring(pozPlus+1));
            else if (pozMinus > -1)
                wynik = Convert.ToInt32(rownanie.Substring(0, pozMinus)) -
                    Convert.ToInt32(rownanie.Substring(pozMinus+1));
            else if (pozMnozenie > -1)
                wynik = Convert.ToInt32(rownanie.Substring(0, pozMnozenie)) *
                    Convert.ToInt32(rownanie.Substring(pozMnozenie+1));
            else
                wynik = Convert.ToInt32(rownanie.Substring(0, pozDzielenie)) /
                   Convert.ToInt32(rownanie.Substring(pozDzielenie+1));

            Console.WriteLine("wynik to: " + wynik);
            Console.ReadKey();
        }
    }
}
