using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Session
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Duration { get; set; }
        public decimal Donation { get; set; }
        public DateTime TaxiDate { get; set; }
    }
}
