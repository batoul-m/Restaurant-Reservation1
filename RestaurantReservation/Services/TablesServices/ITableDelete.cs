using RestaurantReservation.Db;
namespace RestaurantReservation.Services.TabelsServices
{
    public interface ITableDelete
    {
        void DeleteTable(RestaurantReservationDbContext context,int tabelId);
    }
}