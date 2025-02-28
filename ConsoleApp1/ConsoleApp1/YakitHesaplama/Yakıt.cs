using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maashesaplama.YakitHesaplama
{
    public abstract class Yakıt
    {
        public abstract double Yakıtmiktarı();
        public void yakitLitresi(string isim)
        {
            Console.WriteLine(isim + "Yakit Litresi : ");
        }
    }
}
