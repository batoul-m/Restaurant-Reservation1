using RestaurantReservation.Db;
namespace RestaurantReservation.Services.MenuItemsServices
{
    public interface IMenuItemsUpdate
    {
        void UpdateItems(RestaurantReservationDbContext context,MenuItems menuItem);
    }
}
