using e_commerce_holisticfinal.DTOs;
using e_commerce_holisticfinal.Models;

namespace e_commerce_holisticfinal.Repositories.Customer
{
    public interface ICustomerRepo
    {
        public void AddCustomer(CustomerDTO dto);
        public CustomerGetDTO GetCustomer(int Id);
    }
}
