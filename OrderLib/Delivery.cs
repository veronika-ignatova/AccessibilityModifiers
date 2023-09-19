using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderLib
{
    public class Delivery
    {
        public int DeliveryId { get; set; }
        public string DeliveryName { get; set; }
        public DateTime DeliveryDate { get; set; } = DateTime.Now.AddDays(3);
    }
}
