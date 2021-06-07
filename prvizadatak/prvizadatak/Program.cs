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
            KlasaG objekt = new KlasaG;
            int broj = 40,Plus10,F50;
            Plus10 = objekt.Plus10(broj);
            F50 = objekt.f50(broj);
            Console.WriteLine("Prva metoda iznosi: " + Plus10);
            Console.WriteLine("Druga metoda iznosi: " + F50);

            Console.ReadKey();
        }
    }
}
