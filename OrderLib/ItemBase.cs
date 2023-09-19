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
        public int CategoryId { get; set; }
        public int DeliveryId { get; set; }
        public string Name 
        { 
            get 
            {
                return _name;
            }
        }
        public string Description
        {
            get
            {
                return _description;
            }
        }
        public int Price
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
        public double Discount {  get; set; }
        public int Quantity { get; set; }
        public abstract void AddingItem(string name);

    }
}
