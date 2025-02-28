// See https://aka.ms/new-console-template for more information
using odev1.Classes;

Console.WriteLine("Hello, World!");

Araba ar = new Araba();
ar.marka = "BMW";
ar.vites = "Otomatik";

BMW b = new BMW();
b.vitesmarkayaz("BMW", "Otomatik vitestir.");

Audi a = new Audi();
a.vitesmarkayaz("Audi", "Duz vitestir.");

Porsche p = new Porsche();
p.vitesmarkayaz("Porsche", "Otomatik vitestir.");

Togg togg = new Togg();
togg.vitesmarkayaz("Togg", "Otomatik vitestir.");

Toyota t = new Toyota();
t.vitesmarkayaz("Toyota", "Duz vitestir.");

Mercedes m = new Mercedes();
m.vitesmarkayaz("Mercedes", "Otomatik vitestir.");
