using BRQ.HRT.Colaboradores.Dominio.Entidades;
using BRQ.HRT.Colaboradores.Dominio.Interfaces;
using BRQ.HRT.Colaboradores.Servicos.ViewModel;
using System.Collections.Generic;
using System.Linq;

namespace BRQ.HRT.Colaboradores.Infra.Data.Repositorios
{
   public class ExperienciaRepository : IExperienciaRepository
    {
        public void AtualizarExperiencia(int id, Experiencia xp)
        {
            using (ContextoColaboradores ctx = new ContextoColaboradores())
            {
                ctx.Experiencia.Update(xp);
                ctx.SaveChanges();
            }
        }

        public Experiencia BuscarExperienciaPorID(int id)
        {
            using (ContextoColaboradores ctx = new ContextoColaboradores())
            {
                return ctx.Experiencia.Find(id);
            }
        }

        public void CadastrarExperiencia(ExperienciaViewModel exp)
        {
            using (ContextoColaboradores ctx = new ContextoColaboradores())
            {
                Experiencia ex = new Experiencia {
                    Titulo = exp.Titulo,
                    Instituicao = exp.Instituicao,
                    Descricao = exp.Descricao,
                    DtInicio = exp.DtInicio,
                    DtFim = exp.DtFim,
                    IdTipoExperiencia = exp.IdTipoExperiencia,
                    IdPessoa = exp.IdPessoa
                };

                ctx.Experiencia.Add(ex);
                ctx.SaveChanges();
            }
        }

        public void DeletarExperiencia(int id)
        {
            using (ContextoColaboradores ctx = new ContextoColaboradores())
            {
                Experiencia experienciaProcurada = BuscarExperienciaPorID(id);
                ctx.Experiencia.Remove(experienciaProcurada);
                ctx.SaveChanges();
            }
        }

        public List<Experiencia> ListarExperienciasPorIdPessoa(int id)
        {
            using (ContextoColaboradores ctx = new ContextoColaboradores())
            {
                return ctx.Experiencia.Where(x => x.IdPessoa == id).ToList();
            }
        }

        public List<Experiencia> ListarTodasExperiencias()
        {
            using (ContextoColaboradores ctx = new ContextoColaboradores())
            {
                return ctx.Experiencia.ToList();
            }
        }
    }
}
