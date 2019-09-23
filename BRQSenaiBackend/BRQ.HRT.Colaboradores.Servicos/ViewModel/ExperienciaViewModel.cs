using System;
using System.Collections.Generic;
using System.Text;

namespace BRQ.HRT.Colaboradores.Servicos.ViewModel
{
   public class ExperienciaViewModel
    {
        public string Titulo { get; set; }

        public string Instituicao { get; set; }

        public string Descricao { get; set; }

        public DateTime DtInicio { get; set; }

        public DateTime DtFim { get; set; }

        public int IdTipoExperiencia { get; set; }

        public int IdPessoa { get; set; }
    }
}
