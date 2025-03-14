using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odevacun
{
    public class Calısan
    {
        public string Ad;
        public string Soyad;
        public string Meslek;
        public decimal Maas;
        public string Departman;
        private decimal maas;

        public Calısan(string ad, string soyad, string meslek, decimal maas, string departman)
        {
            Ad = ad;
            Soyad = soyad;
            Meslek = meslek;
            Maas = maas;
            Departman = departman;
        }
        public void BilgiYazdir()
        {
            Console.WriteLine("Adınız : " + Ad + " Soyadınız : " + Soyad + " Mesleğiniz : " + Meslek + " Maaşınız : " + Maas + " Departmanınız : " + Departman);
        }

    }
}
