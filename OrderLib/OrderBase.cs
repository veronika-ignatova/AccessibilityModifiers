namespace OrderLib
{
    public abstract class OrderBase
    {
        protected int OrderId {  get; set; }
        protected int UserId { get; set; }
        protected string ItemId {  get; set; }
        protected double Price 
        {
            get
            {
                return _price;
            }
            set
            {
                _price = _price * _discount / 100;
            }
        }
        protected double _price;
        protected double _discount;
        protected abstract void CreatingOrder();
    }
}