
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CRUD_ENITY.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        private readonly DataContext _context;
        public UserController(DataContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<List<User>>> Get()
        {
            return Ok(await _context.Users.ToListAsync());

        }

        [HttpGet("{id}")]
        public async Task<ActionResult<User>> Get(int id)
        {
            var user = await _context.Users.FindAsync(id);
            if (user == null)
                return BadRequest("Not Found");
            return Ok(user);
        }
        [HttpPost]
        public async Task<ActionResult<User>> Post(User User)
        {
            _context.Users.Add(User);
            await _context.SaveChangesAsync();
            return Ok(await _context.Users.ToListAsync());

        }
        [HttpPut]
        public  async Task<ActionResult<User>> Put(User request)
        {
            var user = await _context.Users.FindAsync(request.DepartmentId);
            if (user == null)
                return BadRequest("Not Found");
            user.DepartmentName = request.DepartmentName;
            await _context.SaveChangesAsync();
            return Ok(await _context.Users.ToListAsync());
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult<User>> Delete(int id)
        {
            var user = await _context.Users.FindAsync(id);
                if (user == null)
                return BadRequest("Id Not Found");
                _context.Users.Remove(user);
            await _context.SaveChangesAsync();
            return Ok(await _context.Users.ToListAsync());
        }
    }
}

