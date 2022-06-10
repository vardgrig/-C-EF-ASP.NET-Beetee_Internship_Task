using API.Entities;
using API.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Repositories.Concrete
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly DataContext _context;
        public EmployeeRepository(DataContext context)
        {
            _context = context;
        }
        public async Task AddEmployee(Employee employee)
        {
            await _context.Employees.AddAsync(employee);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteEmployee(int id)
        {
            var employee = await _context.Employees.FindAsync(id);
            _context.Employees.Remove(employee);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Employee>> GetAll()
        {
            try
            {
                return await _context.Employees.ToListAsync();
            }
            catch(Exception ex)
            {
                throw;
            }
        }
        public async Task<Employee> GetById(int id)
        {
            return await _context.Employees.FindAsync(id);
        }
        public async Task UpdateEmployee(int id,Employee employee)
        {
            var emp = await _context.Employees.FindAsync(id);

            emp.FirstName = employee.FirstName;
            emp.LastName = employee.LastName;
            emp.ContactNumber = employee.ContactNumber;
            emp.Email = employee.Email;
            emp.Gender = employee.Gender;
            emp.BirthDate = employee.BirthDate;

            _context.Employees.Update(emp);
            await _context.SaveChangesAsync();
        }
    }
}
