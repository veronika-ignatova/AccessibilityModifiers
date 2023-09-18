using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderLib
{
    public class Order : OrderBase
    {
        protected override void CreatingOrder()
        {
            Console.WriteLine($"Order added with {ItemName}");
        }
    }
}
