using RestaurantReservation.Db;
namespace RestaurantReservation.Services.ReservationsServices
{
    public class ReservationCreate :  IReservationCreate
    {
        void IReservationCreate.CreateReservation(RestaurantReservationDbContext context, Reservation reservation)
        {
            context.Reservations.Add(reservation);
            context.SaveChanges();
        }
    }
}