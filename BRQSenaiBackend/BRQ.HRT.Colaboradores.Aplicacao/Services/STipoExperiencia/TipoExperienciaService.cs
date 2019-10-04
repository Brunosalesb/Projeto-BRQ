using AutoMapper;
using BRQ.HRT.Colaboradores.Aplicacao.Interfaces.ITipoExperiencia;
using BRQ.HRT.Colaboradores.Aplicacao.ViewModels.VMTipoExperiencia;
using BRQ.HRT.Colaboradores.Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BRQ.HRT.Colaboradores.Aplicacao.Services.STipoExperiencia
{
    public class TipoExperienciaService : ITipoExperienciaService
    {
        private readonly IMapper _mapper;
        private ITipoExperienciaRepository _tipoExperienciaRepository;

        public TipoExperienciaService(IMapper mapper, ITipoExperienciaRepository tipoExperienciaRepository)
        {
            _mapper = mapper;
            _tipoExperienciaRepository = tipoExperienciaRepository;
        }

        public void Add(string userId, TipoExperienciaViewModel obj)
        {
            throw new NotImplementedException();
        }

        public void Add(TipoExperienciaViewModel obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TipoExperienciaViewModel> GetAll(string userId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TipoExperienciaViewModel> GetAll()
        {
            try
            {
                return _mapper.Map<List<TipoExperienciaViewModel>>(_tipoExperienciaRepository.GetAll());
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public TipoExperienciaViewModel GetById(string userId, string id)
        {
            throw new NotImplementedException();
        }

        public TipoExperienciaViewModel GetById(string id)
        {
            throw new NotImplementedException();
        }

        public void Remove(string id)
        {
            throw new NotImplementedException();
        }

        public void Update(string id, TipoExperienciaViewModel obj)
        {
            throw new NotImplementedException();
        }

        public void Update(TipoExperienciaViewModel obj)
        {
            throw new NotImplementedException();
        }
    }
}
