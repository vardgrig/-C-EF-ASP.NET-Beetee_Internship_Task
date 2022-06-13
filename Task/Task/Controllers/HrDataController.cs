using API.Entities;
using API.Manager.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HrDataController : ControllerBase
    {
        private readonly IHrDataManager _manager;
        public HrDataController(IHrDataManager manager)
        {
            _manager = manager;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var hrDatas = await _manager.GetAll();
            return Ok(hrDatas);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var hrData = await _manager.GetById(id);
            return Ok(hrData);
        }
        [HttpPost]
        public async Task<IActionResult> AddHrData([FromBody] HRData hrData)
        {
            await _manager.AddData(hrData);
            return Ok();
        }
        [HttpPut]
        public async Task<IActionResult> UpdateData(int id, [FromBody] HRData hrData)
        {
            await _manager.UpdateData(id, hrData);
            return Ok();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteData(int id)
        {
            await _manager.DeleteData(id);
            return Ok();
        }
    }
}
