using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06WczytywanieDanych
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "ala ma kota";

            Console.WriteLine(s);

            string s2 = Console.ReadLine();

            string s3 = s2 +" hej";
            Console.WriteLine(s3);
            Console.ReadKey();
        }
    }
}
