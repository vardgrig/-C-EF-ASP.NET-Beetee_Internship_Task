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
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeManager _manager;
        public EmployeeController(IEmployeeManager manager)
        {
            _manager = manager;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var employees = await _manager.GetAll();
            return Ok(employees);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var employee = await _manager.GetById(id);
            return Ok(employee);
        }
        [HttpPost]
        public async Task<IActionResult> AddEmployee([FromBody] Employee employee)
        {
            await _manager.AddEmployee(employee);
            return Ok();
        }
        [HttpPut]
        public async Task<IActionResult> UpdateEmployee(int id, [FromBody] Employee employee)
        {
            await _manager.UpdateEmployee(id, employee);
            return Ok();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEmployee(int id)
        {
            await _manager.DeleteEmployee(id);
            return Ok();
        }
    }
}
