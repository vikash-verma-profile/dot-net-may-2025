using EShoppingAPI.ViewModels;

namespace EShoppingAPI.interfaces
{
    public interface IOrder
    {
        public void SaveOrder(OrderModel order);
    }
}
