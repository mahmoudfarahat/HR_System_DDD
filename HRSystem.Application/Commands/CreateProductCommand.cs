using HRSystem.Application.DTOs;
using MediatR;
 
namespace HRSystem.Application.Commands
{
    public class CreateProductCommand : IRequest<ProductDto>
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
