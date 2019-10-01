using System;
using System.Collections.Generic;

namespace BRQ.HRT.Colaboradores.Dominio.Entidades
{
    public partial class Contato
    {
        public int Id { get; set; }
        public string Contato1 { get; set; }
        public int FkIdTipoContato { get; set; }
        public int FkIdPessoa { get; set; }

        public Pessoa FkIdPessoaNavigation { get; set; }
        public TipoContato FkIdTipoContatoNavigation { get; set; }
    }
}
