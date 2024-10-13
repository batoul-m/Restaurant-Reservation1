using RestaurantReservation.Db;
namespace RestaurantReservation.Services.OrdersServices
{
    public interface IOrderServiceDelete
    {
        void DeleteOrder(RestaurantReservationDbContext context,int orderId);
    }
}