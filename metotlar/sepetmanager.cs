using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metotlar
{
    internal class sepetmanager
    {
        public void Ekle(urun uruntıpı)//mantığını matematik sayfasında anlayabilirsin
        {

            Console.WriteLine("tebrikler.sepete eklendi : " + uruntıpı.adı);

       }

        public void Ekle2(string urunadi, string aciklama, double fiyat)//bu gereksiz bir yazımdır eğer üstteki gibi yazarsak zaten urun classının içinde hepsi var.
        {
            Console.WriteLine("tebrikler.sepete eklendi : " + urunadi);
            //cinsleri tek tek yazmak sorunda kalıcaz ve efektif değil


        }


    }
}
