using RestaurantReservation.Db;
namespace RestaurantReservation.Services.EmployeesServices
{
    public interface ICreateEmployee
    {
        void CreateEmployee(RestaurantReservationDbContext context,Employees employees);
    }
}
