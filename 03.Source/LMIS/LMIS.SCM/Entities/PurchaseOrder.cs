namespace LMIS.SCM.Entities
{
    public class PurchaseOrder
    {
        public string PurchaseOrderID { get; set; } = Guid.NewGuid().ToString("N");
        public string SupplierID { get; set; }
        public DateTime OrderDate { get; set; } = DateTime.UtcNow;
        public DateTime ExpectedDelivery { get; set; }
        public decimal TotalAmount { get; set; }
        public List<PurchaseOrderItem> PurchaseOrderItems { get; set; } = new List<PurchaseOrderItem>();

    }
}
