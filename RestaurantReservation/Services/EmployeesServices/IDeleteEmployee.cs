using RestaurantReservation.Db;
namespace RestaurantReservation.Services.EmployeesServices
{
    public interface IDeleteEmployee
    {
        void DeleteEmployee(RestaurantReservationDbContext context,int employeeId);
    }
}
