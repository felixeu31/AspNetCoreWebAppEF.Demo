using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Web.Models;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParejasController : ControllerBase
    {
        private readonly DemoContext _context;

        public ParejasController(DemoContext context)
        {
            _context = context;
        }

        // GET: api/Parejas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Pajera>>> GetPareja()
        {
            return await _context.Pajera.ToListAsync();
        }

        // GET: api/Parejas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Pajera>> GetPareja(int id)
        {
            var pareja = await _context.Pajera.FindAsync(id);

            if (pareja == null)
            {
                return NotFound();
            }

            return pareja;
        }

        // PUT: api/Parejas/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPareja(int id, Pajera pareja)
        {
            if (id != pareja.Id)
            {
                return BadRequest();
            }

            _context.Entry(pareja).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ParejaExists(id))
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

        // POST: api/Parejas
        [HttpPost]
        public async Task<ActionResult<Pajera>> PostPareja(Pajera pareja)
        {
            _context.Pajera.Add(pareja);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPareja", new { id = pareja.Id }, pareja);
        }

        // DELETE: api/Parejas/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Pajera>> DeletePareja(int id)
        {
            var pareja = await _context.Pajera.FindAsync(id);
            if (pareja == null)
            {
                return NotFound();
            }

            _context.Pajera.Remove(pareja);
            await _context.SaveChangesAsync();

            return pareja;
        }

        private bool ParejaExists(int id)
        {
            return _context.Pajera.Any(e => e.Id == id);
        }
    }
}
