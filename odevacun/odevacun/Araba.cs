using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odevacun
{
    public class Araba
    {
        public string marka;
        public string model;
        public double tuketim; 
        public double mesafe; 

        public Araba(string m, string md, double t, double msf)
        {
            marka = m;
            model = md;
            tuketim = t;
            mesafe = msf;
        }

        public double BenzinTuketimiHesapla()
        {
            return (tuketim * mesafe) / 100;
        }

        public void BilgiYazdir()
        {
            Console.WriteLine("Marka: " + marka + " Model: " + model + " Tüketim: " + tuketim + " Mesafe: " + mesafe + " km");
            Console.WriteLine("Benzin Tüketimi: " + BenzinTuketimiHesapla() + "L");
        }
    }
}
