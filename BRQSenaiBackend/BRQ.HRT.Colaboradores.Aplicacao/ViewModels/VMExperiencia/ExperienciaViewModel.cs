﻿using BRQ.HRT.Colaboradores.Aplicacao.Extensions;
using BRQ.HRT.Colaboradores.Aplicacao.ViewModels.VMTipoExperiencia;
using BRQ.HRT.Colaboradores.Dominio.Entidades;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Text;

namespace BRQ.HRT.Colaboradores.Aplicacao.ViewModels
{
    public class ExperienciaViewModel
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Instituicao { get; set; }
        public string Descricao { get; set; }
        [JsonProperty(PropertyName = "dataInicio")]
        [JsonConverter(typeof(DateFormatConverter), "dd-MM-yyyy")]
        public DateTime DtInicio { get; set; }
        [JsonProperty(PropertyName = "dataFim")]
        [JsonConverter(typeof(DateFormatConverter), "dd-MM-yyyy")]
        public DateTime DtFim { get; set; }
        [JsonProperty(PropertyName = "tipoExperiencia")]
        public CadastroTipoExperienciaViewModel FkIdTipoExperienciaNavigation { get; set; }
    }
}
