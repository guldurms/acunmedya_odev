using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acunodev08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Araba> Liste = new List<Araba>()
            {
                new Araba { Marka = "Toyota", Model = "Corolla", YakitTuketimi = 6.5, ToplamMesafe = 5000 },
                new Araba { Marka = "BMW", Model = "X5", YakitTuketimi = 9.0, ToplamMesafe = 5000 },
                new Araba { Marka = "Mercedes", Model = "C200", YakitTuketimi = 8.2, ToplamMesafe = 5000 }
            };

            foreach (var araba in Liste)
            {
                double toplamTuketim = araba.YakitHesapla();
                Console.WriteLine($"Marka: {araba.Marka}, Model: {araba.Model}, 100 km'de Yakıt Tüketimi: {araba.YakitTuketimi} litre, Toplam Yakıt Tüketimi: {toplamTuketim} litre");
            }
        }
    }
}
