using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeBookkeeping.ORM.Entity
{
   public class PulVahidi
    {
        public int ID { get; set; }
        public string pulVahidAd { get; set; }
        public string pulVahidQisaAd { get; set; }
        public bool aktiv { get; set; }
    }
}
