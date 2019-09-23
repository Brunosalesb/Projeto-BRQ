using System;
using System.Collections.Generic;

namespace BRQ.HRT.Colaboradores.Dominio.Entidades
{
    public partial class Pessoa
    {
        public Pessoa()
        {
            Experiencia = new HashSet<Experiencia>();
            SkillsPessoa = new HashSet<SkillsPessoa>();
        }

        public int Id { get; set; }
        public int Matricula { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }
        public DateTime DtNasc { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Cep { get; set; }
        public string Logradouro { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }

        public ICollection<Experiencia> Experiencia { get; set; }
        public ICollection<SkillsPessoa> SkillsPessoa { get; set; }
    }
}
