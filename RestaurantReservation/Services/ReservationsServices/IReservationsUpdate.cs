using RestaurantReservation.Db;
namespace RestaurantReservation.Services.ReservationsServices
{
    public interface IReservationUpdate
    {
        void UpdateReservation(RestaurantReservationDbContext context,Reservation reservation);
    }
}