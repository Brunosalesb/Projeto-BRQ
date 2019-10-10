using BRQ.HRT.Colaboradores.Dominio.Entidades;
using BRQ.HRT.Colaboradores.Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BRQ.HRT.Colaboradores.Infra.Data.Repositorios
{
    public class SkillRepository : RepositoryBaseCollaborator<Skill>, ISkillRepository
    {
        public SkillRepository(ContextoColaboradores dbContext) : base(dbContext)
        {

        }

        public List<Skill> ListarSkillPorIdPessoa(int id)
        {
            throw new NotImplementedException();
        }
    }
}
