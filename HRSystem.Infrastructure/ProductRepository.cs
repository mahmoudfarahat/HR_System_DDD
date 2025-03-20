using HRSystem.Domain.Entities;
using HRSystem.Domain;
using HRSystem.Infrastructure.Data;

namespace HRSystem.Infrastructure
{
    public class ProductRepository : IProductRepository
    {
        private readonly OrderDbContext _context;

        public ProductRepository(OrderDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Product product)
        {
            await _context.Products.AddAsync(product);
            await _context.SaveChangesAsync();
        }

        public async Task<Product> GetByIdAsync(Guid id)
        {
            return await _context.Products.FindAsync(id); // Return the domain entity
        }
    }
}
