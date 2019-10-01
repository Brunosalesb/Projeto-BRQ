using System;
using System.Collections.Generic;

namespace BRQ.HRT.Colaboradores.Dominio.Entidades
{
    public partial class TipoContato
    {
        public TipoContato()
        {
            Contato = new HashSet<Contato>();
        }

        public int IdTipoContato { get; set; }
        public string Nome { get; set; }

        public ICollection<Contato> Contato { get; set; }
    }
}
