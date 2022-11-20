using Microsoft.AspNetCore.Mvc;
using BootcampApplication.model;
using Microsoft.EntityFrameworkCore;

namespace BootcampApplication.Controllers
{
    [ApiController]
    [Route("api/user")]
    public class UserController : ControllerBase
    {
        private readonly ApplicationDbContext context;

        public UserController(ApplicationDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<User>>> Get()
        {
            return await context.Users.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<User>> Get(int id)
        {
            var answer = await context.Users.FirstOrDefaultAsync(x => x.Id == id);
            if (answer == null)
            {
                return NotFound();
            }
            return answer;
        }

        [HttpPost]
        public async Task<ActionResult<int>> Post(User user)
        {
            context.Users.Add(user);
            await context.SaveChangesAsync();
            return user.Id;
        }

        [HttpDelete("id")]
        public async Task<ActionResult> Delete(int id)
        {
            var user = await context.Users.FirstOrDefaultAsync(x => x.Id == id);
            if (user == null)
            {
                return NotFound();
            }

            context.Remove(user);
            await context.SaveChangesAsync();
            return NoContent();
        }

        [HttpPut] //atualizar
        public async Task<ActionResult> Put(User user)
        {
            context.Attach(user).State = EntityState.Modified;
            await context.SaveChangesAsync();
            return NoContent();
        }
    }
}
