using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P13Petle
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 20;

            while (a<10)
            {
                Console.WriteLine(a);
                a++;
            }

            // mamy jeszcze inne petle 
            a = 20;
            do
            {
                Console.WriteLine(a);
                a++;
            } while (a<10);

            // petla for znajbardziej popularna 
            for (int i = 10; i < 20; i+=2)
                Console.WriteLine(i);
            
            // jak mam jdną instrukcję to z klamerek moge zrezygnowac 



            Console.ReadKey();

        }
    }
}
