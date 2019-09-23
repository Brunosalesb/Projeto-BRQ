using System;
using System.Collections.Generic;

namespace BRQ.HRT.Colaboradores.Dominio.Entidades
{
    public partial class Skill
    {
        public Skill()
        {
            SkillsPessoa = new HashSet<SkillsPessoa>();
        }

        public int IdSkill { get; set; }
        public string NomeSkill { get; set; }
        public int IdTipoSkill { get; set; }

        public TipoSkill IdTipoSkillNavigation { get; set; }
        public ICollection<SkillsPessoa> SkillsPessoa { get; set; }
    }
}
