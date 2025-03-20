using HRSystem.Application.DTOs;
using HRSystem.Application.Queries;
using HRSystem.Application.Services;
using MediatR;

namespace HRSystem.API.GraphQl
{
    public class Query
    {
        public async Task<ProductDto> GetProductById(
           [Service] IMediator mediator,
           Guid id)
        {
            return await mediator.Send(new GetProductByIdQuery { Id = id });
        }
        public async Task<OrderDto> GetOrder(int id, [Service] IOrderService orderService)
        {
            return await orderService.GetOrderAsync(id);
        }
    }
}
