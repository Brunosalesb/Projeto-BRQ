using System;
using System.Collections.Generic;

namespace BRQ.HRT.Colaboradores.Dominio.Entidades
{
    public partial class SkillsPessoa
    {
        public int IdSkillPessoa { get; set; }
        public int IdPessoa { get; set; }
        public int IdSkill { get; set; }

        public Pessoa IdPessoaNavigation { get; set; }
        public Skill IdSkillNavigation { get; set; }
    }
}
