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
    public class SockShopController : ControllerBase
    {
        private readonly DataContext _context;

        public SockShopController(DataContext context)
        {
            _context = context;
        }

        // GET: api/SockShop
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SockShop>>> GetSockShop()
        {
          if (_context.SockShop == null)
          {
              return NotFound();
          }
            return await _context.SockShop.ToListAsync();
        }

        // GET: api/SockShop/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SockShop>> GetSockShop(int id)
        {
          if (_context.SockShop == null)
          {
              return NotFound();
          }
            var sockShop = await _context.SockShop.FindAsync(id);

            if (sockShop == null)
            {
                return NotFound();
            }

            return sockShop;
        }

        // PUT: api/SockShop/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSockShop(int id, SockShop sockShop)
        {
            if (id != sockShop.Id)
            {
                return BadRequest();
            }

            _context.Entry(sockShop).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SockShopExists(id))
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

        // POST: api/SockShop
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<SockShop>> PostSockShop(SockShop sockShop)
        {
          if (_context.SockShop == null)
          {
              return Problem("Entity set 'DataContext.SockShop'  is null.");
          }
            _context.SockShop.Add(sockShop);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSockShop", new { id = sockShop.Id }, sockShop);
        }

        // DELETE: api/SockShop/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSockShop(int id)
        {
            if (_context.SockShop == null)
            {
                return NotFound();
            }
            var sockShop = await _context.SockShop.FindAsync(id);
            if (sockShop == null)
            {
                return NotFound();
            }

            _context.SockShop.Remove(sockShop);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SockShopExists(int id)
        {
            return (_context.SockShop?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
