using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaikoKampoSkaiciuokle
{
    class Laikrodis
    {
        public int Valandos { get; set; }
        public int Minutes { get; set; }

        public double SkaiciuokKampa(int valandos, int minutes)
        {
            if (valandos == 12)
            {
                valandos = 0;
            }
            if (minutes == 60)
            {
                minutes = 0;
                valandos += 1;
            }
            double valandosKampas = (valandos * 60 + minutes) * 0.5;
            double minutesKampas = minutes * 6;
            double kampasTarp = Math.Abs(valandosKampas - minutesKampas);
            return Math.Min(360 - kampasTarp, kampasTarp);
        }

        public void SuzinokValandas()
        {
            bool ivestaTeisingai = false;

            while (!ivestaTeisingai)
            {
                Console.Write("Iveskite valandu reiksme (nuo 0 iki 12): ");
                string ivestis = Console.ReadLine();

                if (!int.TryParse(ivestis, out int reiksme))
                {
                    Console.WriteLine("\nIvedete ne sveikaji skaiciu. Bandykite dar karta.\n");
                }
                else
                {
                    int ivestasSkaicius = Convert.ToInt32(ivestis);

                    if (ivestasSkaicius >= 0 && ivestasSkaicius <= 12)
                    {
                        Valandos = ivestasSkaicius;
                        ivestaTeisingai = true;
                    }
                    else
                    {
                        Console.WriteLine("\nIvestas skaicius nera tarp 0 ir 12. Bandykite dar karta.\n");
                    }
                }
            }
        }

        public void SuzinokMinutes()
        {
            bool ivestaTeisingai = false;

            while (!ivestaTeisingai)
            {
                Console.Write("Iveskite minuciu reiksme (nuo 0 iki 60): ");
                string ivestis = Console.ReadLine();

                if (!int.TryParse(ivestis, out int reiksme))
                {
                    Console.WriteLine("\nIvedete ne sveikaji skaiciu. Bandykite dar karta.\n");
                }
                else
                {
                    int ivestasSkaicius = Convert.ToInt32(ivestis);

                    if (ivestasSkaicius >= 0 && ivestasSkaicius <= 60)
                    {
                        Minutes = ivestasSkaicius;
                        ivestaTeisingai = true;
                    }
                    else
                    {
                        Console.WriteLine("\nIvestas skaicius nera tarp 0 ir 60. Bandykite dar karta.\n");
                    }
                }
            }
        }
    }
}
