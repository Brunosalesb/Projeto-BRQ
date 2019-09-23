using BRQ.HRT.Colaboradores.Dominio.Entidades;
using BRQ.HRT.Colaboradores.Servicos.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace BRQ.HRT.Colaboradores.Dominio.Interfaces
{
    public interface IExperienciaRepository
    {
        void CadastrarExperiencia(ExperienciaViewModel exp);

        List<Experiencia> ListarTodasExperiencias();

        List<Experiencia> ListarExperienciasPorIdPessoa(int id);

        Experiencia BuscarExperienciaPorID(int id);

        void AtualizarExperiencia(int id, Experiencia xp);

        void DeletarExperiencia(int id);
    }
}
