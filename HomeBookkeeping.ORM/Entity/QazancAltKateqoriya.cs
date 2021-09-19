using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeBookkeeping.ORM.Entity
{
   public class QazancAltKateqoriya
    {
        public int ID { get; set; }
        public string altQazancKateqoriyaAdi { get; set; }
        public int qazancKateqoriyaid { get; set; }
        public bool aktiv { get; set; }
    }
}
