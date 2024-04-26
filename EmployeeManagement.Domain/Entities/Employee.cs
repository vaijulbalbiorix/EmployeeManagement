using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Domain.Entities
{
    public  class Employee
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Experience { get; set; }
        public string? Department { get; set; }
        public string? City { get; set; }

    }
}
