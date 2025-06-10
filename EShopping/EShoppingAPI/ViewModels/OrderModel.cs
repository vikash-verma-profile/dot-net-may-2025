namespace EShoppingAPI.ViewModels
{
    public class OrderModel
    {
        public List<Product> Products { get; set; }
        public decimal Discount { get; set; }
        public int UserId { get;set; }
    }
    public class Product
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
    }

}
