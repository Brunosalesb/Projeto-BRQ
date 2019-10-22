using BRQ.HRT.Colaboradores.Aplicacao.ViewModels.VMContato;
using System;
using System.Collections.Generic;
using System.Text;

namespace BRQ.HRT.Colaboradores.Aplicacao.Interfaces
{
    public interface IContatoService
    {
        void Add(ContatoCadastroViewModel obj);
        void Update(ContatoCadastroViewModel obj, int id);
    }
}
