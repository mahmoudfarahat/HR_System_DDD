namespace HRSystem.API.GraphQl
{
    public record CreateOrderInput(int CustomerId, List<OrderItemInput> Items);
}
