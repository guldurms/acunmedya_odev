using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acunmedyaodev2.odev1
{
    public class ArabaOzellik
    {
        public Araba araba;
        public string marka;
        public string model;
        public int pencere;
        public string kasa;
        public int fiyat;
        public int kapı;

        public ArabaOzellik(Araba araba, string marka, string model, int pencere, string kasa, int fiyat, int kapı)
        {
            this.araba = araba;
            this.marka = marka;
            this.model = model;
            this.pencere = pencere;
            this.kasa = kasa;
            this.fiyat = fiyat;
            this.kapı = kapı;
        }

        public void aracolustur()
        {
            Console.WriteLine("Arabanin markasi : " + marka + " Modeli : " + model + 
                              " Kapı Sayisi : " + kapı + " Pencere Sayisi : " + pencere + 
                              " Kasası : " + kasa + " Fiyati : " + fiyat);
        }
    }
}
