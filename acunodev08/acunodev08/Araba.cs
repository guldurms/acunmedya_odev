using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace acunodev08
{
    public class Araba
    {
        public string Marka { get; set; }               
        public string Model { get; set; }               
        public double YakitTuketimi { get; set; }     
        public double ToplamMesafe { get; set; }    

        public double YakitHesapla()
        {
            return (ToplamMesafe / 100) * YakitTuketimi;
        }
    }
}
