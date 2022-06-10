using API.Entities;
using API.Manager.Abstract;
using API.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Manager.Concrete
{
    public class EmployeeManager : IEmployeeManager
    {
        private readonly IEmployeeRepository _repo;
        public EmployeeManager(IEmployeeRepository repo)
        {
            _repo = repo;
        }
        public async Task AddEmployee(Employee employee)
        {
            await _repo.AddEmployee(employee);
        }

        public async Task DeleteEmployee(int id)
        {
            await _repo.DeleteEmployee(id);
        }

        public async Task<List<Employee>> GetAll()
        {
            return await _repo.GetAll();
        }

        public async Task<Employee> GetById(int id)
        {
            return await _repo.GetById(id);
        }

        public async Task UpdateEmployee(int id, Employee employee)
        {
            await _repo.UpdateEmployee(id, employee);
        }
    }
}
