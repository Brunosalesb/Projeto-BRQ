using BRQ.HRT.Colaboradores.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace BRQ.HRT.Colaboradores.Aplicacao.ViewModels.Skill
{
    public class CadastroSkillViewModel
    {
        public string Nome { get; set; }
        public ICollection<TipoSkill> IdTipoSkill { get; set; }
    }
}
