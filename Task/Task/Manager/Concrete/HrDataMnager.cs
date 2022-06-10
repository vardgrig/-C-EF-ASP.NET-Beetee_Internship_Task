using API.Entities;
using API.Manager.Abstract;
using API.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Manager.Concrete
{
    public class HrDataManager : IHrDataManager
    {
        private readonly IHrDataRepository _repo;
        public HrDataManager(IHrDataRepository repo)
        {
            _repo = repo;
        }
        public async Task AddData(HRData data)
        {
            await _repo.AddData(data);
        }

        public async Task DeleteData(int id)
        {
            await _repo.DeleteData(id);
        }

        public async Task<List<HRData>> GetAll()
        {
            return await _repo.GetAll();
        }

        public async Task<HRData> GetById(int id)
        {
            return await _repo.GetById(id);
        }

        public async Task UpdateData(int id, HRData data)
        {
            await _repo.UpdateData(id, data);
        }
    }
}
