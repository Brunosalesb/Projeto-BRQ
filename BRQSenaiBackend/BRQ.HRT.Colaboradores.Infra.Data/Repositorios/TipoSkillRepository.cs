using BRQ.HRT.Colaboradores.Dominio.Entidades;
using BRQ.HRT.Colaboradores.Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BRQ.HRT.Colaboradores.Infra.Data.Repositorios
{
    public class TipoSkillRepository : RepositoryBaseCollaborator<TipoSkill>, ITipoSkillRepository
    {
        public TipoSkillRepository(ContextoColaboradores dbContext) : base(dbContext)
        {
        }
    }
}
