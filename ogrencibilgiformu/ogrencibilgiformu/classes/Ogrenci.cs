using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ogrencibilgiformu.classes
{
    public class Ogrenci
    {
        [Required("Öğrenci adı boş bırakılamaz!")]
        public string Ad { get; set; }

        [Required("Öğrenci soyadı boş bırakılamaz!")]
        public string Soyad { get; set; }

        [Required("Öğrenci bölümü boş bırakılamaz!")]
        public string Bolum { get; set; }
    }
}
