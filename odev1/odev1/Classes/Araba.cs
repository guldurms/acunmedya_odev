using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev1.Classes
{
    public class Araba
    {
        public string vites;
        public string duz;
        public string otomatik;
        public string marka;
        
        public void vitesmarkayaz(string marka, string vites)
        {
            Console.WriteLine("Arabanın markası : " + marka + "\nVites turu : " + vites);
        }
    }
}
