using LMIS.OMS.Entities;

namespace LMIS.OMS.Repositories.Interface
{
    public interface IOrdersRepository
    {
        Task SaveAsync(Order order);
    }
}
