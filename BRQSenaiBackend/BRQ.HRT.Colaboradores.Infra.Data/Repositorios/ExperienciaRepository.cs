using BRQ.HRT.Colaboradores.Dominio.Entidades;
using BRQ.HRT.Colaboradores.Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BRQ.HRT.Colaboradores.Infra.Data.Repositorios
{
    public class ExperienciaRepository : RepositoryBaseCollaborator<Experiencia>, IExperienciaRepository
    {
        public ExperienciaRepository(ContextoColaboradores dbContext) : base(dbContext)
        {
        }

        public List<Experiencia> ListarExperienciasPorIdPessoa(int id)
        {
            throw new NotImplementedException();
        }
    }
}
