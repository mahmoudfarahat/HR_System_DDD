using HRSystem.Application.DTOs;
using HRSystem.Application.Services;

namespace HRSystem.API.GraphQl
{
    public class Query
    {
        public async Task<OrderDto> GetOrder(int id, [Service] IOrderService orderService)
        {
            return await orderService.GetOrderAsync(id);
        }
    }
}
