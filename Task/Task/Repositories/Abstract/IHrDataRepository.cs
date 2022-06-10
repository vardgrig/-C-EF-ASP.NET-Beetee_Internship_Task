using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Entities;

namespace API.Repositories.Abstract
{
    public interface IHrDataRepository
    {
        Task<List<HRData>> GetAll();
        Task<HRData> GetById(int id);
        Task AddData(HRData employee);
        Task UpdateData(int id, HRData employee);
        Task DeleteData(int id);
    }
}
