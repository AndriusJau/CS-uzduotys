using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaikoKampoSkaiciuokle
{
    class Program
    {
        static void Main(string[] args)
        {
            Laikrodis laikas = new Laikrodis();

            while (true)
            {
                Console.Clear();
                laikas.SuzinokValandas();
                laikas.SuzinokMinutes();
                double kampas = laikas.SkaiciuokKampa(laikas.Valandos, laikas.Minutes);

                Console.Write("\nKampas tarp rodykliu (laipsniais): " + kampas);
                Console.WriteLine("\n\nPaspauskite ENTER arba bet kuri kita mygtuka, kad pakartotumete skaiciavima");
                Console.WriteLine("Paspauskite ESC, kad pabaigtumete darba");

                ConsoleKey pasirinkimas = Console.ReadKey(true).Key;
                if (pasirinkimas == ConsoleKey.Escape)
                {
                    break;
                }
            }
        }
    }
}