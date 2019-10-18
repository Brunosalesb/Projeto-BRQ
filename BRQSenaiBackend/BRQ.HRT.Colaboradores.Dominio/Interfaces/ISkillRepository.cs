using BRQ.HRT.Colaboradores.Dominio.Entidades;
using System.Collections.Generic;

namespace BRQ.HRT.Colaboradores.Dominio.Interfaces
{
    public interface ISkillRepository : IBaseRepository<Skill>
    {
        List<Skill> ListaSkills();
        List<SkillPessoa> ListaSkillsPorIdUsuario(int id);
    }
}
