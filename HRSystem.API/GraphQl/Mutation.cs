using HRSystem.Application.Commands;
using HRSystem.Application.DTOs;
using HRSystem.Application.Services;
using MediatR;

namespace HRSystem.API.GraphQl
{
    public class Mutation
    {
        public async Task<ProductDto> CreateProduct(
           [Service] IMediator mediator,
           CreateProductCommand command)
        {
            return await mediator.Send(command);
        }

        public async Task<EmployeeDto> CreateEmployee([Service] IMediator mediator, CreateEmployeeCommand createEmployeeCommand) 
        {
            return await mediator.Send(createEmployeeCommand);
        }



        public async Task<OrderDto> CreateOrder(CreateOrderInput input, [Service] IOrderService orderService)
        {
            return await orderService.CreateOrderAsync(input.CustomerId, input.Items);
        }
    }
}
