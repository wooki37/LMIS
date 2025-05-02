using LMIS.SCM.Entities;
using LMIS.SCM.Repositories.Interface;
using LMIS.SCM.Services.Interface;
using LMIS.Shared.Models.SCM.DTO.Request;

namespace LMIS.SCM.Services
{
    public class SupplierService : ISupplierService
    {
        private readonly ISupplierRepository _repository;
        public SupplierService(ISupplierRepository repository)
        {
            _repository = repository;
        }
        public async Task<string> CreateAsync(CreateSupplierRequest request)
        {
            var supplier = new Supplier
            {
                SupplierID = Guid.NewGuid().ToString("N"),
                SupplierName = request.SupplierName,
                SupplierEmail = request.SupplierEmail,
                SupplierContact = request.SupplierContact,
                SupplierAddress = request.SupplierAddress,
            };
            await _repository.SaveAsync(supplier);

            return supplier.SupplierID;
        }
    }
}
