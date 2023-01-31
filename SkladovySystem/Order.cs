using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkladovySystem
{
    public class Order
    {

        public int id { get; set; }
        public string vorname { get; set; }
        public string surname { get; set; }
        public string code { get; set; }
        public string street { get; set; }
        public string city { get; set; }
        public string country { get; set; }
        public List<Stock> neededProducts { get; set; }
        public List<Stock> doneProducts { get; set; }
        public string worker { get; set; }


    }
}
