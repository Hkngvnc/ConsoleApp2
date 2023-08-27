using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donguler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "yazılım geliştirici yetiştirme kampı";
            string kurs2 = "programlamaya giriş için temel kurs";
            string kurs3 = "Java";

            //ARRAY DİZİ
            string[] kurslar = new string[] {"yazılım geliştirici yetiştirme kampı" ,"programlamaya giriş için temel kurs" ,"Java","python"};
            



            for (int i = 0; i<kurslar.Length; i++)//i+=2 şeklindede yazabiliriz
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("for bitti");
            foreach (string kurs in kurslar) //dizileri bu şekildede yazabiliriz
            {
                Console.WriteLine(kurs);
            }


            Console.WriteLine("sayfa sonu");
        
        
        
        }

    }
}
