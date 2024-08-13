using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ETMovies.DatabaseContext;
using ETMovies.Models;

namespace MoviesApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ReviewsController : Controller
    {
        private readonly MyDbContext dbContext;

        public ReviewsController(MyDbContext context)
        {
            dbContext = context;
        }

        // GET: Reviews
        [HttpGet]

        public async Task<ActionResult<IEnumerable<Review>>> GetAll()
        { 
            if(dbContext.Reviews == null )
                return NotFound();
            return await dbContext.Reviews.ToListAsync();
        
        
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Review>> GetReview(int id)
        {
            if (dbContext.Reviews == null)
                return NotFound();
            var review = await dbContext.Reviews.FindAsync(id);

            return review;

        }

        [HttpPost]
        public async Task<IActionResult> Post(Review review)
        {
            if (dbContext.Reviews == null)
                return Problem("Entity set 'MoviesRating.Reviews' is null. ");

            dbContext.Reviews.Add(review);
            await dbContext.SaveChangesAsync();

            return CreatedAtAction("GetReview", new { id = review.ReviewId }, review);

        }

    }
}
