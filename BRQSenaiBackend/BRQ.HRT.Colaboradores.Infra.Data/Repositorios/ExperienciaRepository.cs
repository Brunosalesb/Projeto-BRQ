using BRQ.HRT.Colaboradores.Dominio.Entidades;
using BRQ.HRT.Colaboradores.Dominio.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BRQ.HRT.Colaboradores.Infra.Data.Repositorios
{
    public class ExperienciaRepository : RepositoryBaseCollaborator<Experiencia>, IExperienciaRepository
    {
        public ExperienciaRepository(ContextoColaboradores dbContext) : base(dbContext)
        {
        }

        public List<Experiencia> ListarTodasExperiencias()
        {
            using (ContextoColaboradores ctx = new ContextoColaboradores())
            {
                return ctx.Experiencia.Include(x => x.FkIdTipoExperienciaNavigation).ToList();
            }
        }

        public Experiencia BuscarExperienciaPorId(int id)
        {
            using (ContextoColaboradores ctx = new ContextoColaboradores())
            {
                return ctx.Experiencia.Include(x => x.FkIdTipoExperienciaNavigation).Where(y => y.Id == id).FirstOrDefault();
            }

        }

        public List<Experiencia> BuscarExperienciaPorIdPessoa(int id)
        {
            using (ContextoColaboradores ctx = new ContextoColaboradores())
            {
                return ctx.Experiencia.Where(x => x.FkIdPessoaNavigation.Id == id).Include(y => y.FkIdTipoExperienciaNavigation).ToList();
            }
        }

    }
}
