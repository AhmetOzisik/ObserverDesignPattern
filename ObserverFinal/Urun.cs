using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverFinal
{
   public class Urun:IUrun
    {
       public List<Kullanci> TeklifVerenler = new List<Kullanci>();
        public Urun(string Name, decimal Fiyat) : base(Name, Fiyat) { }
       
        public void TeklifVer(Kullanci kullanıci,decimal Fiyat) {
               TeklifVerenler.Add(kullanıci);

            if (Fiyatt < Fiyat)
                {
                  Fiyatt = Fiyat;
                foreach (Kullanci kullancilar in TeklifVerenler)
                {
                    if(kullanıci!=kullancilar)
                    Console.WriteLine(kullancilar.AdSoyad +" "+"kisiye"+" "+Fiyatt+" "+"tl bilgisi gönderilmistir.");
                }
            }
                else
                {
                    Console.WriteLine("fiyat teklifif asağıdır.");
                }
            
            
           
           
        }
      
        
    }
}
