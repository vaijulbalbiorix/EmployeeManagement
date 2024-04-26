﻿using EmployeeManagement.Domain.Entities;

namespace EmployeeManagement.Domain.IServices
{
    public interface IEmployeeService
    {
        Task<IEnumerable<Employee>> GetAll();
        Task<Employee> GetById(int id);
        Task Create(Employee model);
        Task Update(Employee model);
        Task Delete(int id);
    }
}
