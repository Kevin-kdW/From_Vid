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
    public class SockController : ControllerBase
    {
        private readonly DataContext _context;

        public SockController(DataContext context)
        {
            _context = context;
        }

        // GET: api/Sock
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Sock>>> GetSock()
        {
          if (_context.Sock == null)
          {
              return NotFound();
          }
            return await _context.Sock.ToListAsync();
        }

        // GET: api/Sock/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Sock>> GetSock(int id)
        {
          if (_context.Sock == null)
          {
              return NotFound();
          }
            var sock = await _context.Sock.FindAsync(id);

            if (sock == null)
            {
                return NotFound();
            }

            return sock;
        }

        // PUT: api/Sock/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSock(int id, Sock sock)
        {
            if (id != sock.Id)
            {
                return BadRequest();
            }

            _context.Entry(sock).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SockExists(id))
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

        // POST: api/Sock
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Sock>> PostSock(Sock sock)
        {
          if (_context.Sock == null)
          {
              return Problem("Entity set 'DataContext.Sock'  is null.");
          }
            _context.Sock.Add(sock);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSock", new { id = sock.Id }, sock);
        }

        // DELETE: api/Sock/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSock(int id)
        {
            if (_context.Sock == null)
            {
                return NotFound();
            }
            var sock = await _context.Sock.FindAsync(id);
            if (sock == null)
            {
                return NotFound();
            }

            _context.Sock.Remove(sock);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SockExists(int id)
        {
            return (_context.Sock?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
