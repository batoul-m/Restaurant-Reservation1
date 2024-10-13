using RestaurantReservation.Db;
namespace RestaurantReservation.Services.ResturantsServices
{
    public interface IResturantUpdate
    {
        void UpdateResturant(RestaurantReservationDbContext context,Restaurants resturant);
    }
}