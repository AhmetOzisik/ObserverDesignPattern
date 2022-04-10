using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverFinal
{
    class Program
    {
        static void Main(string[] args)
        {
            Kullanci kullanci = new Kullanci();
            kullanci.AdSoyad = "Ahmet Ozisik";
            kullanci.EMail = "a@a.com";
            Kullanci kullanci1 = new Kullanci();
            kullanci1.AdSoyad = "Bilal İyisoy";
            kullanci1.EMail = "b@b.com";
            Urun urun = new Urun("Bilgisayar", 1000);
            urun.TeklifVer(kullanci, 1200);
            urun.TeklifVer(kullanci1, 1500);
            urun.TeklifVer(kullanci, 2000);
            Console.ReadLine(); 
        }
    }
}
