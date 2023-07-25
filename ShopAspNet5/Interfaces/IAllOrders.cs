using ShopAspNet5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopAspNet5.Interfaces
{
    public interface IAllOrders {

        void createOrder(Order order);

    }
}
