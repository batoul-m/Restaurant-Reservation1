using RestaurantReservation.Db;
namespace RestaurantReservation.Services.MenuItemsServices
{
    public interface IMenuItemsCreate
    {
        void CreateItems(RestaurantReservationDbContext context,MenuItems menuItem);
    }
}
