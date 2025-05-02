namespace LMIS.SCM.Entities
{
    public class PurchaseOrderItem
    {
        public string PurchaseOrderItemID { get; set; } = Guid.NewGuid().ToString("N");
        public string PurchaseOrderID { get; set; }
        public string ProductID { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
