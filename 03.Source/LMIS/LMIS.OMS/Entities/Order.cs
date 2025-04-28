namespace LMIS.OMS.Entities
{
    public class Order
    {
        public string OrderID { get; set; } = Guid.NewGuid().ToString("N");
        public string CustomerID { get; set; } = Guid.NewGuid().ToString("N");
        public DateTime OrderDate { get; set; } = DateTime.UtcNow;
        public string OrderStatus { get; set; } = "Pending"; // Pending, Completed, Cancelled
        public string OrderType { get; set; } = "Standard"; // Standard, Express
        public decimal TotalAmount { get; set; } = 0.0m;
    }
}
