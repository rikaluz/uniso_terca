using BlazorWasm.Compartilhado.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace BlazorWasm.FrontEnd.Repositorio
{
    public class RepositoryInMemoryPessoa : IRepository<Pessoa>
    {
        public List<Pessoa> ListaPessoa = new List<Pessoa>();
        static int idBase = 0;
        public Task Add(Pessoa item)
        {
            item.Id = idBase++;
            ListaPessoa.Add(item);
            return Task.CompletedTask;
        }



        public Task<int> AddAndGetId(Pessoa item)
        {
            item.Id = idBase++;
            ListaPessoa.Add(item);
            return Task.FromResult(item.Id);
        }



        public Task Delete(int Id)
        {
            var index = ListaPessoa.FindIndex(o => o.Id == Id);
            ListaPessoa.RemoveAt(index);
            return Task.CompletedTask;
        }



        public Task<List<Pessoa>> Get()
        {
            return Task.FromResult(ListaPessoa);
        }



        public Task<Pessoa> Get(int id)
        {
            return Task.FromResult(ListaPessoa.FirstOrDefault(o => o.Id == id));
        }



        public Task Update(Pessoa item)
        {
            var index = ListaPessoa.FindIndex(o => o.Id == item.Id);
            ListaPessoa[index] = item;
            return Task.CompletedTask;
        }



        public RepositoryInMemoryPessoa()
        {
            Pessoa p = new Pessoa();
            p.Nome = "Jose";
            ListaPessoa.Add(p);
            p = new Pessoa();
            p.Nome = "Ana";
            ListaPessoa.Add(p);
            p = new Pessoa();
            p.Nome = "Murilo";
            ListaPessoa.Add(p);
            p = new Pessoa();
            p.Nome = "Renata";
            ListaPessoa.Add(p);



        }
    }
}