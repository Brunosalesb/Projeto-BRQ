﻿using BRQ.HRT.Colaboradores.Aplicacao.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace BRQ.HRT.Colaboradores.Aplicacao.Interfaces.Pessoa
{
   public interface IPessoaContatoService
    {
        PessoaContatoViewModel GetById(int id);

         IEnumerable<PessoaContatoViewModel> GetAll();
    }
}