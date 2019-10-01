using System;
using System.Collections.Generic;

namespace BRQ.HRT.Colaboradores.Dominio.Entidades
{
    public partial class TipoSkill
    {
        public TipoSkill()
        {
            Skill = new HashSet<Skill>();
        }

        public int Id { get; set; }
        public string Nome { get; set; }

        public ICollection<Skill> Skill { get; set; }
    }
}
