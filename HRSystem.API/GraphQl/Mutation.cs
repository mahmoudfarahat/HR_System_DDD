using HRSystem.Application.DTOs;
using HRSystem.Application.Services;

namespace HRSystem.API.GraphQl
{
    public class Mutation
    {
        public async Task<OrderDto> CreateOrder(CreateOrderInput input, [Service] IOrderService orderService)
        {
            return await orderService.CreateOrderAsync(input.CustomerId, input.Items);
        }
    }
}
