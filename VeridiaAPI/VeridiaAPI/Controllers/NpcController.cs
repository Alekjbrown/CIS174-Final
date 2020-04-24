using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VeridiaAPI.Models;

namespace VeridiaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NpcController : ControllerBase
    {
        private readonly NpcContext _context;

        public NpcController(NpcContext context)
        {
            _context = context;
        }

        // GET: api/npc
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Npc>>> GetPeople()
        {
            return await _context.npcs.ToListAsync();
        }

        // GET: api/npc/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Npc>> GetPerson(int id)
        {
            var person = await _context.npcs.FindAsync(id);

            if (person == null)
            {
                return NotFound();
            }

            return person;
        }

        // PUT: api/npc/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPerson(int id, Npc person)
        {
            if (id != person.Id)
            {
                return BadRequest();
            }

            _context.Entry(person).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PersonExists(id))
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

        // POST: api/npc
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Npc>> PostPerson(Npc person)
        {
            _context.npcs.Add(person);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPerson", new { id = person.Id }, person);
        }

        // DELETE: api/npc/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Npc>> DeletePerson(int id)
        {
            var person = await _context.npcs.FindAsync(id);
            if (person == null)
            {
                return NotFound();
            }

            _context.npcs.Remove(person);
            await _context.SaveChangesAsync();

            return person;
        }

        private bool PersonExists(int id)
        {
            return _context.npcs.Any(e => e.Id == id);
        }
    }
}
