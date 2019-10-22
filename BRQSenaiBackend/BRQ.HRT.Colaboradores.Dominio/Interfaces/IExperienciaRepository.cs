using BRQ.HRT.Colaboradores.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace BRQ.HRT.Colaboradores.Dominio.Interfaces
{
    public interface IExperienciaRepository : IBaseRepository<Experiencia>
    {
        Experiencia BuscarExperienciaPorId(int id);
        List<Experiencia> BuscarExperienciaPorIdPessoa(int id);
        List<Experiencia> ListarTodasExperiencias();
    }
}
