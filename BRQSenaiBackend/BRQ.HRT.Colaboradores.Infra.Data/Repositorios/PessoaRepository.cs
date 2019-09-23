using BRQ.HRT.Colaboradores.Dominio.Entidades;
using BRQ.HRT.Colaboradores.Dominio.Interfaces;
using BRQ.HRT.Colaboradores.Servicos.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace BRQ.HRT.Colaboradores.Infra.Data.Repositorios
{
    public class PessoaRepository : IPessoaRepository
    {
        public void AtribuirSKill(SkillPessoaViewModel dados)
        {
            throw new NotImplementedException();
        }

        public Pessoa BuscarPessoaPorID(int id)
        {
            throw new NotImplementedException();
        }

        public Pessoa BuscarPessoaPorMatricula(int Matricula)
        {
            throw new NotImplementedException();
        }

        public void CadastrarPessoa(PessoaViewModel Pessoa)
        {
            throw new NotImplementedException();
        }

        public void DesAtribuirSkill(SkillPessoaViewModel dados)
        {
            throw new NotImplementedException();
        }

        public void EditarPessoa(Pessoa Pessoa, int id)
        {
            throw new NotImplementedException();
        }

        public void ExcluirPessoa(int id)
        {
            throw new NotImplementedException();
        }

        public List<Pessoa> ListarTodasPessoas()
        {
            throw new NotImplementedException();
        }
    }
}
