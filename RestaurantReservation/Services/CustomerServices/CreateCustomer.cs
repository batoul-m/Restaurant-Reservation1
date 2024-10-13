using RestaurantReservation.Db;
namespace RestaurantReservation.Services.CustomerServices
{
    public class CreateCustomer : ICreateCustomer
    {
        void ICreateCustomer.CreateCustomer(RestaurantReservationDbContext context, Customers customer)
        {
            context.Customers.Add(customer);
            context.SaveChanges();
        }
    }
}
