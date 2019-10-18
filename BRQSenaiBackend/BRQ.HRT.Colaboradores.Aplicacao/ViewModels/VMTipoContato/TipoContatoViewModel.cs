using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BRQ.HRT.Colaboradores.Aplicacao.ViewModels.Pessoa
{
    public class TipoContatoViewModel
    {
        [JsonProperty(PropertyName = "NomeTipoContato")]
        public string Nome { get; set; }
    }
}
