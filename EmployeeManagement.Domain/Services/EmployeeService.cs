
using EmployeeManagement.Domain.IServices;
using EmployeeManagement.Domain.Entities;

namespace EmployeeManagement.Domain.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        public async Task<IEnumerable<Employee>> GetAll()
        {
            return await _employeeRepository.GetAll();
        }

        public async Task<Employee> GetById(int id)
        {
            return await _employeeRepository.GetById(id);
        }

        public async Task Create(Employee model)
        {
            await _employeeRepository.Create(model);
        }
        public async Task Delete(int id)
        {
            
            await _employeeRepository.Delete(id);
        }

        public async Task Update(Employee model)
        {
            await _employeeRepository.Update(model);
        }
    }
}
