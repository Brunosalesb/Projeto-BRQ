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
        void CadastrarTipoSKill(TipoSkill tipoSkill);

        /// <summary>
        /// Metodo que lista os tipos de skill do sistema
        /// </summary>
        /// <returns>Lista de objetos da classe TipoSkill</returns>
        List<TipoSkill> ListarTipoSkill();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        TipoSkill BuscarTipoSkillPorID(int id);

        /// <summary>
        /// Metodo utilizado para Editar um dado do banco TipoSkill
        /// </summary>
        /// <param name="id"> Id do item a ser alterado</param>
        /// <param name="nome">Nome a ser editado</param>
        void EditarTipoSKill(TipoSkill tipoSkill);
    }
}
