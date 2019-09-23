using System;
using System.Collections.Generic;

namespace BRQ.HRT.Colaboradores.Dominio.Entidades
{
    public partial class Experiencia
    {
        public int IdExperiencia { get; set; }

        public string Titulo { get; set; }

        public string Instituicao { get; set; }

        public string Descricao { get; set; }

        public DateTime DtInicio { get; set; }

        public DateTime DtFim { get; set; }

        public int IdTipoExperiencia { get; set; }

        public int IdPessoa { get; set; }

        public Pessoa IdPessoaNavigation { get; set; }
        public TipoExperiencia IdTipoExperienciaNavigation { get; set; }
    }
}
