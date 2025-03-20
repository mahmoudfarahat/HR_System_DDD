using HRSystem.Application.DTOs;

namespace HRSystem.API.GraphQl
{
    public class OrderType : ObjectType<OrderDto>
    {
        protected override void Configure(IObjectTypeDescriptor<OrderDto> descriptor)
        {
            descriptor.Field(o => o.Id).Type<IdType>();
            descriptor.Field(o => o.CustomerId).Type<IntType>();
            descriptor.Field(o => o.Items).Type<ListType<ObjectType<OrderItemDto>>>();
            descriptor.Field(o => o.Total).Type<DecimalType>();
        }
    }
}
