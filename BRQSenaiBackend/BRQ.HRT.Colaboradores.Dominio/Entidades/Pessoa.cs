using System;
using System.Collections.Generic;

namespace BRQ.HRT.Colaboradores.Dominio.Entidades
{
    public partial class Pessoa
    {
        public Pessoa()
        {
            Contato = new HashSet<Contato>();
            Experiencia = new HashSet<Experiencia>();
            SkillPessoa = new HashSet<SkillPessoa>();
        }

        public int Id { get; set; }
        public string Matricula { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }
        public DateTime DtNasc { get; set; }
        public string Cep { get; set; }
        public string Logradouro { get; set; }
        public int? Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Pais { get; set; }
        public bool? Status { get; set; }

        public ICollection<Contato> Contato { get; set; }
        public ICollection<Experiencia> Experiencia { get; set; }
        public ICollection<SkillPessoa> SkillPessoa { get; set; }
    }
}
