using Microsoft.AspNetCore.Mvc;
using Magic8Ball.API.Data;
using Microsoft.EntityFrameworkCore;

namespace Magic8Ball.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AnswersController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly Random _random = new();

        public AnswersController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet("random")]
        public async Task<IActionResult> GetRandomAnswer()
        {
            var count = await _context.MagicAnswers.CountAsync();
            if (count == 0)
                return NotFound("No answers available");

            var index = _random.Next(count);
            var answer = await _context.MagicAnswers.Skip(index).FirstAsync();

            return Ok(answer);
        }
    }
}
