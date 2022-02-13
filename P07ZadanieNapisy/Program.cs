using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P07ZadanieNapisy
{
    class Program
    {
        static void Main(string[] args)
        {

            //abc
            //012  len = 3   ostatni znak len-2
            string s = Console.ReadLine();

            Console.WriteLine("Ciag posiada " + s.Length + " znaków");

            string s2 = 
                s.Substring(0, 1).ToUpper() + // pierwszy znak
                s.Substring(1, s.Length - 2).ToLower() + // środek
                s.Substring(s.Length - 1).ToUpper(); // ostatni znak 

            Console.WriteLine(s2);
            Console.ReadKey();
        }
    }
}
