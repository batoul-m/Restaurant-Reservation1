using RestaurantReservation.Db;
namespace RestaurantReservation.Services.OrderItemsServices
{
    public interface IOrderItemDelete
    {
        void DeleteOrderItem (RestaurantReservationDbContext context, int itemId);
    }
}