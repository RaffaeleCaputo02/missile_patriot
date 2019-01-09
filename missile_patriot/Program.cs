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
            Console.WriteLine($"l'errore sul tempo risultante in secondi è {errore_tempo}");

            errore_tempo=Math.Round(errore_tempo,2);
            Console.WriteLine($"l'errore sul tempo risultante in secondi approssimato alla seconda decimale è {errore_tempo}");

            int velocità_scud=1676;
            double spazio;

            spazio=velocità_scud*errore_tempo;
            Console.WriteLine($"Lo spazio è {spazio}");
            

            Console.ReadLine();


            
            
           


        }
    }
}
