using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asset_Tracking_Database
{
    internal class Computer
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string MdelName { get; set; }
        public decimal Price { get; set; }
        public string Office { get; set; }
        public string Currency { get; set; }
        public List<Mobile> MobileList { get; set; } //List will hold the info about Mobile

    }
}
