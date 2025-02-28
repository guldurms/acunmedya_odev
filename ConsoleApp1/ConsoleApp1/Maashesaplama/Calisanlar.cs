using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Classes
{
    //1. abstract class ların nesnesi oluşturulamaz
    //2. kendisinden türeyen classları eğer abstract class içinde normal metodların dışında
    //abstract keyword ile tanımlanmış bir metod varsa o metodu yazmak zorundadırlar.
    public abstract class Calisan
    {

        public abstract double maasinizNedir();

        public void mesaiyeBasla(string isim)
        {
            Console.WriteLine(isim + " mesaiye başladı");
        }
    }
}
