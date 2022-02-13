using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P09WczytywanieZPliku
{
    class Program
    {
        static void Main(string[] args)
        {
            // string dane = File.ReadAllText("c:\\ane\\lik.txt");
            string dane = File.ReadAllText(@"c:\dane\plik.txt");

            string s = "ala\tma\nkota";
            Console.WriteLine(s);

            Console.WriteLine(dane);

            File.WriteAllText(@"c:\dane\wynik.txt", s);

            Console.ReadKey();
        }
    }
}
