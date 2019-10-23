using BRQ.HRT.Colaboradores.Aplicacao.ViewModels.VMTipoExperiencia;
using System;
using System.Collections.Generic;
using System.Text;

namespace BRQ.HRT.Colaboradores.Aplicacao.Interfaces.ITipoExperiencia
{
    public interface ITipoExperienciaService 
    {
        void Update(CadastroTipoExperienciaViewModel obj, int id);
        void Add(CadastroTipoExperienciaViewModel obj);
        IEnumerable<TipoExperienciaViewModel> GetAll();
    }
}
