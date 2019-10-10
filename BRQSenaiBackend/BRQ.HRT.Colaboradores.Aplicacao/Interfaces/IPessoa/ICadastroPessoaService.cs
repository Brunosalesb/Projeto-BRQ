
using BRQ.HRT.Colaboradores.Aplicacao.ViewModels.Pessoa;
using System;
using System.Collections.Generic;
using System.Text;

namespace BRQ.HRT.Colaboradores.Aplicacao.Interfaces.Pessoa
{
    public interface ICadastroPessoaService 
    {
        void Add(CadastroPessoaViewModel obj);
        void Update(CadastroPessoaViewModel obj);
    }
}
