using LMIS.SCM.Entities;

namespace LMIS.SCM.Repositories.Interface
{
    public interface ISupplierRepository
    {
        Task SaveAsync(Supplier supplier);
        Task<Supplier?> GetByIdAsync(string supplierID);
    }
}
