using System.Collections.Generic;
using System.Threading.Tasks;
using ConsultancyFirm.Domain.Entities;
using ConsultancyFirm.Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ConsultancyFirm.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BusinessTrackersController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public BusinessTrackersController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<BusinessTracker>>> GetBusinessTrackers()
        {
            return Ok(await _context.BusinessTrackers.ToListAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<BusinessTracker>> GetBusinessTracker(int id)
        {
            var businessTracker = await _context.BusinessTrackers.FindAsync(id);
            if (businessTracker == null)
            {
                return NotFound();
            }
            return Ok(businessTracker);
        }

        [HttpPost]
        public async Task<ActionResult> AddBusinessTracker([FromBody] BusinessTracker businessTracker)
        {
            _context.BusinessTrackers.Add(businessTracker);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetBusinessTracker), new { id = businessTracker.TrackerID }, businessTracker);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateBusinessTracker(int id, [FromBody] BusinessTracker businessTracker)
        {
            if (id != businessTracker.TrackerID)
            {
                return BadRequest();
            }

            _context.Entry(businessTracker).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBusinessTracker(int id)
        {
            var businessTracker = await _context.BusinessTrackers.FindAsync(id);
            if (businessTracker == null)
            {
                return NotFound();
            }

            _context.BusinessTrackers.Remove(businessTracker);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
