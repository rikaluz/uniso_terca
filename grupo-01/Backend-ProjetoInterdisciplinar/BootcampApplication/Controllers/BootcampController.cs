using Microsoft.AspNetCore.Mvc;
using BootcampApplication.model;
using Microsoft.EntityFrameworkCore;

namespace BootcampApplication.Controllers
{
    [ApiController]
    [Route("api/bootcamp")]
    public class BootcampController : ControllerBase
    {
        private readonly ApplicationDbContext context;

        public BootcampController(ApplicationDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Bootcamp>>> Get()
        {
            return await context.Bootcamps.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Bootcamp>> Get(int id)
        {
            var answer = await context.Bootcamps.FirstOrDefaultAsync(x => x.Id == id);
            if (answer == null)
            {
                return NotFound();
            }
            return answer;
        }

        [HttpPost]
        public async Task<ActionResult<int>> Post(Bootcamp bootcamp)
        {
            context.Bootcamps.Add(bootcamp);
            await context.SaveChangesAsync();
            return bootcamp.Id;
        }

        [HttpDelete("id")]
        public async Task<ActionResult> Delete(int id)
        {
            var bootcamp = await context.Bootcamps.FirstOrDefaultAsync(x => x.Id == id);
            if (bootcamp == null)
            {
                return NotFound();
            }

            context.Remove(bootcamp);
            await context.SaveChangesAsync();
            return NoContent();
        }

        [HttpPut] //atualizar
        public async Task<ActionResult> Put(Bootcamp bootcamp)
        {
            context.Attach(bootcamp).State = EntityState.Modified;
            await context.SaveChangesAsync();
            return NoContent();
        }
    }
}