using BRQ.HRT.Colaboradores.Dominio.Entidades;
using BRQ.HRT.Colaboradores.Dominio.Interfaces;
using BRQ.HRT.Colaboradores.Servicos.ViewModel;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace BRQ.HRT.Colaboradores.Infra.Data.Repositorios
{
    public class PessoaRepository : IPessoaRepository
    {
        public void AtribuirSKill(SkillPessoaViewModel dados)
        {
            using (ContextoColaboradores ctx = new ContextoColaboradores())
            {
                SkillsPessoa p = new SkillsPessoa
                {
                    IdPessoa = dados.IdPessoa,
                    IdSkill = dados.IdSkill
                };
                ctx.SkillsPessoa.Add(p);
                ctx.SaveChanges();
            }
        }

        public Pessoa BuscarPessoaPorID(int id)
        {
            using (ContextoColaboradores ctx = new ContextoColaboradores())
            {
                return ctx.Pessoa.Include(p => p.Experiencia).Include(p => p.SkillsPessoa).Where(p => p.Id == id).FirstOrDefault();
            }
        }

        public Pessoa BuscarPessoaPorMatricula(int matricula)
        {
            using (ContextoColaboradores ctx = new ContextoColaboradores())
            {
                return ctx.Pessoa.Where(p => p.Matricula == matricula).FirstOrDefault();
            }
        }

        public void CadastrarPessoa(PessoaViewModel pessoa)
        {
            using (ContextoColaboradores ctx = new ContextoColaboradores())
            {
                Pessoa p = new Pessoa
                {
                    Nome = pessoa.Nome,
                    Matricula = pessoa.Matricula,
                    Cpf = pessoa.Cpf,
                    Rg = pessoa.Rg,
                    Telefone = pessoa.Telefone,
                    Email = pessoa.Email
                };
                ctx.Pessoa.Add(p);
                ctx.SaveChanges();

            }
        }

        public void DesAtribuirSkill(SkillsPessoa dados)
        {
            using (ContextoColaboradores ctx = new ContextoColaboradores())
            {
                ctx.SkillsPessoa.Remove(dados);
                ctx.SaveChanges();
            }
        }

        public void EditarPessoa(Pessoa pessoa)
        {
            using (ContextoColaboradores ctx = new ContextoColaboradores())
            {
                ctx.Pessoa.Update(pessoa);
                ctx.SaveChanges();
            }
        }

        public void ExcluirPessoa(int id)
        {
            using (ContextoColaboradores ctx = new ContextoColaboradores())
            {
                Pessoa p = ctx.Pessoa.Where(x => x.Id == id).FirstOrDefault();
                ctx.Pessoa.Remove(p);
                ctx.SaveChanges();
            }
        }

        public List<Pessoa> ListarTodasPessoas()
        {
            using (ContextoColaboradores ctx = new ContextoColaboradores()) {
                return ctx.Pessoa.Include(x => x.Experiencia).Include(x => x.SkillsPessoa).ToList();
            }
        }
    }
}
