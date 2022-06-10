using API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Manager.Abstract
{
    public interface IEmployeeManager
    {
        Task<List<Employee>> GetAll();
        Task<Employee> GetById(int id);
        Task AddEmployee(Employee employee);
        Task UpdateEmployee(int id, Employee employee);
        Task DeleteEmployee(int id);

    }
}
