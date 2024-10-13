using RestaurantReservation.Db;
namespace RestaurantReservation.Services.TabelsServices
{
    public interface ITableCreate
    {
        void CreateTable(RestaurantReservationDbContext context,Tabels tabel);
    }
}