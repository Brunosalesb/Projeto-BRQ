using AutoMapper;
using BRQ.HRT.Colaboradores.Aplicacao.Interfaces.ITipoExperiencia;
using BRQ.HRT.Colaboradores.Aplicacao.ViewModels.VMTipoExperiencia;
using BRQ.HRT.Colaboradores.Dominio.Entidades;
using BRQ.HRT.Colaboradores.Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

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

        public void Add(CadastroTipoExperienciaViewModel obj)
        {
            try
            {
                TipoExperiencia tipoExp = _mapper.Map<TipoExperiencia>(obj);
                _tipoExperienciaRepository.Add(tipoExp);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public IEnumerable<TipoExperienciaViewModel> GetAll()
        {
            try
            {
                return _mapper.Map<List<TipoExperienciaViewModel>>(_tipoExperienciaRepository.GetAll().ToList());
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Update(CadastroTipoExperienciaViewModel obj, int id)
        {
            TipoExperiencia tipoExp = _mapper.Map<TipoExperiencia>(obj);
            tipoExp.Id = id;
            _tipoExperienciaRepository.Update(tipoExp);
        }
    }
}
