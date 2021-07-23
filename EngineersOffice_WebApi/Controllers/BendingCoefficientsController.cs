using EngineersOffice_Library.Models;
using EngineersOffice_WebApi.ContextFolder;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EngineersOffice_WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BendingCoefficientsController : ControllerBase
    {
        private readonly DataContext _context;

        public BendingCoefficientsController(DataContext context)
        {
            _context = context;
        }

        // GET: api/BendingCoefficients
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BendingCoefficient>>> GetBendingCoefficient_Guide()
        {
            return await _context.BendingCoefficient_Guide.ToListAsync();
        }

        // GET: api/BendingCoefficients/5
        [HttpGet("{flexibility}")]
        public async Task<ActionResult<BendingCoefficient>> GetBendingCoefficient_Flex(int flexibility)
        {
            return await _context.BendingCoefficient_Guide.Where(с => с.Flexibility >= flexibility).FirstOrDefaultAsync();
        }

        // PUT: api/BendingCoefficients/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBendingCoefficient(int id, BendingCoefficient bendingCoefficient)
        {
            if (id != bendingCoefficient.Id)
            {
                return BadRequest();
            }

            _context.Entry(bendingCoefficient).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BendingCoefficientExist(id))
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


        // POST: api/BendingCoefficients
        [HttpPost]
        public async Task<ActionResult<BendingCoefficient>> PostBendingCoefficient(BendingCoefficient bendingCoefficient)
        {
            _context.BendingCoefficient_Guide.Add(bendingCoefficient);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBendingCoefficient", new { id = bendingCoefficient.Id }, bendingCoefficient);
        }

        // DELETE: api/BendingCoefficients/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBendingCoefficient(int id)
        {
            var bendingCoefficient = await _context.BendingCoefficient_Guide.FindAsync(id);
            if (bendingCoefficient == null)
            {
                return NotFound();
            }

            _context.BendingCoefficient_Guide.Remove(bendingCoefficient);
            await _context.SaveChangesAsync();

            return NoContent();
        }


        private bool BendingCoefficientExist(int id)
        {
            return _context.SteelGrade_Guide.Any(e => e.Id == id);
        }
    }
}
