using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odevacun
{

    //ödev 1 yas durum çıktısı
    public class Program
    {
        public static string Yasdurum(int yas)
        {
            if (yas < 0 || yas > 99)
            {
                return "Ya hiç doğmadınız ya da çoktan öldünüz...";
            }
            else if (yas < 18)
            {
                return "Küçüksünüz";
            }
            else if (yas < 35)
            {
                return "Gençsiniz";
            }
            else if (yas < 55)
            {
                return "Yetişkinsiniz";
            }
            else if (yas < 75)
            {
                return "Yaşlısınız";
            }
            else

                return "Çok yaşlısınız";
        }
        public static void Main(string[] args)
        {
            //yas durumu
            Console.Write("Lütfen yaşınızı giriniz: ");
            int yas;
            yas = Convert.ToInt32(Console.ReadLine());
            string sonuc;
            sonuc = Yasdurum(yas);
            Console.WriteLine(sonuc);


            //arabadurumu
            Console.Write("Lütfen arabanızın yaşını giriniz: ");
            int yas1;
            yas1 = Convert.ToInt32(Console.ReadLine());
            string sonuc1;
            sonuc1 = ArabaDurumu(yas1);
            Console.WriteLine(sonuc1);


            //calısan listeleme
            Calısan[] calisanlar = new Calısan[4];

            calisanlar[0] = new Calısan("Ali", "Yılmaz", "Genel Müdür", 150000, "Yönetim");
            calisanlar[1] = new Calısan("Hakan", "Kaya", "Müdür", 50000, "Pazarlama");
            calisanlar[2] = new Calısan("Taner", "Demir", "Programcı", 15000, "Yazılım");
            calisanlar[3] = new Calısan("Zehra", "Doğru", "Stajyer", 7000, "İnsan Kaynakları");

            decimal toplamMaas = 0;

            for (int i = 0; i < calisanlar.Length; i++)
            {
                calisanlar[i].BilgiYazdir();
                toplamMaas += calisanlar[i].Maas;
            }

            Console.WriteLine("Toplam Maaş: " + toplamMaas);

            //araba benzin tüketimi

            Araba[] arabalar = new Araba[3];

            arabalar[0] = new Araba("Toyota", "Corolla", 6.0, 150);
            arabalar[1] = new Araba("Honda", "Civic", 10.0, 200);
            arabalar[2] = new Araba("Ford", "Focus", 8.0, 250);

            double toplamTuketim = 0;

            for (int i = 0; i < arabalar.Length; i++)
            {
                arabalar[i].BilgiYazdir();
                toplamTuketim += arabalar[i].BenzinTuketimiHesapla();
            }

            Console.WriteLine("Toplam Benzin Tüketimi: " + toplamTuketim + " L");

        }

        //Araba yas durumu
        public static string ArabaDurumu(int yas)
        {
            if (yas < 0 || yas > 30)
            {
                return "Ya hiç üretilmedi ya da trafikten men edilmiştir";
            }
            else if (yas < 10)
            {
                return "Arabanız yeni";
            }
            else if (yas < 20)
            {
                return "Servise götürmeniz gerekebilir";
            }
            else
            {
                return "Arabanız hurdaya çıkabilir";
            }
        }
       




    }
}
