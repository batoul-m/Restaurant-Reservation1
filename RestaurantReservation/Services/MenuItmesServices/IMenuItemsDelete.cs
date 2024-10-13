using RestaurantReservation.Db;
namespace RestaurantReservation.Services.MenuItemsServices
{
    public interface IMenuItemsDelete
    {
        void DeleteItems(RestaurantReservationDbContext context,int ItemId);
    }
}
