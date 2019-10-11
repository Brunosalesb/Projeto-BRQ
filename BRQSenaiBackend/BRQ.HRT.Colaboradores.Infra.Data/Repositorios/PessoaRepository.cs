using BRQ.HRT.Colaboradores.Dominio.Entidades;
using BRQ.HRT.Colaboradores.Dominio.Interfaces;
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
            throw new NotImplementedException();
        }

        public Pessoa BuscarPessoaPorMatricula(int matricula)
        {
            using (ContextoColaboradores ctx = new ContextoColaboradores())
            {
                return ctx.Pessoa.Where(p => p.Matricula == matricula.ToString()).FirstOrDefault();
            }
        }

        public void DesAtribuirSkill(int id)
        {
            using (ContextoColaboradores ctx = new ContextoColaboradores())
            {
                SkillPessoa sp = ctx.SkillPessoa.FirstOrDefault();
                //ctx.SkillsPessoa.Remove(dados);
                //ctx.SaveChanges();
            }
        }
    }
}
