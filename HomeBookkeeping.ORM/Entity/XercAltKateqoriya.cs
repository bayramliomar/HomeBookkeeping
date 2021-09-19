using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeBookkeeping.ORM.Entity
{
    public class XercAltKateqoriya
    {
        public int ID { get; set; }
        public string altXercKateqoriyaAdi { get; set; }
        public int xercKateqoriyaid { get; set; }
        public bool  aktiv { get; set; }
    }
}
