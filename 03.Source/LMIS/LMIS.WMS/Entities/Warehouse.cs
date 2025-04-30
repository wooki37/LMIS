namespace LMIS.WMS.Entities
{
    public class Warehouse
    {
        public string WarehouseID { get; set; } = Guid.NewGuid().ToString("N");
        public string WarehouseName { get; set; }
        public string WarehouseAddress { get; set; }
    }
}
