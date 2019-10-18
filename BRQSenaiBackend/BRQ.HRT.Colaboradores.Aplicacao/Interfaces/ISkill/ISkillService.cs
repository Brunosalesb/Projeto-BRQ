using BRQ.HRT.Colaboradores.Aplicacao.ViewModels;
using BRQ.HRT.Colaboradores.Aplicacao.ViewModels.Skill;
using BRQ.HRT.Colaboradores.Aplicacao.ViewModels.VMSkill;
using BRQ.HRT.Colaboradores.Aplicacao.ViewModels.VMSkillPessoa;
using BRQ.HRT.Colaboradores.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace BRQ.HRT.Colaboradores.Aplicacao.Interfaces
{
    public interface ISkillService
    {
        void Update(CadastroSkillViewModel obj, int id);
        IEnumerable<SkillPorIdViewModel> GetAll(int userId);
        IEnumerable<SkillViewModel> GetAll();
        CadastroSkillViewModel GetById(int id);
        void Add(CadastroSkillViewModel obj);

    }
}
