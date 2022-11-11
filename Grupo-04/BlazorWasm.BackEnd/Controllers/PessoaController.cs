using BlazorWasm.Compartilhado.Entidades;
using BlazorWasmServer.Server;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorWasmServer.Server.Controllers
{
    [ApiController]

    [Route("api/Pessoa")]
    public class PessoaController : ControllerBase
    {
        private readonly ApplicationDbContext context;
        public PessoaController(ApplicationDbContext context)
        {
            this.context = context;


        }
        [HttpPost]
        public async Task<ActionResult<int>> Post(Pessoa pessoa)
        {

            context.Pessoa.Add(pessoa);
            await context.SaveChangesAsync();
            return pessoa.Id;

        }

        [HttpGet]
        public async Task<ActionResult<List<Pessoa>>> Get()
        {
            return await context.Pessoa.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Pessoa>> Get(int id)
        {
            var resp = await context.Pessoa.FirstOrDefaultAsync(x => x.Id == id);
            if (resp == null)
            {
                return NotFound();
            }
            return resp;
        }



        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var pessoa = await context.Pessoa.FirstOrDefaultAsync(x => x.Id == id);
            if (pessoa == null)
            {
                return NotFound();
            }
            context.Remove(pessoa);
            await context.SaveChangesAsync();
            return NoContent();
        }
        [HttpPut]
        public async Task<ActionResult> Put(Pessoa pessoa)
        {
            context.Attach(pessoa).State = EntityState.Modified;
            await context.SaveChangesAsync();
            return NoContent();

        }
    }
}


