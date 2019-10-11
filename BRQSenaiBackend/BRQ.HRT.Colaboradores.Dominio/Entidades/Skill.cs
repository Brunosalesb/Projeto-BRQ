using System;
using System.Collections.Generic;

namespace BRQ.HRT.Colaboradores.Dominio.Entidades
{
    public partial class Skill
    {
        public Skill()
        {
            SkillPessoa = new HashSet<SkillPessoa>();
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public int FkIdTipoSkill { get; set; }

        public TipoSkill FkIdTipoSkillNavigation { get; set; }
        public ICollection<SkillPessoa> SkillPessoa { get; set; }
    }
}
