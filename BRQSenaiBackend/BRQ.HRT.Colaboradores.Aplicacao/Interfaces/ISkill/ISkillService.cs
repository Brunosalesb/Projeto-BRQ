using BRQ.HRT.Colaboradores.Aplicacao.ViewModels;
using BRQ.HRT.Colaboradores.Aplicacao.ViewModels.Skill;
using BRQ.HRT.Colaboradores.Aplicacao.ViewModels.VMSkillPessoa;
using System;
using System.Collections.Generic;
using System.Text;

namespace BRQ.HRT.Colaboradores.Aplicacao.Interfaces
{
    public interface ISkillService
    {
        void Update(SkillViewModel obj);
        IEnumerable<SkillPessoaViewModel> GetAll(int userId);
        IEnumerable<SkillViewModel> GetAll();
        SkillViewModel GetById(int id);
        void Add(CadastroSkillViewModel obj);
    }
}
