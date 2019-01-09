using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace missile_patriot
{
    class Program
    {
        static void Main(string[] args)
        {
            double errore_troncamento=0.000000095;
            double errore_tempo;

            errore_tempo=errore_troncamento*100*60*60*10;
            Console.WriteLine($"l'errore sul tempo risultante è {errore_tempo}");

            Console.ReadLine();


            
            
           


        }
    }
}
