using BRQ.HRT.Colaboradores.Aplicacao.ViewModels.TipoSkill;
using BRQ.HRT.Colaboradores.Aplicacao.ViewModels.VMPessoa;
using System;
using System.Collections.Generic;
using System.Text;

namespace BRQ.HRT.Colaboradores.Aplicacao.ViewModels.VMSkill
{
    public class SkillPorIdViewModel
    {
        public SkillViewModel FkIdSkillNavigation { get; set; }

        public TipoSkillViewModel FkIdTipoSkillNavigation { get; set; }

    }
}
