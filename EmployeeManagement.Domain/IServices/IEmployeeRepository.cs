using EmployeeManagement.Domain.Entities;

namespace EmployeeManagement.Domain.IServices
{
    public interface IEmployeeRepository
    {
        Task<List<Employee>> GetAll();
        Task<Employee> GetById(int id);
        Task Create(Employee employee);
        Task Update(Employee employee);
        Task Delete(int id);
    }
}
