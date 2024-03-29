using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ordering.Domain.Entities;

namespace Ordering.Application.Contracts.Persistance
{
    public interface IOrderRepository : IAsyncRepository<Order>
    {
        Task<IEnumerable<Order>> GetOrdersByUserName(string userName);
    }
}
