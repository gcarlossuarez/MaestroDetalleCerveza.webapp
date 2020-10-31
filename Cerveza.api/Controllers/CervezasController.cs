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
            if(context == null)
            {
                int i = 0;
            }
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

            //var l_Cerveza = _context.Cerveza.Find(cerveza);
            //l_Cerveza.Ingrediente = cerveza.Ingrediente;
            //var l_Cerveza = _context.Cerveza.Where(x => x.Id == cerveza.Id).FirstOrDefault();
            //if(l_Cerveza != null)
            //{
            //    l_Cerveza = cerveza;
            //}

            //_context.Entry(cerveza).State = EntityState.Modified;
            
            try
            {
                //// Se cargan los nuevos
                //foreach (var l_Ingrediente in cerveza.Ingrediente.Where(x=> x.Id == 0))
                //{
                //    //if (l_Ingrediente.Id == 0)
                //    {
                //        // Es nuevo
                //        _context.Ingrediente.Add(l_Ingrediente);

                //    }
                //}

                //_context.SaveChanges();

                //List<int> l_ListIdsYaNoEstán = new List<int>();

                //foreach (var l_IngredienteEstabaEnListadoOriginal in _context.Ingrediente.Where(x => x.IdCerveza == cerveza.Id))
                //{
                //    //Ingrediente l_IngredienteParámetro = cerveza.Ingrediente.Where(x => x.Id == l_IngredienteEstabaEnListadoOriginal.Id).FirstOrDefault();

                //    if (cerveza.Ingrediente.Where(x => (x.Id == l_IngredienteEstabaEnListadoOriginal.Id) && (x.Id != 0)).Count() == 0)
                //    {
                //        // Se borran los que ya no están
                //        l_ListIdsYaNoEstán.Add(l_IngredienteEstabaEnListadoOriginal.Id);
                //    }
                //}

                //Cerveza.api.Models.Cerveza l_CervezaAnterior = _context.Cerveza.Where(x => x.Id == cerveza.Id).FirstOrDefault();

                //var l_ListOriginal = l_CervezaAnterior.Ingrediente.Where(x => x.IdCerveza == cerveza.Id);
                //foreach (var l_IngredienteEstabaEnListadoOriginal in l_ListOriginal)
                //{
                //    //Ingrediente l_IngredienteParámetro = cerveza.Ingrediente.Where(x => x.Id == l_IngredienteEstabaEnListadoOriginal.Id).FirstOrDefault();

                //    if (null == 
                //        cerveza.Ingrediente.Where(x => (x.Id == l_IngredienteEstabaEnListadoOriginal.Id) && (x.Id != 0)).FirstOrDefault())
                //    {
                //        // Se borrarán los que ya no están, cuando se invoque a "SaveChangesAsync" 
                //        l_CervezaAnterior.Ingrediente.Remove(l_IngredienteEstabaEnListadoOriginal);
                //    }
                //}

                //_context.Update(cerveza);
                //foreach(var l_Ingrediente in cerveza.Ingrediente)
                //{
                //    Cerveza.api.Models.Ingrediente l_IngredienteAnterior =
                //        l_ListOriginal.Where(x => x.Id == l_Ingrediente.Id).FirstOrDefault();
                //    if (null != l_IngredienteAnterior)
                //    {
                //        l_CervezaAnterior.Ingrediente
                //        l_Ingrediente.Entry.State = EntityState.Modified;
                //    }
                //}
                //l_CervezaAnterior = cerveza;
                //_context.Update(l_CervezaAnterior);

                //_context.Entry(cerveza).State = EntityState.Modified;

                _context.Update(cerveza);


                //await _context.SaveChangesAsync();

                _context.SaveChanges();

                //var l_ListadoFaltantes = (from s in _context.Ingrediente
                //                         where !cerveza.Ingrediente.Any( es => (es.Id == s.Id) )
                //                         select s).AsEnumerable();
                //foreach (var l_IngredienteEstabaEnListadoOriginal in l_ListadoFaltantes)
                //{
                //    _context.Ingrediente.Remove(l_IngredienteEstabaEnListadoOriginal);
                //}
                List<int> l_ListIds = cerveza.Ingrediente.Select(x => x.Id).ToList();
                var l_ListadoFaltantes = _context.Ingrediente.Where(x=> x.IdCerveza == cerveza.Id);
                foreach (var l_IngredienteEstabaEnListadoOriginal in l_ListadoFaltantes)
                {
                    if(l_ListIds.Where(x=> x == l_IngredienteEstabaEnListadoOriginal.Id).Count() == 0)
                    {
                        _context.Ingrediente.Remove(l_IngredienteEstabaEnListadoOriginal);
                    }
                }

                await _context.SaveChangesAsync();

                //foreach(var l_IdYaNoEstá in l_ListIdsYaNoEstán)
                //{
                //    Ingrediente l_IngredienteYaNoEstá = cerveza.Ingrediente.Where(x => x.Id == l_IdYaNoEstá).FirstOrDefault();
                //    if(null != l_IngredienteYaNoEstá)
                //    {
                //        _context.Ingrediente.Remove(l_IngredienteYaNoEstá);
                //    }

                //}

                //await _context.SaveChangesAsync();
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

            return Ok(); // NoContent();
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
