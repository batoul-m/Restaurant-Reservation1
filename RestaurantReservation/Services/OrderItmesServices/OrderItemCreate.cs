using RestaurantReservation.Db;
namespace RestaurantReservation.Services.OrderItemsServices
{
    public class OrderItemCreate : IOrderItemCreate
    {
        void IOrderItemCreate.CreateOrderItem(RestaurantReservationDbContext context, OrderItems item)
        {
            context.OrderItems.Add(item);
            context.SaveChanges();
        }
    }
}