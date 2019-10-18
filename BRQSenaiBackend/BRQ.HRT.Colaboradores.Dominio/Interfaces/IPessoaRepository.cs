using BRQ.HRT.Colaboradores.Dominio.Entidades;
using System.Collections.Generic;

namespace BRQ.HRT.Colaboradores.Dominio.Interfaces
{
    public interface IPessoaRepository : IBaseRepository<Pessoa>
    {
        Pessoa BuscarPessoaPorMatricula(string matricula);

        void AtribuirSKill(SkillPessoa dados);

        void DesAtribuirSkill(int id);

        List<Pessoa> BuscarTodosDados();
        Pessoa BuscarTodosDadosPorID(int id);
    }
}
