using LMIS.Shared.Models.SCM.DTO.Request;

namespace LMIS.SCM.Services.Interface
{
    public interface ISupplierService
    {
        Task<string> CreateAsync(CreateSupplierRequest request);
    }
}
