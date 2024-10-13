using RestaurantReservation.Db;
namespace RestaurantReservation.Services.OrdersServices
{
    public interface IOrderServiceUpdate
    {
        void UpdateOrder(RestaurantReservationDbContext context,Orders order);
    }
}