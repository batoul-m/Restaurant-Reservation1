using RestaurantReservation.Db;
namespace RestaurantReservation.Services.CustomerServices
{
    public interface IDeleteCustomer
    {
        void DeleteCustomer(RestaurantReservationDbContext context,int customerId);
    }
}
