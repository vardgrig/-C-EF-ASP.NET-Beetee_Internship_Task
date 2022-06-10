using API.Entities;
using API.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Repositories.Concrete
{
    public class HrDataRepository : IHrDataRepository
    {
        private readonly DataContext _context;
        public HrDataRepository(DataContext context)
        {
            _context = context;
        }
        public async Task AddData(HRData data)
        {
            await _context.HrDatas.AddAsync(data);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteData(int id)
        {
            var data = await _context.HrDatas.FindAsync(id);
            _context.HrDatas.Remove(data);
            await _context.SaveChangesAsync();
        }

        public async Task<List<HRData>> GetAll()
        {
            return await _context.HrDatas.ToListAsync();
        }
        public async Task<HRData> GetById(int id)
        {
            return await _context.HrDatas.FindAsync(id);
        }

        public async Task UpdateData(int id,HRData data)
        {
            var temp = await _context.HrDatas.FindAsync(id);

            temp.Salary = data.Salary;
            temp.SSM = data.SSM;
            temp.EmployeeID = data.EmployeeID;

            _context.HrDatas.Update(temp);
            await _context.SaveChangesAsync();
        }
    }
}
