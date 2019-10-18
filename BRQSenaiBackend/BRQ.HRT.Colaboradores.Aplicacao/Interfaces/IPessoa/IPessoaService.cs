using BRQ.HRT.Colaboradores.Aplicacao.ViewModels.VMPessoa;
using BRQ.HRT.Colaboradores.Aplicacao.ViewModels.VMSkillPessoa;
using System;
using System.Collections.Generic;
using System.Text;

namespace BRQ.HRT.Colaboradores.Aplicacao.Interfaces.IPessoa
{
   public interface IPessoaService
    {
        PessoaViewModel GetById(int id);

        IEnumerable<PessoaViewModel> GetAll();
        void AtribuirSkill(SkillPessoaViewModel skillPessoa);
    }
}
