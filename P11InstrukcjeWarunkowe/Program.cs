using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P11InstrukcjeWarunkowe
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;

            if (a > 10)
            {
                Console.WriteLine("duża");
            }
            else
            {
                if (a > 5)
                {
                    Console.WriteLine("średnia");
                }
                else
                {
                    Console.WriteLine("mała");
                }
            }


            //---------
            if (a > 10)
                Console.WriteLine("duza");
            else
                if (a > 5)
                Console.WriteLine("srednia");
            else
                Console.WriteLine("mała");

            // napisz czy to kobieta czy mezzcyzna bazując tylko na wzroście
            // jezeli wzrost >180 to mezczyzna w przeciwnym wypadku to kobieta

            int wzrost = 175;

            string plec;

            if (wzrost > 180)
                plec = "mezczyzna";
            else
                plec = "kobieta";

            // w takich przypadkach mozna zapisać skrótowo:

            string plec2 = wzrost > 180 ? "mezyczna" : "kobieta";

            Console.WriteLine(plec2);
            Console.ReadKey();
        }
    }
}
