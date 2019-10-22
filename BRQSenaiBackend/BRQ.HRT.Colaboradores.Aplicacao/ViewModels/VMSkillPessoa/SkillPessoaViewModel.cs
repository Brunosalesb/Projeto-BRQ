using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BRQ.HRT.Colaboradores.Aplicacao.ViewModels.VMSkillPessoa
{
   public class SkillPessoaViewModel
    {
        [JsonProperty(PropertyName = "IdSkillPessoa")]
        public int Id { get; set; }
        [JsonProperty(PropertyName = "Skill")]
        public SkillViewModel FkIdSkillNavigation { get; set; }
    }
}
