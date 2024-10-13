using RestaurantReservation.Db;
namespace RestaurantReservation.Services.OrderItemsServices
{
    public interface IOrderItemCreate
    {
        void CreateOrderItem (RestaurantReservationDbContext context, OrderItems item);
    }
}