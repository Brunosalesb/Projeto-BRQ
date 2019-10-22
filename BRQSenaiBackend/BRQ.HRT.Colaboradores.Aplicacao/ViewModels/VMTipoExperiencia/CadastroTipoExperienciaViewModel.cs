using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BRQ.HRT.Colaboradores.Aplicacao.ViewModels.VMTipoExperiencia
{
    public class CadastroTipoExperienciaViewModel
    {
        [JsonProperty(PropertyName = "nomeTipoExperiencia")]
        public string Nome { get; set; }
    }
}
