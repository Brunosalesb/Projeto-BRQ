using BRQ.HRT.Colaboradores.Dominio.Entidades;
using BRQ.HRT.Colaboradores.Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BRQ.HRT.Colaboradores.Infra.Data.Repositorios
{
    public class TipoExperienciaRepository : ITipoExperienciaRepository
    {
        public void CadastrarTipoExperiencia(string nome)
        {
            throw new NotImplementedException();
        }

        public void DeletarTipoExperiencia(int id)
        {
            throw new NotImplementedException();
        }

        public void EditarTipoExperiencia(int id, string nome)
        {
            throw new NotImplementedException();
        }

        public List<TipoExperiencia> ListarTodosTiposExperiencia()
        {
            using (ContextoColaboradores ctx = new ContextoColaboradores())
            {
                return ctx.TipoExperiencia.ToList();
            }
        }
    }
}
