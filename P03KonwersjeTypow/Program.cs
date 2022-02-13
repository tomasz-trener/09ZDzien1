using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03KonwersjeTypow
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "1";
            int b = 1;

            a = a + a; // "11"

            int c = Convert.ToInt32(a);
            c = c + c; // 22

          //  string d = 1;

            Console.WriteLine(c);

            Console.ReadKey();

        }
    }
}
