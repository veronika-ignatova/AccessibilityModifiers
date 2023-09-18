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
        protected int ItemId { get; set; }
        protected string Name 
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
        protected string Description { get; set; }
        protected int Price
        {
            get
            {
                return _price;
            }
            set
            {
                _price = value;
            }
        }
        protected int Quantity { get; set; }
        protected abstract void AddingItem();

    }
}
