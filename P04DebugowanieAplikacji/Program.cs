using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04DebugowanieAplikacji
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            a++;
            a *= 2;
            a--;

            int b = a * 3;
            b--;

            /* od tego momentu zawsze gdy program będzie 
              zwracał inne wyniki niż przez nas oczekiwane
              staramy się diagnozować problem poprzez tryb debugowanie */
            

        }
    }
}
