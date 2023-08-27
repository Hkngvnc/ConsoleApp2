using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string urunadı = "elma";
            double fiyatı = 15;
            string aciklama = "amasya elması";


            urun urun1 = new urun();//urun classını kullanmak için yaptık
            urun1.adı = "elma";
            urun1.fiyatı = 15;
            urun1.acıklama = "amasya elması";

            urun urun2 = new urun();
            urun2.adı = "karpuz";
            urun2.fiyatı = 80;
            urun2.acıklama = "diyarbakır karpuzu";

            urun[] urunler =new urun[] { urun1, urun2 }; //dizi oluşturduk
            foreach (var uruna in urunler)//uruna yerine istediğini yazabilirsin ama başında var olarak kalsada olur o onu yakalar zaten
            {
                Console.WriteLine(uruna.adı);
                Console.WriteLine(uruna.fiyatı);
                Console.WriteLine(uruna.acıklama);
                Console.WriteLine("---------------");//urunler arasına çizgi çekti çünkü foreach tek tek her elemanı tekrar döner

            }

            Console.WriteLine("--------metotlar-------");

                //instance-örnek
                 
              sepetmanager sepetmanagera = new sepetmanager();

            //encapsulation
            sepetmanagera.Ekle(urun1);
            sepetmanagera.Ekle(urun2);
           
            sepetmanagera.Ekle2("armut", "yeşil armut", 12);//tek tek yazmak gereksiz sepetmanager classından bak
            sepetmanagera.Ekle2("elma", "yeşil armut", 12);
            sepetmanagera.Ekle2("karpuz", "yeşil armut", 12);

       
        
        }
        

    }
}




//metotlar tekrar tekrar kullanılabilmeyi sağlar.