using LMIS.SCM.Entities;
using LMIS.SCM.Repositories.Interface;

namespace LMIS.SCM.Repositories
{
    public class SupplierRepository : ISupplierRepository
    {
        private static List<Supplier> suppliers = new List<Supplier>();

        public Task SaveAsync(Supplier supplier)
        {
            suppliers.Add(supplier);
            Console.WriteLine($"Supplier {supplier.SupplierName} saved.");
            return Task.CompletedTask;
        }

        public Task<Supplier?> GetByIdAsync(string supplierID)
        {
            var supplier = suppliers.FirstOrDefault(s => s.SupplierID == supplierID);
            return Task.FromResult(supplier);
        }
    }
}
