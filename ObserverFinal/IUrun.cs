using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverFinal
{
    public abstract class IUrun
    {
        public string Name;
        public decimal Fiyatt;
       public IUrun(string Name,decimal Fiyat)
        {
            this.Name = Name;
            this.Fiyatt = Fiyat;
        }

    }
}
