using System;
using System.Collections.Generic;
using System.Text;

namespace BRQ.HRT.Colaboradores.Aplicacao.ViewModels.VMExperiencia
{
    public class EditarExperienciaViewModel
    {
        public string Titulo { get; set; }
        public string Instituicao { get; set; }
        public string Descricao { get; set; }
        public DateTime DtInicio { get; set; }
        public DateTime DtFim { get; set; }
    }
}
