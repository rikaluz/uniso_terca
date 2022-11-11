using BlazorWasm.Compartilhado.Entidades;
using BlazorWasm.FrontEnd.Helpers;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorWasm.FrontEnd.Repositorio
{
    public class RepositorioPessoa : IRepository<Pessoa>
    {
        private readonly IHttpService httpService;
        private string url = "api/Pessoa";

        public RepositorioPessoa(IHttpService httpService)
        {
            this.httpService = httpService;
        }

        public async Task<List<Pessoa>> Get()
        {
            var response = await httpService.Get<List<Pessoa>>(url);

            if (!response.Sucesso)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }
        public async Task<Pessoa> Get(int Id)
        {
            var response = await httpService.Get<Pessoa>($"{url}/{Id}");
            if (!response.Sucesso)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }


        public async Task Add(Pessoa item)
        {

            var response = await httpService.Post(url, item);
            if (response.Sucesso == false)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }
        public async Task<int> AddAndGetId(Pessoa item)
        {
            var response = await httpService.Post<Pessoa, int>(url, item);
            if (response.Sucesso == false)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }


        public async Task Update(Pessoa item)
        {
            var response = await httpService.Put(url, item);
            if (!response.Sucesso)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }

        public async Task Delete(int Id)
        {
            var response = await httpService.Delete($"{url}/{Id}");
            if (!response.Sucesso)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }


    }
}
