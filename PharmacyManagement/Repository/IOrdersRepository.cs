using PharmacyManagement.Models;
using System.Collections.Generic;

namespace pharmacyManagement.Repository
{
    public interface IOrdersRepostiory
    {
        IEnumerable<Order> GetAll();
        Order Create(Order order);

        IEnumerable<Order> GetOrders(int id);
    }
}