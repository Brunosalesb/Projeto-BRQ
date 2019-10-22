using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BRQ.HRT.Colaboradores.Aplicacao.ViewModels.VMContato
{
    public class ContatoCadastroViewModel
    {
        [JsonProperty(PropertyName = "NomeContato")]
        public string Contato1 { get; set; }
        [JsonProperty(PropertyName = "IdTipoContato")]
        public int FkIdTipoContato { get; set; }
        [JsonProperty(PropertyName = "IdPessoa")]
        public int FkIdPessoa { get; set; }
    }
}
