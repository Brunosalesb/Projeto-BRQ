using BRQ.HRT.Colaboradores.Dominio.Entidades;
using System.Collections.Generic;

namespace BRQ.HRT.Colaboradores.Dominio.Interfaces
{
    public interface ITipoSkillRepository
    {
        /// <summary>
        /// Metodo que Cadastra um tipo de skill no sistema
        /// </summary>
        /// <param name="nome">Nome do tipo de skill </param>
        void CadastrarTipoSKill(string nome);

        /// <summary>
        /// Metodo que lista os tipos de skill do sistema
        /// </summary>
        /// <returns>Lista de objetos da classe TipoSkill</returns>
        List<TipoSkill> ListarTipoSkill(); 
        
        /// <summary>
        /// Metodo que deleta o tipoSkill do sistema
        /// </summary>
        /// <param name="id">Id do tipo de skill a ser deletado</param>
        void DeletarTipoSkill(int id);

        /// <summary>
        /// Metodo utilizado para Editar um dado do banco TipoSkill
        /// </summary>
        /// <param name="id"> Id do item a ser alterado</param>
        /// <param name="nome">Nome a ser editado</param>
        void EditarTipoSKill(int id, string nome);
    }
}
