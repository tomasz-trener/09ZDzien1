using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05OperacjeNaNapisach
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "ala ma kota";
                      //012345678910    
            int a = s.Length;// długośc tego ciagu tesktowego

            string s2 = s.Substring(4); //ma kota
            string s3 = s.Substring(4, 2); //ma

            string s4 = s.ToUpper(); // zamiana na duze litery
            string s5 = s.ToLower();

            string s6 = s.Replace("ma", "bedzie miala");

            //s.Replace("ma", "bedzie miala"); ta instrukcja nie ma sensu 

            bool b1 = s.Contains("ma"); // true lub false 

            string s7 =  s.Trim(); // usuwa spacje z poczatku i z konca ale nie ze środka 

            int a2 = s.IndexOf("ma"); // podaje pozycję ma 



        }
    }
}
