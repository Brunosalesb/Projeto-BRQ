using BRQ.HRT.Colaboradores.Dominio.Entidades;
using BRQ.HRT.Colaboradores.Dominio.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BRQ.HRT.Colaboradores.Infra.Data.Repositorios
{
    public class PessoaRepository : RepositoryBaseCollaborator<Pessoa>, IPessoaRepository
    {

        public PessoaRepository(ContextoColaboradores dbContext) : base(dbContext)
        {
        }

        public void AtribuirSKill(SkillPessoa dados)
        {
            using (ContextoColaboradores ctx = new ContextoColaboradores())
            {
                ctx.SkillPessoa.Add(dados);
                ctx.SaveChanges();
            }
            }

        public List<Pessoa> BuscarTodosDados()
        {
            using (ContextoColaboradores ctx = new ContextoColaboradores())
            {
                return ctx.Pessoa.Include(x => x.Contato).Include("Contato.FkIdTipoContatoNavigation").Include(y => y.Experiencia).Include("Experiencia.FkIdTipoExperienciaNavigation").Include(v=> v.SkillPessoa).Include("SkillPessoa.FkIdSkillNavigation").Include("SkillPessoa.FkIdSkillNavigation.FkIdTipoSkillNavigation").AsNoTracking().ToList();
            }

            }

        public Pessoa BuscarTodosDadosPorID(int id)
        {
            using (ContextoColaboradores ctx = new ContextoColaboradores())
            {
                return ctx.Pessoa.Include(x => x.Contato).Include("Contato.FkIdTipoContatoNavigation").Include(y => y.Experiencia).Include("Experiencia.FkIdTipoExperienciaNavigation").Include(v => v.SkillPessoa).Include("SkillPessoa.FkIdSkillNavigation").Include("SkillPessoa.FkIdSkillNavigation.FkIdTipoSkillNavigation").AsNoTracking().Where(x => x.Id == id).FirstOrDefault();
            }
        }

        public Pessoa BuscarPessoaPorMatricula(String matricula)
        {
            using (ContextoColaboradores ctx = new ContextoColaboradores())
            {
                return ctx.Pessoa.AsNoTracking().Where(p => p.Matricula == matricula.ToString()).FirstOrDefault();
            }
        }

        public void DesAtribuirSkill(int id)
        {
            using (ContextoColaboradores ctx = new ContextoColaboradores())
            {
                SkillPessoa sp = ctx.SkillPessoa.AsNoTracking().Where(x => x.Id == id).FirstOrDefault();
                ctx.SkillPessoa.Remove(sp);
                ctx.SaveChanges();
            }
        }
    }
}
