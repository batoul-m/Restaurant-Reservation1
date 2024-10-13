using RestaurantReservation.Db;
namespace RestaurantReservation.Services.TabelsServices
{
    public interface ITableUpdate
    {
        void UpdateTable(RestaurantReservationDbContext context,Tabels tabel);
    }
}