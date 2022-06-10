using API.Entities;
using API.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Manager.Abstract
{
    public interface IHrDataManager
    {
        Task<List<HRData>> GetAll();
        Task<HRData> GetById(int id);
        Task AddData(HRData data);
        Task UpdateData(int id, HRData data);
        Task DeleteData(int id);

    }
}
