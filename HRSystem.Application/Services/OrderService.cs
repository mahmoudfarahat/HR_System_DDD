using HRSystem.Application.DTOs;
using HRSystem.Domain.Entities;
using HRSystem.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
 

namespace HRSystem.Application.Services
{
    public class OrderService : IOrderService
    {
        private readonly OrderDbContext _context;

        public OrderService(OrderDbContext context)
        {
            _context = context;
        }

        public async Task<OrderDto> GetOrderAsync(int id)
        {
            var order = await _context.Orders
                .Include(o => o.Items)
                .FirstOrDefaultAsync(o => o.Id == id);

            if (order == null) throw new Exception("Order not found");

            return new OrderDto(
                order.Id,
                order.CustomerId,
                order.Items.Select(i => new OrderItemDto(i.Id, i.ProductName, i.Price.Value)).ToList(),
                order.Total.Value
            );
        }

        public async Task<OrderDto> CreateOrderAsync(int customerId, List<OrderItemInput> items)
        {
            var order = new Order(customerId);
            foreach (var (productName, price) in items)
            {
                order.AddItem(new OrderItem(productName, Money.FromDecimal(price)));
            }

            _context.Orders.Add(order);
            await _context.SaveChangesAsync();

            return new OrderDto(
                order.Id,
                order.CustomerId,
                order.Items.Select(i => new OrderItemDto(i.Id, i.ProductName, i.Price.Value)).ToList(),
                order.Total.Value
            );
        }
    }
}
public record OrderItemInput(string ProductName, decimal Price); // Moved here for simplicity