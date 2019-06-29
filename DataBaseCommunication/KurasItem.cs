using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseCommunication
{
    class KurasItem
    {

        public String Type { get; set; }
        public String Price { get; set; }

        public String Date { get; set; }
        public void KurasSet(String type, String price, String date)
        {
            this.Type = type;
            this.Price = price;
            this.Date = date;
        }

    }
}
