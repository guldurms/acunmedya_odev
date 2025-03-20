// See https://aka.ms/new-console-template for more information


using acunmedyaodev2.odev1;
using acunmedyaodev2.odev2;

Kasa kasa = new Kasa("Sedan");
Kapı kapı = new Kapı(4);
Pencere pencere = new Pencere(4);
Fiyat fiyat = new Fiyat(2000000);
Marka marka = new Marka("BMW");
Model model = new Model("X5");
Araba araba = new Araba(kapı, kasa, marka, pencere, model, fiyat);
ArabaOzellik arabaOzellik = new ArabaOzellik(araba, "BMW", "X5", 4, "Sedan", 2000000, 4);
arabaOzellik.aracolustur();


Matematik mat = new Matematik();

// 2 ve 3 değer alan --> Toplama işlemleri
Console.WriteLine("Toplam (int, 2 değer): " + mat.Topla(7, 12));
Console.WriteLine("Toplam (int, 3 değer): " + mat.Topla(8, 14, 19));
Console.WriteLine("Toplam (double, 2 değer): " + mat.Topla(6.3, 11.7));
Console.WriteLine("Toplam (double, 3 değer): " + mat.Topla(4.1, 9.5, 2.8));

// 2 ve 3 değer alan --> Çarpma işlemleri
Console.WriteLine("Çarpım (int, 2 değer): " + mat.Carp(6, 9));
Console.WriteLine("Çarpım (int, 3 değer): " + mat.Carp(3, 7, 5));
Console.WriteLine("Çarpım (double, 2 değer): " + mat.Carp(4.2, 2.5));
Console.WriteLine("Çarpım (double, 3 değer): " + mat.Carp(3.3, 1.8, 2.2));
