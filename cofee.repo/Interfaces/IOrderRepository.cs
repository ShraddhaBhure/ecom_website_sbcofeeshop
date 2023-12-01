using cofee.models;

namespace cofee.repo.Interfaces
{
    public interface IOrderRepository
    {
        void PlaceOrder(Order order);
    }
}
