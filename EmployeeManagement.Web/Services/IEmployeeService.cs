using EmployeeManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Web.Services
{
    public interface IEmployeeService
    {
        public Task<IEnumerable<Employee>> GetEmployees();
        public Task<Employee> GetEmployee(int id);
    }
}
