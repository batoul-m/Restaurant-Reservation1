using RestaurantReservation.Db;

namespace RestaurantReservation.Services.OrdersServices
{
    public interface IOrderServices
    {
        Task<List<Orders>> ListOrdersAndMenuItems(int reservationId);
        Task<List<MenuItems>> ListOrderedMenuItems(int reservationId);
    }
}
