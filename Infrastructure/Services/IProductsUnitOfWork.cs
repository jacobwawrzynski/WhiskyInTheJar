using Infrastructure.Entities;

namespace Infrastructure.Services
{
    public interface IProductsUnitOfWork
    {
        Task Commit();
        void RollBack();
    }
}