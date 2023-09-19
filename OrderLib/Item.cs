using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderLib
{
    public sealed class Item : ItemBase
    {
        public override void AddingItem(string name)
        {
            _name = name;
            Console.WriteLine($"Item {Name} added.");
        }
    }
}
