using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Pro_Events.Api.Data;
using Pro_Events.Api.Models;

namespace Pro_Events.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventController : ControllerBase
    {
        private readonly DataContext _context;
        public EventController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IEnumerable<Event>> Get()
        {
            return await _context.Events.AsNoTracking().ToListAsync();
        }

        [HttpGet("{id:Guid}")]
        public async Task<Event> Get(Guid id)
        {
            return await _context.Events.AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);
        }

        [HttpPost]
        public async Task<Guid> Post([FromBody]Event movel)
        {
             _context.Events.Add(movel);
             await _context.SaveChangesAsync();

            return movel.Id;
        }

        [HttpPut("{id:int}")]
        public string Put(int id)
        {
            return $"Example Put with id: {id}";
        }

        [HttpDelete("{id:int}")]
        public string Delete(int id)
        {
            return $"Deleting id: {id}";
        } 
    }
}