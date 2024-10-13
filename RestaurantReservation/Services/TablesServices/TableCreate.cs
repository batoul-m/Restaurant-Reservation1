using RestaurantReservation.Db;
namespace RestaurantReservation.Services.TabelsServices
{
    public class TableCreate : ITableCreate
    {
        void ITableCreate.CreateTable(RestaurantReservationDbContext context, Tabels tabel)
        {
            context.Tabels.Add(tabel);
            context.SaveChanges();
        }
    }
}