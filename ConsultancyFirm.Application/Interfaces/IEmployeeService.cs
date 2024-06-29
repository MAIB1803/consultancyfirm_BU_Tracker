using System.Collections.Generic;
using System.Threading.Tasks;
using ConsultancyFirm.Domain.Entities;

namespace ConsultancyFirm.Application.Interfaces
{
    public interface IEmployeeService
    {
        Task<IEnumerable<Employee>> GetAllEmployees();
        Task<Employee> GetEmployeeById(int id);
        Task AddEmployee(Employee employee);
        Task UpdateEmployee(Employee employee);
        Task DeleteEmployee(int id);
    }
}
