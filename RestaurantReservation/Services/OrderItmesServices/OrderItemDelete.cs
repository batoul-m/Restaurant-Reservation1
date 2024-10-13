using RestaurantReservation.Db;
namespace RestaurantReservation.Services.OrderItemsServices
{
    public class OrderItemDelete : IOrderItemDelete
    {
        void IOrderItemDelete.DeleteOrderItem(RestaurantReservationDbContext context, int itemId)
        {
            var existingItem = context.OrderItems.Find(itemId);
            if (existingItem is not null)
            {
                context.OrderItems.Remove(existingItem);
                context.SaveChanges();
            }
        }
    }
}