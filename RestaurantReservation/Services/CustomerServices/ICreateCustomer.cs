using RestaurantReservation.Db;
namespace RestaurantReservation.Services.CustomerServices
{
    public interface ICreateCustomer
    {
        void CreateCustomer(RestaurantReservationDbContext context,Customers customer);
    }
}
