using System;
using System.Collections.Generic;

namespace BRQ.HRT.Colaboradores.Dominio.Entidades
{
    public partial class TipoExperiencia
    {
        public TipoExperiencia()
        {
            Experiencia = new HashSet<Experiencia>();
        }

        public int Id { get; set; }
        public string Nome { get; set; }

        public ICollection<Experiencia> Experiencia { get; set; }
    }
}
