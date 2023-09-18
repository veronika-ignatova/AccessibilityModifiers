using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderLib
{
    public class Item : ItemBase
    {
        protected override void AddingItem()
        {
            Console.WriteLine($"Item {Name} added.");
        }
    }
}
