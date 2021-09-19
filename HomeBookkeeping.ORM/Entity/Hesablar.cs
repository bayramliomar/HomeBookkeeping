using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeBookkeeping.ORM.Entity
{
   public class Hesablar
    {
        public Hesablar()
        {
            aktiv = true;
            show = false;
        }
        public int ID { get; set; }
        public string hesabAdi { get; set; }
        public decimal hesabMebleg { get; set; }
        public int istifadeciid { get; set; }
        public DateTime hesabTarix { get; set; }
        public string qeyd { get; set; }
        public bool aktiv { get; set; }
        public bool show { get; set; }
    }
}
