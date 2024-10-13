using RestaurantReservation.Db;
namespace RestaurantReservation.Services.ReservationsServices
{
    public class ReservationUpdate : IReservationUpdate
    {
        void UpdateReservation(RestaurantReservationDbContext context,Reservation reservation)
        {
            var existingReservation = context.Reservation.Find(reservation.ReservationId);
            if (existingReservation is not null)
            {
                existingReservation.ReservationId = reservation.ReservationId;
                existingReservation.CustomerId = reservation.CustomerId;
                existingReservation.RestaurantId = reservation.ResturantId;
                existingReservation.TablesId= reservation.TabelsId;
                existingReservation.PartySize = reservation.PartySize;

            }
        }
    }
}