using BRQ.HRT.Colaboradores.Dominio.Entidades;

namespace BRQ.HRT.Colaboradores.Dominio.Interfaces
{
    public interface IPessoaRepository : IBaseRepository<Pessoa>
    {
        Pessoa BuscarPessoaPorMatricula(int matricula);

        void AtribuirSKill(SkillPessoa dados);

        void DesAtribuirSkill(int id);
    }
}
