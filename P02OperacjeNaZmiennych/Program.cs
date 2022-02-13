using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02OperacjeNaZmiennych
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;

            string b = "ala ma kota";

            double d = 5.6;

            a = a + 1; // zwiększenie o 1 

            // *  , / , + , - 

            int a2 = 10 / 3; // wynik? 3

            Console.WriteLine(a2);

            // zapis skrótowy 

            int e = 1;
            e = e + 1;
            e += 1; // zwiększ o 1 
            e += 4;// zwięsz o dowloną inną liczbę 
            e++; // zwiekszenie o 1 


            d--; // zmniejszenie o 1
            d -= 10; // zmniejsz o 10
            d *= 2; // przemnoz przez 2 
            d /= 2; // przedziel przez 2 

            
        }
    }
}
