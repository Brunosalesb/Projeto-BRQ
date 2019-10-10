using BRQ.HRT.Colaboradores.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace BRQ.HRT.Colaboradores.Aplicacao.ViewModels.Pessoa
{
    public class ContatoViewModel
    {
        public string Contato { get; set; }
        public TipoContatoViewModel TipoContato { get; set; }
    }
}
