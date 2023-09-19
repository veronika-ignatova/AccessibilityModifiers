namespace OrderLib
{
    public abstract class OrderBase
    {
        protected double _price;
        protected double _discount;
        public int OrderId {  get; set; }
        public DateTime UserBirthDate { get; set; }
        //public IUser customer { get; set; }
        public int UserId { get; set; }
        public int DeliveryId { get; set; }
        public List<Item> ItemId {  get; set; }
        public double Discount
        {
            get
            {
                int day = DateTime.Now.Day;
                int month = DateTime.Now.Month;
                int userDay = UserBirthDate.Day;
                int userMonth = UserBirthDate.Month;
                if (day == userDay && month == userMonth)
                {
                    _discount = 25;
                }
                return _discount;
            }
            //set
            //{
            //    int day = DateTime.Now.Day;
            //    int month = DateTime.Now.Month;
            //    int userDay = UserBirthDate.Day;
            //    int userMonth = UserBirthDate.Month;
            //    if (day == userDay && month == userMonth)
            //    {
            //        _discount = 25;
            //    }
            //}
        }
        public double Price 
        {
            get
            {
                return _price * (100 - _discount) / 100;
            }
        }
        public abstract void CreatingOrder(int Price, int Discount);
    }
}