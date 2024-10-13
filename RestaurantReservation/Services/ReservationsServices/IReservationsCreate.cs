using RestaurantReservation.Db;
namespace RestaurantReservation.Services.ReservationsServices
{
    public interface IReservationCreate
    {
        void CreateReservation(RestaurantReservationDbContext context,Reservation reservation);
    }
}