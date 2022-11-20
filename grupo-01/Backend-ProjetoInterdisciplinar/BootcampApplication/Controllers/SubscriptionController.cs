using Microsoft.AspNetCore.Mvc;
using BootcampApplication.model;
using Microsoft.EntityFrameworkCore;

namespace BootcampApplication.Controllers
{
    [ApiController]
    [Route("api/subscription")]
    public class SubscriptionController : ControllerBase
    {
        private readonly ApplicationDbContext context;

        public SubscriptionController(ApplicationDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Subscription>>> Get()
        {
            return await context.Subscriptions.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Subscription>> Get(int id)
        {
            var answer = await context.Subscriptions.FirstOrDefaultAsync(x => x.Id == id);
            if (answer == null)
            {
                return NotFound();
            }
            return answer;
        }

        [HttpPost]
        public async Task<ActionResult<int>> Post(Subscription subscription)
        {
            context.Subscriptions.Add(subscription);
            await context.SaveChangesAsync();
            return subscription.Id;
        }

        [HttpDelete("id")]
        public async Task<ActionResult> Delete(int id)
        {
            var subscription = await context.Subscriptions.FirstOrDefaultAsync(x => x.Id == id);
            if (subscription == null)
            {
                return NotFound();
            }

            context.Remove(subscription);
            await context.SaveChangesAsync();
            return NoContent();
        }

        [HttpPut] //atualizar
        public async Task<ActionResult> Put(Subscription subscription)
        {
            context.Attach(subscription).State = EntityState.Modified;
            await context.SaveChangesAsync();
            return NoContent();
        }
    }
}

