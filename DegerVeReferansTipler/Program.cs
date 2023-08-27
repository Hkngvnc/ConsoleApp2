using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DegerVeReferansTipler
{
    internal class Program
    {//ınt,decimal,float, double,bool değer tiptir
        //array,class,interface referans tiptir farkı değer tipte değeri atar referansta adresi atama yapar.altta örnekli array(dizi)
        static void Main(string[] args)
        {
            int sayı1 = 10;
            int sayı2 = 30;
            sayı1 = sayı2;
            sayı2 = 65;
            //sayı1??? 30
            int[] sayılar1 = new int[] { 10, 20, 30 };
            int[] sayılar2 = new int[] { 100, 200, 300 };
            sayılar1 = sayılar2;
            sayılar2[0] = 999;
            //sayılar1[0]??? 999



        }
    }
}
