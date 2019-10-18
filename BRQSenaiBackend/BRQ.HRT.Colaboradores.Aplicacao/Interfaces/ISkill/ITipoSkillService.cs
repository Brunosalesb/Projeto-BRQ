using BRQ.HRT.Colaboradores.Aplicacao.ViewModels;
using BRQ.HRT.Colaboradores.Aplicacao.ViewModels.TipoSkill;
using System;
using System.Collections.Generic;
using System.Text;

namespace BRQ.HRT.Colaboradores.Aplicacao.Interfaces.ISkill
{
    public interface ITipoSkillService
    {
        IEnumerable<TipoSkillViewModel> GetAll();
        void Add(CadastroTipoSkillViewModel obj);
    }
}
