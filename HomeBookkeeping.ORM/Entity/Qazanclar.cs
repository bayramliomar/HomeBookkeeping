using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeBookkeeping.ORM.Entity
{
   public class Qazanclar
    {
        public Qazanclar()
        {
            aktiv = true;
        }
        public int ID { get; set; }
        public DateTime qazancTarix { get; set; }
        public decimal qazancMebleg { get; set; }
        public int hesabid { get; set; }
        public int kateqoriyaid { get; set; }
        public Nullable< int> altKateqoriyaid { get; set; }
        public int pulVahidiid { get; set; }
        public Nullable <int> olcuVahidiid { get; set; }
        public double miqdar { get; set; }
        public string qeyd { get; set; }
        public bool aktiv { get; set; }
    }
}
