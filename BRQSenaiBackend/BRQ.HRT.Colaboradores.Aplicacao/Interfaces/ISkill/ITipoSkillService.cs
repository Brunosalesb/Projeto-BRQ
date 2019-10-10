using BRQ.HRT.Colaboradores.Aplicacao.ViewModels;
using BRQ.HRT.Colaboradores.Aplicacao.ViewModels.Skill;
using System;
using System.Collections.Generic;
using System.Text;

namespace BRQ.HRT.Colaboradores.Aplicacao.Interfaces.ISkill
{
    public interface ITipoSkillService
    {
        void Update(SkillViewModel obj);
        IEnumerable<SkillViewModel> GetAll(int userId);
        IEnumerable<SkillViewModel> GetAll();
        SkillViewModel GetById(int id);
        void Add(CadastroSkillViewModel obj);
    }
}
