using EngineersOffice_Library.Models;
using EngineersOffice_WebApi.ContextFolder;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EngineersOffice_WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SteelGradesController : ControllerBase
    {
        private readonly DataContext _context;

        public SteelGradesController(DataContext context)
        {
            _context = context;
        }

        // GET: api/SteelGrades
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SteelGrade>>> GetSteelGradeGuide()
        {
            return await _context.SteelGrade_Guide.ToListAsync();
        }

        // GET: api/SteelGrades/
        [HttpGet("{searchString}")]
        public async Task<ActionResult<IEnumerable<SteelGrade>>> GetSteelGradeGuide(string searchString)
        {
            var steelGrade = from s in _context.SteelGrade_Guide
                             select s;

            if (!String.IsNullOrEmpty(searchString))
            {
                steelGrade = steelGrade.Where(s => s.Grade.Contains(searchString));
            }

            return await steelGrade.ToListAsync();
        }


        // PUT: api/SteelGrades/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSteelGrade(int id, SteelGrade steelGrade)
        {
            if (id != steelGrade.Id)
            {
                return BadRequest();
            }

            _context.Entry(steelGrade).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SteelGradeExists(id))
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

        // POST: api/SteelGrades
        [HttpPost]
        public async Task<ActionResult<SteelGrade>> PostSteelGrade(SteelGrade steelGrade)
        {
            _context.SteelGrade_Guide.Add(steelGrade);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSteelGrade", new { id = steelGrade.Id }, steelGrade);
        }

        // DELETE: api/SteelGrades/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSteelGrade(int id)
        {
            var steelGrade = await _context.SteelGrade_Guide.FindAsync(id);
            if (steelGrade == null)
            {
                return NotFound();
            }

            _context.SteelGrade_Guide.Remove(steelGrade);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SteelGradeExists(int id)
        {
            return _context.SteelGrade_Guide.Any(e => e.Id == id);
        }
    }
}
