using Azure.Core;
using BusTicketApplication.Core.Models.Dtos;
using BusTicketApplication.Core.ServiceInterfaces;
using BusTicketApplication.Service.Services;
using Microsoft.AspNetCore.Mvc;

namespace BusTicketApplication.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BusesController : Controller
    {
        private readonly IBusService _service;
        public BusesController(IBusService service)
        {
            _service = service;
        }
        
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var buses = await _service.GetAllAsync();
            return Ok(buses);

        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var bus = await _service.GetByIdAsync(id);
            if (bus == null) return NotFound();
            return Ok(bus);
        }

        [HttpPost]
        public async Task<IActionResult> Save(BusDto busDto)
        {
            
            var newBus = await _service.AddAsync(busDto);

            
            return CreatedAtAction(nameof(GetById), new { id = newBus.Id }, newBus);
        }

        [HttpPut("{id}")] 
        public async Task<IActionResult> Update(int id, BusDto busDto)
        {
            

            await _service.UpdateAsync(busDto, id);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Remove(int id)
        {
            await _service.RemoveAsync(id);
            return NoContent();
        }
    }
}
