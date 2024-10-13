using RestaurantReservation.Db;
namespace RestaurantReservation.Services.ResturantsServices
{
    public interface IResturantDelete
    {
        void DeleteResturant(RestaurantReservationDbContext context,int resturantID);
    }
}