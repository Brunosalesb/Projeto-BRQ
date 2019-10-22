using BRQ.HRT.Colaboradores.Aplicacao.ViewModels;
using BRQ.HRT.Colaboradores.Aplicacao.ViewModels.Experiencia;
using System;
using System.Collections.Generic;
using System.Text;

namespace BRQ.HRT.Colaboradores.Aplicacao.Interfaces
{
    public interface IExperienciaService
    {
        void Update(CadastroExperienciaViewModel obj, int id);
        IEnumerable<ExperienciaViewModel> GetAll(int userId);
        IEnumerable<ExperienciaViewModel> ListarTodasExperiencias();
        ExperienciaViewModel BuscarExperienciaPorId(int id);
        void Add(CadastroExperienciaViewModel obj);
    }
}
