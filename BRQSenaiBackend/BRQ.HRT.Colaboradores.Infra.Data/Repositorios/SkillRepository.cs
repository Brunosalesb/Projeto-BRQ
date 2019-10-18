using BRQ.HRT.Colaboradores.Dominio.Entidades;
using BRQ.HRT.Colaboradores.Dominio.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BRQ.HRT.Colaboradores.Infra.Data.Repositorios
{
    public class SkillRepository : RepositoryBaseCollaborator<Skill>, ISkillRepository
    {
        public SkillRepository(ContextoColaboradores dbContext) : base(dbContext)
        {

        }

        //lista as skills de um usuario passando o id do usuario
        public List<SkillPessoa> ListaSkillsPorIdUsuario(int id)
        {
            using (ContextoColaboradores ctx = new ContextoColaboradores())
            {
                return ctx.SkillPessoa.Where(x => x.FkIdPessoaNavigation.Id == id).ToList();
            }
        }

        //lista todas as skills existentes incluindo o tipo de skill
        public List<Skill> ListaSkills()
        {
            using (ContextoColaboradores ctx = new ContextoColaboradores())
            {
                return ctx.Skill.Include(x => x.FkIdTipoSkillNavigation).ToList();
            }
        }
    }
}
