namespace st10301625_ICE_Task_2.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public List<Product> Products { get; set; } = new List<Product>();
        public decimal TotalAmount => Products.Sum(p => p.Price);
    }
}
