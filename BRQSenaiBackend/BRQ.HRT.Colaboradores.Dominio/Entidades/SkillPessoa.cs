using System;
using System.Collections.Generic;

namespace BRQ.HRT.Colaboradores.Dominio.Entidades
{
    public partial class SkillPessoa
    {
        public int Id { get; set; }
        public int FkIdPessoa { get; set; }
        public int FkIdSkill { get; set; }

        public Pessoa FkIdPessoaNavigation { get; set; }
        public Skill FkIdSkillNavigation { get; set; }
    }
}
