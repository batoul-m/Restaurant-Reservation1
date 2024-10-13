using RestaurantReservation.Db;
namespace RestaurantReservation.Services.ResturantsServices
{
    public class ResturantCreate : IResturantCreate
    {
        void IResturantCreate.CreateResturant(RestaurantReservationDbContext context, Restaurants resturant)
        {
            context.Restaurants.Add(resturant);
            context.SaveChanges();
        }
    }
}