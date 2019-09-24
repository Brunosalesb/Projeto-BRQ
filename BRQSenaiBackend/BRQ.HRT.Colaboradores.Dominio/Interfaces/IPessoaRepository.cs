using BRQ.HRT.Colaboradores.Dominio.Entidades;
using BRQ.HRT.Colaboradores.Servicos.ViewModel;
using System.Collections.Generic;

namespace BRQ.HRT.Colaboradores.Dominio.Interfaces
{
    public interface IPessoaRepository
    {
        void CadastrarPessoa(PessoaViewModel pessoa);

        void EditarPessoa(Pessoa pessoa);

        void ExcluirPessoa(int id);

        List<Pessoa> ListarTodasPessoas();

        Pessoa BuscarPessoaPorID(int id);

        Pessoa BuscarPessoaPorMatricula(int matricula);

        void AtribuirSKill(SkillPessoaViewModel dados);

        void DesAtribuirSkill(SkillsPessoa dados);
    }
}
