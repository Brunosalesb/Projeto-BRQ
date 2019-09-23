using BRQ.HRT.Colaboradores.Dominio.Entidades;
using System.Collections.Generic;

namespace BRQ.HRT.Colaboradores.Dominio.Interfaces
{
   public interface ITipoExperienciaRepository
    {

        /// <summary>
        /// Metodo que Cadastra um tipo de Experiencia no sistema
        /// </summary>
        /// <param name="nome">Nome do tipo de Experiencia </param>
        void CadastrarTipoExperiencia(string nome);

        /// <summary>
        /// Metodo que lista os tipos de Experiencia do sistema
        /// </summary>
        /// <returns>Lista de objetos da classe TipoExperiencia</returns>
        List<TipoExperiencia> ListarTodosTiposExperiencia();

        /// <summary>
        /// Metodo que deleta o tipoExperiencia do sistema
        /// </summary>
        /// <param name="id">Id do tipo de Experiencia a ser deletado</param>
        void DeletarTipoExperiencia(int id);

        /// <summary>
        /// Metodo utilizado para Editar um dado do banco TipoExperiencia
        /// </summary>
        /// <param name="id"> Id do item a ser alterado</param>
        /// <param name="nome">Nome a ser editado</param>
        void EditarTipoExperiencia(int id, string nome);
    }
}
