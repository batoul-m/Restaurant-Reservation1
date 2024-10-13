using RestaurantReservation.Db;
namespace RestaurantReservation.Services.CustomerServices
{
    public interface IUpdateCustomers
    {
        void UpdateCustomer(RestaurantReservationDbContext context,Customers customer);
    }
}
