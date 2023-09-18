namespace OrderLib
{
    public abstract class OrderBase
    {
        public int OrderId {  get; set; }
        public int UserId { get; set; }
        public List<Item> ItemId {  get; set; }
        protected double Price 
        {
            get
            {
                return _price * _discount / 100;
            }
        }
        protected double _price;
        protected double _discount;
        protected abstract void CreatingOrder();
    }
}