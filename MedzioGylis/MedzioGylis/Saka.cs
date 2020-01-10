using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedzioGylis
{
    class Saka
    {
        private readonly List<Saka> sakos = new List<Saka>();
        private readonly int duomenys;

        public Saka(int duomenys)
        {
            this.duomenys = duomenys;
        }

        public List<Saka> GaukSakas()
        {
            return sakos;
        }

        public void PridekSaka(Saka sakos)
        {
            this.sakos.Add(sakos);
        }

        public int SuzinokGyli(Saka saknis)
        {
            if (saknis == null) return 0;
            int gylis = 0;

            foreach (Saka elementas in saknis.GaukSakas())
            {
                gylis = Math.Max(gylis, SuzinokGyli(elementas));
            }
            return gylis + 1;
        }
    }
}