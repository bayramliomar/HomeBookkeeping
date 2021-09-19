using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeBookkeeping.ORM.Entity
{
   public class Xercler
    {
        public Xercler()
        {
            aktiv = true;
        }
        public int ID { get; set; }
        public DateTime xercTarix { get; set; }
        public decimal xercMebleg { get; set; }
        public int hesabid { get; set; }
        public int kateqoriyaid { get; set; }
        public Nullable<int> altKateqoriyaid { get; set; }
        public int pulVahidiid { get; set; }
        public Nullable<int> olcuVahidiid { get; set; }
        public float endirim { get; set; }
        public double miqdar { get; set; }
        public string qeyd { get; set; }
        public bool aktiv { get; set; }
    }
}
