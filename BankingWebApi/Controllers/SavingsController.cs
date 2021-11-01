using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BankingWebApi.Models;

namespace BankingWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SavingsController : ControllerBase
    {
        private readonly BankDbContext _context;

        public SavingsController(BankDbContext context)
        {
            _context = context;
        }

        // GET: api/Savings
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Savings>>> GetSavings()
        {
            return await _context.Savings.ToListAsync();
        }

        // GET: api/Savings/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Savings>> GetSavings(int id)
        {
            var savings = await _context.Savings.FindAsync(id);

            if (savings == null)
            {
                return NotFound();
            }

            return savings;
        }

        // PUT: api/Savings/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSavings(int id, Savings savings)
        {
            if (id != savings.Id)
            {
                return BadRequest();
            }

            _context.Entry(savings).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SavingsExists(id))
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

        // POST: api/Savings
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Savings>> PostSavings(Savings savings)
        {
            _context.Savings.Add(savings);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSavings", new { id = savings.Id }, savings);
        }

        // DELETE: api/Savings/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSavings(int id)
        {
            var savings = await _context.Savings.FindAsync(id);
            if (savings == null)
            {
                return NotFound();
            }

            _context.Savings.Remove(savings);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SavingsExists(int id)
        {
            return _context.Savings.Any(e => e.Id == id);
        }
    }
}
