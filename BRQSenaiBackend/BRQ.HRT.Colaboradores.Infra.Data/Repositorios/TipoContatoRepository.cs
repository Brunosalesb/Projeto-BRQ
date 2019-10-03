﻿using BRQ.HRT.Colaboradores.Dominio.Entidades;
using BRQ.HRT.Colaboradores.Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BRQ.HRT.Colaboradores.Infra.Data.Repositorios
{
    public class TipoContatoRepository : RepositoryBaseCollaborator<TipoContato>, ITipoContatoRepository
    {
        public TipoContatoRepository(ContextoColaboradores dbContext) : base(dbContext)
        {
        }
    }
}