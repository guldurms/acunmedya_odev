// See https://aka.ms/new-console-template for more information
using ConsoleApp1.Classes;
using Maashesaplama.YakitHesaplama;


GenelMudur gm  = new GenelMudur();
Mudur m = new Mudur();
Programci p  = new Programci();
Stajyer s = new Stajyer();
double toplamMaas = 0.0;
toplamMaas += gm.maasinizNedir();
toplamMaas += m.maasinizNedir();
toplamMaas += p.maasinizNedir();
toplamMaas += s.maasinizNedir();

Console.WriteLine("Toplam : " + toplamMaas + "TL maas aliyorlar ");

BMW b = new BMW();
Mercedes me = new Mercedes();
Porsche por = new Porsche();
double toplamyakit = 0.0;
toplamyakit += b.Yakıtmiktarı();
toplamyakit += me.Yakıtmiktarı();
toplamyakit += por.Yakıtmiktarı();
Console.WriteLine("Toplam : "+ toplamyakit + "L yakit harcanmistir...");
