using RestaurantReservation.Db;
namespace RestaurantReservation.Services.OrderItemsServices
{
    public interface IOrderItemUpdate
    {
        void UpdateOrderItem (RestaurantReservationDbContext context, OrderItems item);
    }
}