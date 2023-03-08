using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LoomAPI.Data;
using LoomAPI.Models;

namespace LoomAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TearesController : ControllerBase
    {
        private readonly AppDbContext _context;

        public TearesController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Teares
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Tear>>> GetTeares()
        {
            return await _context.Teares.ToListAsync();
        }

        // GET: api/Teares/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Tear>> GetTear(int id)
        {
            var tear = await _context.Teares.FindAsync(id);

            if (tear == null)
            {
                return NotFound();
            }

            return tear;
        }

        // PUT: api/Teares/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTear(int id, Tear tear)
        {
            if (id != tear.Id)
            {
                return BadRequest();
            }

            _context.Entry(tear).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TearExists(id))
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

        // POST: api/Teares
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Tear>> PostTear(Tear tear)
        {
            _context.Teares.Add(tear);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTear", new { id = tear.Id }, tear);
        }

        // DELETE: api/Teares/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTear(int id)
        {
            var tear = await _context.Teares.FindAsync(id);
            if (tear == null)
            {
                return NotFound();
            }

            _context.Teares.Remove(tear);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TearExists(int id)
        {
            return _context.Teares.Any(e => e.Id == id);
        }
    }
}
