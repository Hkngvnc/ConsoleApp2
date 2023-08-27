using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //birsey tanımlamak istiyorsak onune veri tipini giriyoruz pythona göre daha katı dil
            string kategoriEtiketi = "Kategori";
            int ogrenciSayısı = 32000;
            double faizOranı = 1.45;
            bool girisYapmısMi = true;
            double dolarDun = 7.35;
            double dolarBugun = 7.25;

                if (dolarDun > dolarBugun) 
            {
                Console.WriteLine("azalıs butonu");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("artıs butonu");
            }
            else
            {
                Console.WriteLine("degismedi butonu");
            }

            if (girisYapmısMi == true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");

            }
            else
            {
                Console.WriteLine("Giriş yap burtonu");    
            }
            


            Console.WriteLine(kategoriEtiketi);
            //do not repeat yourself
           
           
        }
    }
}
