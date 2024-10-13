using RestaurantReservation.Db;
namespace RestaurantReservation.Services.ResturantsServices
{
    public interface IResturantCreate
    {
        void CreateResturant(RestaurantReservationDbContext context,Restaurants resturant);
    }
}