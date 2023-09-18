using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderLib
{
    public abstract class ItemBase
    {
        protected string _name;
        protected string _description;
        protected int _price;
        public int ItemId { get; set; }
        public string Name 
        { 
            get 
            {
                return _name;
            } 
            set 
            {
                _name = value;
            } 
        }
        public string Description { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
        protected abstract void AddingItem();

    }
}
