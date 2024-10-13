using RestaurantReservation.Db;
namespace RestaurantReservation.Services.OrdersServices
{
    public class OrderCreate : IOrderServiceCreate
    {
        void IOrderServiceCreate.CreateOrder(RestaurantReservationDbContext context, Orders order)
        {
            context.Orders.Add(order);
            context.SaveChanges();
        }
    }
}