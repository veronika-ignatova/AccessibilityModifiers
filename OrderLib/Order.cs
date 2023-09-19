using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderLib
{
    public sealed class Order : OrderBase
    {
        public override void CreatingOrder(int price, int discount = 10)
        {
            _discount = discount;
            _price = price;
            Console.WriteLine($"Order added with discount {discount} and price {Price}");
        }
    }
}
