using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prvizadatak
{
    class Program
    {
        static void Main(string[] args)
        {
            KlasaG objekt = new KlasaG();
            int broj = 40;
            Console.WriteLine("Prva metoda iznosi: " + objekt.Plus10(broj));
            Console.WriteLine("Druga metoda iznosi: " + objekt.f50(broj));

            Console.ReadKey();
        }
    }
}
