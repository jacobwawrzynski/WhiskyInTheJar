using Infrastructure.Entities;

namespace Infrastructure.Services
{
    public interface IProductsTransaction
    {
        void Commit();
        void RollBack();
    }
}