using BRQ.HRT.Colaboradores.Aplicacao.ViewModels;
using BRQ.HRT.Colaboradores.Aplicacao.ViewModels.TipoSkill;
using System;
using System.Collections.Generic;
using System.Text;

namespace BRQ.HRT.Colaboradores.Aplicacao.Interfaces.ISkill
{
    public interface ITipoSkillService
    {
      //void Update(TipoSkillViewModel obj);
      //IEnumerable<TipoSkillViewModel> GetAll(int userId);
        IEnumerable<TipoSkillViewModel> GetAll();
      //TipoSkillViewModel GetById(int id);
        void Add(CadastroTipoSkillViewModel obj);
    }
}
