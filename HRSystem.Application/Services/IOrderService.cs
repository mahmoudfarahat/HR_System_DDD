using HRSystem.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.Application.Services
{
    public interface IOrderService
    {
        Task<OrderDto> GetOrderAsync(int id);
        Task<OrderDto> CreateOrderAsync(int customerId, List<OrderItemInput> items);
    }
}
