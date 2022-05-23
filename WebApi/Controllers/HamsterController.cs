using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApi.Data;
using WebApi.Models;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HamsterController : ControllerBase
    {
        private readonly WebApiContext _context;

        public HamsterController(WebApiContext context)
        {
            _context = context;
        }

        // GET: api/Hamster
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Hamster>>> GetTable()
        {
          if (_context.Table == null)
          {
              return NotFound();
          }
            return await _context.Table.ToListAsync();
        }

        // GET: api/Hamster/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Hamster>> GetTable(int id)
        {
          if (_context.Table == null)
          {
              return NotFound();
          }
            var table = await _context.Table.FindAsync(id);

            if (table == null)
            {
                return NotFound();
            }

            return table;
        }

        // PUT: api/Hamster/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTable(int id, Hamster table)
        {
            if (id != table.Id)
            {
                return BadRequest();
            }

            _context.Entry(table).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TableExists(id))
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

        // POST: api/Hamster
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Hamster>> PostTable(Hamster table)
        {
          if (_context.Table == null)
          {
              return Problem("Entity set 'WebApiContext.Table'  is null.");
          }
            _context.Table.Add(table);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTable", new { id = table.Id }, table);
        }

        // DELETE: api/Hamster/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTable(int id)
        {
            if (_context.Table == null)
            {
                return NotFound();
            }
            var table = await _context.Table.FindAsync(id);
            if (table == null)
            {
                return NotFound();
            }

            _context.Table.Remove(table);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TableExists(int id)
        {
            return (_context.Table?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
