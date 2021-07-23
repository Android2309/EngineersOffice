using EngineersOffice_Library.Models.MetalAssortment;
using EngineersOffice_WebApi.ContextFolder;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EngineersOffice_WebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class MetalAssortmentController : Controller
    {

        private readonly DataContext _context;

        public MetalAssortmentController(DataContext context)
        {
            _context = context;
        }


        // POST: api/MetalAssortment/AddBeam
        [HttpPost]
        public async Task<ActionResult<Beam>> AddBeam(Beam beam)
        {
            _context.Beam_Guide.Add(beam);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBeam", new { id = beam.Id }, beam);
        }


        // DELETE: api/MetalAssortment/DeleteBeam/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBeam(int id)
        {
            var beam = await _context.Beam_Guide.FindAsync(id);
            if (beam == null)
            {
                return NotFound();
            }

            _context.Beam_Guide.Remove(beam);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        // PUT: api/MetalAssortment/EditBeam/5
        [HttpPut("{id}")]
        public async Task<IActionResult> EditBeam(int id, Beam beam)
        {
            if (id != beam.Id)
            {
                return BadRequest();
            }

            _context.Entry(beam).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BeamExists(id))
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

        // GET: api/MetalAssortment/GetAllBeams
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Beam>>> GetAllBeams()
        {
            return await _context.Beam_Guide.ToListAsync();
        }

        // GET: api/MetalAssortment/GetBeam/25
        [HttpGet("{Wx}")]
        public async Task<ActionResult<Beam>> GetBeam(int Wx)
        {
            return await _context.Beam_Guide.Where(b => b.Wx >= Wx).FirstOrDefaultAsync();
        }

        // GET: api/MetalAssortment/GetBeam_Flex/1/25/200
        //подбор балки по гибкости
        [HttpGet]
        [Route("{id}/{F_tr}/{Lc}")]
        public async Task<ActionResult<Beam>> GetBeam_Flex(int id, double F_tr, double Lc) 
        {
            var beam = _context.Beam_Guide.Where(
                                  b => b.F >= F_tr &&
                                  (Lc / b.i_x) < 150 &&
                                  (Lc / b.i_y) < 150 &&
                                  b.Id > id
                                  ).FirstOrDefaultAsync();

            return await beam;
        }


        private bool BeamExists(int id)
        {
            return _context.Beam_Guide.Any(e => e.Id == id);
        }
    }
}
