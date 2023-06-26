using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using API.Models;
using backend.Data;

namespace backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SockManufacturerController : ControllerBase
    {
        private readonly DataContext _context;

        public SockManufacturerController(DataContext context)
        {
            _context = context;
        }

        // GET: api/SockManufacturer
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SockManufacturer>>> GetSockManufacturer()
        {
          if (_context.SockManufacturer == null)
          {
              return NotFound();
          }
            return await _context.SockManufacturer.ToListAsync();
        }

        // GET: api/SockManufacturer/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SockManufacturer>> GetSockManufacturer(int id)
        {
          if (_context.SockManufacturer == null)
          {
              return NotFound();
          }
            var sockManufacturer = await _context.SockManufacturer.FindAsync(id);

            if (sockManufacturer == null)
            {
                return NotFound();
            }

            return sockManufacturer;
        }

        // PUT: api/SockManufacturer/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSockManufacturer(int id, SockManufacturer sockManufacturer)
        {
            if (id != sockManufacturer.Id)
            {
                return BadRequest();
            }

            _context.Entry(sockManufacturer).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SockManufacturerExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/SockManufacturer
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<SockManufacturer>> PostSockManufacturer(SockManufacturer sockManufacturer)
        {
          if (_context.SockManufacturer == null)
          {
              return Problem("Entity set 'DataContext.SockManufacturer'  is null.");
          }
            _context.SockManufacturer.Add(sockManufacturer);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSockManufacturer", new { id = sockManufacturer.Id }, sockManufacturer);
        }

        // DELETE: api/SockManufacturer/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSockManufacturer(int id)
        {
            if (_context.SockManufacturer == null)
            {
                return NotFound();
            }
            var sockManufacturer = await _context.SockManufacturer.FindAsync(id);
            if (sockManufacturer == null)
            {
                return NotFound();
            }

            _context.SockManufacturer.Remove(sockManufacturer);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SockManufacturerExists(int id)
        {
            return (_context.SockManufacturer?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
