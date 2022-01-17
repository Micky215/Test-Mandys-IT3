using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Mandys_IT3
{
    class Ucet
    {
        public string jmeno;
        public float zustatek;
        //public float limit;


        public Ucet(string jmeno, float zustatek)
        {
            this.jmeno = jmeno;
            this.zustatek = zustatek;
        }


        public void Vklad(int mnozstvi)
        {
            if (mnozstvi > 200000)
            {
                zustatek = 200000;
            }
            else
            {
                zustatek += mnozstvi;
            }
        }
        public void Vyber(int mnozstvi)
        {
            if (zustatek - mnozstvi < 0)
            {
                zustatek = 0;
            }
            else
            {
                zustatek -= mnozstvi;
            }
        }
        public void Plat(int mnozstvi)
        {
            if (zustatek - mnozstvi < 0)
            {
                zustatek = 0;
            }
            else
            {
                zustatek -= mnozstvi;
            }
        }
        //public void Limit(int mnozstvi)
        //{
        //    if (zustatek > mnozstvi)
        //    {
        //        zustatek = mnozstvi;
        //    }
        //    else
        //    {
        //        zustatek = zustatek;
        //    }
        //}
    }
}
