using BRQ.HRT.Colaboradores.Aplicacao.ViewModels;
using BRQ.HRT.Colaboradores.Aplicacao.ViewModels.Experiencia;
using System;
using System.Collections.Generic;
using System.Text;

namespace BRQ.HRT.Colaboradores.Aplicacao.Interfaces
{
    public interface IExperienciaService
    {
        void Update(ExperienciaViewModel obj);
        IEnumerable<ExperienciaViewModel> GetAll(int userId);
        IEnumerable<ExperienciaViewModel> GetAll();
        ExperienciaViewModel GetById(int id);
        void Add(CadastroExperienciaViewModel obj);
    }
}
