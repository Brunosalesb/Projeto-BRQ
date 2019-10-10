using AutoMapper;
using BRQ.HRT.Colaboradores.Aplicacao.Interfaces.ITipoExperiencia;
using BRQ.HRT.Colaboradores.Aplicacao.ViewModels.VMTipoExperiencia;
using BRQ.HRT.Colaboradores.Dominio.Entidades;
using BRQ.HRT.Colaboradores.Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BRQ.HRT.Colaboradores.Aplicacao.Services.STipoExperiencia
{
    public class CadastroTipoExperienciaService : ICadastroTipoExperienciaService
    {
        private readonly IMapper _mapper;
        private readonly ITipoExperienciaRepository _tipoExperienciaRepository;

        public CadastroTipoExperienciaService(IMapper mapper, ITipoExperienciaRepository tipoExperienciaRepository)
        {
            _mapper = mapper;
            _tipoExperienciaRepository = tipoExperienciaRepository;
        }

        public void Add(string userId, CadastroTipoExperienciaViewModel obj)
        {
            throw new NotImplementedException();
        }

        public void Add(CadastroTipoExperienciaViewModel obj)
        {
            TipoExperiencia tipoExp = _mapper.Map<TipoExperiencia>(obj);
            _tipoExperienciaRepository.Add(tipoExp);
        }

        public IEnumerable<CadastroTipoExperienciaViewModel> GetAll(int userId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CadastroTipoExperienciaViewModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public CadastroTipoExperienciaViewModel GetById(string userId, string id)
        {
            throw new NotImplementedException();
        }

        public CadastroTipoExperienciaViewModel GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(string id)
        {
            throw new NotImplementedException();
        }

        public void Update(string id, CadastroTipoExperienciaViewModel obj)
        {
            throw new NotImplementedException();
        }

        public void Update(CadastroTipoExperienciaViewModel obj)
        {
            throw new NotImplementedException();
        }
    }
}
