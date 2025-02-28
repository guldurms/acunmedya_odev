using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arachareket.AracHareket
{
    public class Mercedes : Arac, IDenizdeYuzer, IHavadaUcar
    {
        public void DenizdeYuzer(string isim)
        {
            Console.WriteLine(isim + " Denizde Yuzer...");
        }

        public void HavadaUcar(string isim)
        {
            Console.WriteLine(isim + " Havada Ucar...");
        }
    }
}
