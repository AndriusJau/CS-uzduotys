using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedzioGylis
{
    class Program
    {
        static void Main(string[] args)
        {
            Saka saknis = new Saka(1);
            Saka saka1 = new Saka(20);
            Saka saka2 = new Saka(20);
            Saka saka3 = new Saka(30);
            Saka saka4 = new Saka(30);
            Saka saka5 = new Saka(40);
            Saka saka6 = new Saka(30);
            Saka saka7 = new Saka(40);
            Saka saka8 = new Saka(40);
            Saka saka9 = new Saka(50);
            Saka saka10 = new Saka(60);

            saknis.PridekSaka(saka1);
            saknis.PridekSaka(saka2);
            saka2.PridekSaka(saka3);
            saka2.PridekSaka(saka4);
            saka4.PridekSaka(saka5);
            saka1.PridekSaka(saka6);
            saka6.PridekSaka(saka7);
            saka6.PridekSaka(saka8);
            saka8.PridekSaka(saka9);
            saka9.PridekSaka(saka10);

            Console.WriteLine("Jusu duomenu medzio gylis: " + saknis.SuzinokGyli(saknis));

            Console.ReadLine();
        }
    }
}