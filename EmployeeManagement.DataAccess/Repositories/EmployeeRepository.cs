using Microsoft.EntityFrameworkCore;

using EmployeeManagement.Domain.Entities;
using EmployeeManagement.DataAccess.Context;
using Microsoft.Extensions.Logging;
using EmployeeManagement.Domain.IServices;
using Serilog;


namespace EmployeeManagement.DataAccess.Reposotories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly ApiDbContext _context;
      //  private readonly ILogger<EmployeeRepository> _logger;   

        public EmployeeRepository(ApiDbContext context)
        {
            _context = context;
           // _logger = logger;
        }
        public async Task<List<Employee>> GetAll()
        {
            try
            {
                Log.Information("fetch user method called");
                return await _context.employees.ToListAsync();

            }
            catch (Exception ex)
            {
                Log.Error("Fetch user error", ex);
                throw;
            }
        }
        public async Task Create(Employee employee)
        {
            try
            {
                Log.Information("Create user method called");
                await _context.employees.AddAsync(employee);
                await _context.SaveChangesAsync();
            }
            catch(Exception ex)
            {
                Log.Error("Create user error", ex);
                throw;
            }
             
        }

        public async Task Delete(int id)
        {
            try
            {
                var employee = await _context.employees.FindAsync(id);
                if (employee == null)
                {
                    throw new KeyNotFoundException("user not found");
                }
                _context.employees.Remove(employee);
                await _context.SaveChangesAsync();
            }
            catch(Exception ex) {
                throw;
            }
        }


        public async Task<Employee> GetById(int id)
        {
            try
            {
                var employee = await _context.employees.FindAsync(id);
                if (employee == null)
                    throw new KeyNotFoundException("user not found");
                return employee;
            }
            catch(Exception ex) {
                throw;
            }
        }

        public async Task Update(Employee employee)
        {
            try
            {
             _context.employees.Update(employee);
            await _context.SaveChangesAsync();
            }
            catch(Exception ex)
            {
                throw;
            }
        }
    }
}
