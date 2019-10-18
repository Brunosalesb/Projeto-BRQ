using BRQ.HRT.Colaboradores.Dominio.Entidades;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BRQ.HRT.Colaboradores.Aplicacao.ViewModels.Pessoa
{
    public class ContatoViewModel
    {
        [JsonProperty(PropertyName = "Contato")]
        public string Contato1 { get; set; }
        [JsonProperty(PropertyName = "TipoDeContato")]
        public TipoContatoViewModel FkIdTipoContatoNavigation { get; set; }
    }
}
