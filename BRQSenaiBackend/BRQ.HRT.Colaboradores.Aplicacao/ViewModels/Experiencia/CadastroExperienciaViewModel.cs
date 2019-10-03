using System;
using System.Collections.Generic;
using System.Text;

namespace BRQ.HRT.Colaboradores.Aplicacao.ViewModels.Experiencia
{
    public class CadastroExperienciaViewModel
    {
        public string Titulo { get; set; }
        public string Instituicao { get; set; }
        public string Descricao { get; set; }
        public DateTime DtInicio { get; set; }
        public DateTime DtFim { get; set; }
        public int FkIdTipoExperiencia { get; set; }
        public int FkIdPessoa { get; set; }
    }
}
