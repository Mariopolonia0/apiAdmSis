using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TravelManagementApi.Data;
using TravelManagementApi.Models;

namespace TravelManagementApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IngresoesController : ControllerBase
    {
        private readonly Contexto _context;

        public IngresoesController(Contexto context)
        {
            _context = context;
        }

        // GET: api/Ingresoes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Ingreso>>> GetIngreso()
        {
            return await _context.Ingreso.ToListAsync();
        }

        // GET: api/Ingresoes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Ingreso>> GetIngreso(int id)
        {
            var ingreso = await _context.Ingreso.FindAsync(id);

            if (ingreso == null)
            {
                return NotFound();
            }

            return ingreso;
        }

        // PUT: api/Ingresoes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutIngreso(int id, Ingreso ingreso)
        {
            if (id != ingreso.IngresoId)
            {
                return BadRequest();
            }

            _context.Entry(ingreso).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!IngresoExists(id))
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

        // POST: api/Ingresoes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Ingreso>> PostIngreso(Ingreso ingreso)
        {
            _context.Ingreso.Add(ingreso);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetIngreso", new { id = ingreso.IngresoId }, ingreso);
        }

        // DELETE: api/Ingresoes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteIngreso(int id)
        {
            var ingreso = await _context.Ingreso.FindAsync(id);
            if (ingreso == null)
            {
                return NotFound();
            }

            _context.Ingreso.Remove(ingreso);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool IngresoExists(int id)
        {
            return _context.Ingreso.Any(e => e.IngresoId == id);
        }
    }
}
