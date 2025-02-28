using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arachareket.AracHareket
{
    public class Porsche : Arac, IHavadaUcar
    {
        public void HavadaUcar(string isim)
        {
            Console.WriteLine(isim + " Havada Ucar...");
        }
    }
}
