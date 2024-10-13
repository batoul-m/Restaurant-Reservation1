using System.Collections.Generic;
using RestaurantReservation.Db;
namespace RestaurantReservation.Services.EmployeesServices
{
    public interface IEmployeeService
    {
        Task<List<Employees>> ListManagers();
        decimal CalculateAverageOrderAmount(int employeeId);
    }
}
