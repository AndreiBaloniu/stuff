using ETMovies.DatabaseContext;
using ETMovies.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MovieApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PeopleController : Controller
    {
        private readonly MyDbContext dbContext;

        public PeopleController(MyDbContext context)
        {
            this.dbContext = context;
        }

        // GET: api/values
        [HttpGet]

        public async Task<ActionResult<IEnumerable<Person>>> GetAll()
        {
            if (dbContext.Persons == null)
                return NotFound();
            return await dbContext.Persons.OrderByDescending(p => p.FirstName + " " + p.LastName).ToListAsync();

        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Person>> GetPerson(int id)
        { 
            if(dbContext.Persons == null)
                return NotFound();
            var person = await dbContext.Persons.FindAsync(id);

            return person;
        
        }

        [HttpPost]
        public async Task<IActionResult> Post(Person person)
        {
            if (dbContext.Persons == null)
                return Problem("Entity set 'MoviesRating.Persons' is null. ");

            dbContext.Persons.Add(person);
            await dbContext.SaveChangesAsync();

            return CreatedAtAction("GetPerson", new { id = person.PersonID }, person);
        
        }
    }
}
