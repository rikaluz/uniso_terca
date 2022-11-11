using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace BlazorWasm.Compartilhado.Entidades
{
    public class Pessoa : IEntity
    {
        public int Id { get; set; }

        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public int Idade { get; set; }
        public string Sexo { get; set; }
    }
}