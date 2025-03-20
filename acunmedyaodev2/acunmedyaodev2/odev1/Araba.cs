using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acunmedyaodev2.odev1
{
    public class Araba
    {
        public Kapı Kapı;
        public Kasa Kasa;
        public Marka Marka;
        public Pencere Pencere;
        public Model Model;
        public Fiyat Fiyat;

        public Araba(Kapı kapı, Kasa kasa, Marka marka, Pencere pencere, Model model, Fiyat fiyat)
        {
            
            this.Kapı =kapı;
            this.Kasa =kasa;
            this.Marka =marka;
            this.Pencere =pencere;
            this.Model =model;
            this.Fiyat =fiyat;
        }
    }
}
