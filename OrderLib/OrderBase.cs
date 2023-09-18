namespace OrderLib
{
    public abstract class OrderBase : Item
    {
        protected int OrderId {  get; set; }
        protected int UserId { get; set; }
        protected string ItemName {  get; set; }
        protected int ItemPrice { get; set; }
        protected int _discount;
        protected abstract void CreatingOrder();
    }
}