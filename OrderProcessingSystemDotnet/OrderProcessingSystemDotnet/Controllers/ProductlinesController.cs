using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OrderProcessingSystemDotnet.Models;
using OrderProcessingSystemDotnet.Models.Tables;

namespace OrderProcessingSystemDotnet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductlinesController : ControllerBase
    {
        private readonly OpsApiDbContext _context;

        public ProductlinesController(OpsApiDbContext context)
        {
            _context = context;
        }

        // GET: api/Productlines
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Productline>>> GetProductlines()
        {
          if (_context.Productlines == null)
          {
              return NotFound();
          }
            return await _context.Productlines.ToListAsync();
        }

        // GET: api/Productlines/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Productline>> GetProductline(int id)
        {
          if (_context.Productlines == null)
          {
              return NotFound();
          }
            var productline = await _context.Productlines.FindAsync(id);

            if (productline == null)
            {
                return NotFound();
            }

            return productline;
        }

        // PUT: api/Productlines/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProductline(int id, Productline productline)
        {
            if (id != productline.Id)
            {
                return BadRequest();
            }

            _context.Entry(productline).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProductlineExists(id))
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

        // POST: api/Productlines
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Productline>> PostProductline(Productline productline)
        {
          if (_context.Productlines == null)
          {
              return Problem("Entity set 'OpsApiDbContext.Productlines'  is null.");
          }
            _context.Productlines.Add(productline);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProductline", new { id = productline.Id }, productline);
        }

        // DELETE: api/Productlines/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProductline(int id)
        {
            if (_context.Productlines == null)
            {
                return NotFound();
            }
            var productline = await _context.Productlines.FindAsync(id);
            if (productline == null)
            {
                return NotFound();
            }

            _context.Productlines.Remove(productline);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ProductlineExists(int id)
        {
            return (_context.Productlines?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
