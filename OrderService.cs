using Moq;
using System;
using System.Collections.Generic;
using System.Text;

namespace Testy2
{
    public class OrderService
    {
        private readonly IStorage _storage;

        public OrderService(IStorage storage)
        {
            _storage = storage;
        }
        public int PlaceOrder(Order order)
        {
            try
            {
                var orderId = _storage.Store(order);
                return orderId *3;
            }
            catch (ArgumentNullException)
            {
                return -1;
            }
            // Some other work
        }
    }
    public class Order
    {
    }
    public interface IStorage
    {
        int Store(Order order);
        Order Exists(int id);
    }
}
