﻿using BRQ.HRT.Colaboradores.Aplicacao.ViewModels.TipoSkill;
using BRQ.HRT.Colaboradores.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace BRQ.HRT.Colaboradores.Aplicacao.ViewModels
{
    public class SkillViewModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public TipoSkillViewModel FkIdTipoSkillNavigation { get; set; }

    }
}