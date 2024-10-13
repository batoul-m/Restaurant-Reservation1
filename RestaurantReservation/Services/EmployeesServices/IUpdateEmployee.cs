using RestaurantReservation.Db;
namespace RestaurantReservation.Services.EmployeesServices
{
    public interface IUpdateEmployee
    {
        void UpdateEmployee(RestaurantReservationDbContext context,Employees employee);
    }
}
