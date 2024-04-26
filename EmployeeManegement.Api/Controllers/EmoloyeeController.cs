
using Microsoft.EntityFrameworkCore;
using EmployeeManagement.Domain.IServices;
using EmployeeManagement.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace EmployeeManagement.Api.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class EmoloyeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;
       

        public EmoloyeeController(IEmployeeService employeeService)
        {
            
            _employeeService = employeeService;
        }

        [HttpGet]
        public async  Task<IActionResult> Get()
        {
            var employee = await _employeeService.GetAll();
            return Ok(employee);
        }

        [HttpGet]
        [Route(template: "GetById")]
        public async Task<IActionResult> GetbyId(int id)
        {
            var user = await _employeeService.GetById(id);
            return Ok(user);

        }

        [HttpPost]
        [Route(template:"AddEmployee")]
        public async Task<IActionResult> AddEmployee(Employee employee)
        {
            await _employeeService.Create(employee);
            return Ok(new { message = "User created" });
        }

        [HttpPut]
        [Route(template:"Update")]
        public async Task<IActionResult> UpdateEmployee(Employee employee)
        {
            await _employeeService.Update(employee);
            return Ok(new { message = "User updated" });
        }

        [HttpDelete]
        [Route(template:"Delete")]
        public async Task<IActionResult> Delete(int id)
        {
            await _employeeService.Delete(id);
            return Ok(new { message = "User deleted" });
        }

    }
}
