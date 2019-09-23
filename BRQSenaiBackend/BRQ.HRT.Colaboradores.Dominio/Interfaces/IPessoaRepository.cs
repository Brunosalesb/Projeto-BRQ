using BRQ.HRT.Colaboradores.Dominio.Entidades;
using BRQ.HRT.Colaboradores.Servicos.ViewModel;
using System.Collections.Generic;

namespace BRQ.HRT.Colaboradores.Dominio.Interfaces
{
    public interface IPessoaRepository
    {
        void CadastrarPessoa(PessoaViewModel Pessoa);

        void EditarPessoa(Pessoa Pessoa, int id);

        void ExcluirPessoa(int id);

        List<Pessoa> ListarTodasPessoas();

        Pessoa BuscarPessoaPorID(int id);

        Pessoa BuscarPessoaPorMatricula(int Matricula);

        void AtribuirSKill(SkillPessoaViewModel dados);

        void DesAtribuirSkill(SkillPessoaViewModel dados);
    }
}
