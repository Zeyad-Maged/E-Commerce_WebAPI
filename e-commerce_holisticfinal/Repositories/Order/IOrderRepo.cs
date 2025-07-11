using e_commerce_holisticfinal.DTOs;

namespace e_commerce_holisticfinal.Repositories.Order
{
    public interface IOrderRepo
    {
        public List<OrderGetDTO> GetAllOrders();
        public void AddOrder(OrderCustomerProductDTO dto);
        public bool UpdateOrder(OrderProductDTO dto, int OrderId);
        public bool DeleteOrder(int id);
    }
}
