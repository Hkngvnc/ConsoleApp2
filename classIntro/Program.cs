using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace classIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string adi = "Hakan";
            int yas = 21;
            kurs kurs1=new kurs();//class değişkeni tanımlamak için bunu yapman lazım ve ozellikleri yani class ı kullanabilmek için yazmalısın
            kurs1.kursadı = "c#";
            kurs1.egitmen = "hakan guvenc";
            kurs1.izlenmeOranı = 68;

            kurs kurs2 = new kurs();
            kurs2.kursadı = "java";
            kurs2.egitmen = "kerem";
            kurs2.izlenmeOranı = 64;

            kurs kurs3 = new kurs();
            kurs3.kursadı = "python";
            kurs3.egitmen = "berkay";
            kurs3.izlenmeOranı = 80;


            kurs[] kurslar = new kurs[] { kurs1, kurs2, kurs3 };//array yani[] liste açar!!!
            foreach (var Kursa in kurslar)//ordaki kursa rastgele bir isimde olabilirdi.
            {
                Console.WriteLine(Kursa.kursadı + " : " + Kursa.egitmen);

            }



            Console.WriteLine("");
         
        }
  
   }

    class kurs//classlar özellik tanımlamaya yarar.
    {
        public string kursadı { get; set; }//prop yazıp iki kere tab yap bunun için
        public string egitmen { get; set; }
        public int izlenmeOranı { get; set; }



    }


}
