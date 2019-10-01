using BRQ.HRT.Colaboradores.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace BRQ.HRT.Colaboradores.Dominio.Interfaces
{
    public interface IPessoaRepository : IBaseRepository<Pessoa>
    {
        Pessoa BuscarPessoaPorMatricula(int matricula);

        //void AtribuirSKill(SkillPessoaViewModel dados);

        //void DesAtribuirSkill(SkillsPessoa dados);
    }
}
