using HRSystem.Application.DTOs;
using HRSystem.Domain;
using HRSystem.Domain.Entities;
using MediatR;
 
namespace HRSystem.Application.Commands
{
    public class CreateProductHandler : IRequestHandler<CreateProductCommand, ProductDto>
    {
        private readonly IProductRepository _repository;

        public CreateProductHandler(IProductRepository repository)
        {
            _repository = repository;
        }

        public async Task<ProductDto> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            var product = new Product(request.Name, request.Price);
            await _repository.AddAsync(product);
            return new ProductDto { Id = product.Id, Name = product.Name, Price = product.Price };
        }
    }
}
