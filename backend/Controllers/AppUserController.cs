using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using backend.Models;
using backend.Data;

namespace backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppUserController : ControllerBase
    {
        private readonly DataContext _context;

        public AppUserController(DataContext context)
        {
            _context = context;
        }

        // GET: api/AppUser
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppUser>>> GetAppUser()
        {
          if (_context.AppUser == null)
          {
              return NotFound();
          }
            return await _context.AppUser.ToListAsync();
        }

        // GET: api/AppUser/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AppUser>> GetAppUser(int id)
        {
          if (_context.AppUser == null)
          {
              return NotFound();
          }
            var appUser = await _context.AppUser.FindAsync(id);

            if (appUser == null)
            {
                return NotFound();
            }

            return appUser;
        }

        // PUT: api/AppUser/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAppUser(int id, AppUser appUser)
        {
            if (id != appUser.Id)
            {
                return BadRequest();
            }

            _context.Entry(appUser).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AppUserExists(id))
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

        // POST: api/AppUser
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<AppUser>> PostAppUser(AppUser appUser)
        {
          if (_context.AppUser == null)
          {
              return Problem("Entity set 'DataContext.AppUser'  is null.");
          }
            _context.AppUser.Add(appUser);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAppUser", new { id = appUser.Id }, appUser);
        }

        // DELETE: api/AppUser/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAppUser(int id)
        {
            if (_context.AppUser == null)
            {
                return NotFound();
            }
            var appUser = await _context.AppUser.FindAsync(id);
            if (appUser == null)
            {
                return NotFound();
            }

            _context.AppUser.Remove(appUser);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AppUserExists(int id)
        {
            return (_context.AppUser?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
