using BRQ.HRT.Colaboradores.Dominio.Entidades;
using BRQ.HRT.Colaboradores.Servicos.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace BRQ.HRT.Colaboradores.Dominio.Interfaces
{
    /// <summary>
    /// Interface Responsavel pelos metodos relacionados a Skill
    /// </summary>
    public interface ISkillRepository
    {
        /// <summary>
        /// Metodo de Cadastro de Skill no sistema
        /// </summary>
        /// <param name="skill"></param>
        void CadastrarSkill(Skill skill);
        /// <summary>
        /// Lista todas as skill Cadastradas no sistema
        /// </summary>
        /// <returns>Lista de objetos da classe Skill, caso nao haja dados uma lista vazia</returns>
        List<Skill> ListarTodasSkills();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Skill BuscarSkillPorID(int id);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="skill"></param>
        void EditarSkill(Skill skill);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        void DeletarSkill(int id);
    }
}
