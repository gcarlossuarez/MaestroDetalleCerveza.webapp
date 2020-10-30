using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Cerveza.api.Models;

namespace Cerveza.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CervezasController : ControllerBase
    {
        private readonly MaestroDetalleContext _context;

        public CervezasController(MaestroDetalleContext context)
        {
            _context = context;
            //_context = new MaestroDetalleContext();
        }

        // GET: api/Cervezas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Cerveza.api.Models.Cerveza>>> GetCerveza()
        {
            return await _context.Cerveza.ToListAsync();
        }

        // GET: api/Cervezas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Cerveza.api.Models.Cerveza>> GetCerveza(int id)
        {
            var cerveza = await _context.Cerveza.FindAsync(id);

            if (cerveza == null)
            {
                return NotFound();
            }

            return cerveza;
        }

        // PUT: api/Cervezas/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCerveza(int id, Cerveza.api.Models.Cerveza cerveza)
        {
            if (id != cerveza.Id)
            {
                return BadRequest();
            }

            _context.Entry(cerveza).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CervezaExists(id))
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

        // POST: api/Cervezas
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Cerveza.api.Models.Cerveza>> PostCerveza(Cerveza.api.Models.Cerveza cerveza)
        {
            _context.Cerveza.Add(cerveza);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCerveza", new { id = cerveza.Id }, cerveza);
        }

        // DELETE: api/Cervezas/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Cerveza.api.Models.Cerveza>> DeleteCerveza(int id)
        {
            var cerveza = await _context.Cerveza.FindAsync(id);
            if (cerveza == null)
            {
                return NotFound();
            }

            _context.Cerveza.Remove(cerveza);
            await _context.SaveChangesAsync();

            return cerveza;
        }

        private bool CervezaExists(int id)
        {
            return _context.Cerveza.Any(e => e.Id == id);
        }
    }
}
