 
namespace HRSystem.Application.DTOs
{
    public record OrderDto(int Id, int CustomerId, List<OrderItemDto> Items, decimal Total);

    public record OrderItemDto(int Id, string ProductName, decimal Price);
}
