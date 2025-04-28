namespace LMIS.OMS.Entities
{
    public class Customer
    {
        public string CustomerID { get; set; } = Guid.NewGuid().ToString("N");
        public string CustomerName { get; set; } = string.Empty;
        public string CustomerEmail { get; set; } = string.Empty;
        public string CustomerPhone { get; set; } = string.Empty;
        public string CustomerAddress { get; set; } = string.Empty;
    }
}
