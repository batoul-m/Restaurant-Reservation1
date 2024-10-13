using RestaurantReservation.Db;
namespace RestaurantReservation.Services.OrdersServices
{
    public interface IOrderServiceCreate
    {
        void CreateOrder(RestaurantReservationDbContext context,Orders order);
    }
}