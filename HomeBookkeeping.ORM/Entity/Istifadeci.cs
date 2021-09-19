using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeBookkeeping.ORM.Entity
{
   public class Istifadeci
    {
        public Istifadeci()
        {
            aktiv = true;
        }
        public int ID { get; set; }
        public string istifadeciAd { get; set; }
        public string sifre { get; set; }
        public bool aktiv { get; set; }
    }
}
