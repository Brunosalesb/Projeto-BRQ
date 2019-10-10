using AutoMapper;
using BRQ.HRT.Colaboradores.Aplicacao.Interfaces.Experiencia;
using BRQ.HRT.Colaboradores.Aplicacao.ViewModels.Experiencia;
using BRQ.HRT.Colaboradores.Dominio.Interfaces;
using BRQ.HRT.Colaboradores.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace BRQ.HRT.Colaboradores.Aplicacao.Services.Experiencia
{
    public class CadastroExperienciaService : ICadastroExperienciaService
    {
        private readonly IMapper _mapper;

        private readonly IExperienciaRepository _experienciaRepository;

        public CadastroExperienciaService(IMapper mapper, IExperienciaRepository experienciaRepository)
        {
            _mapper = mapper;
            _experienciaRepository = experienciaRepository;
        }

        public void Add(CadastroExperienciaViewModel obj)
        {
            BRQ.HRT.Colaboradores.Dominio.Entidades.Experiencia exp = _mapper.Map<BRQ.HRT.Colaboradores.Dominio.Entidades.Experiencia>(obj);
            _experienciaRepository.Add(exp);
        }

        public IEnumerable<CadastroExperienciaViewModel> GetAll(int userId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CadastroExperienciaViewModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public CadastroExperienciaViewModel GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(string id)
        {
            throw new NotImplementedException();
        }

        public void Update(string id, CadastroExperienciaViewModel obj)
        {
            throw new NotImplementedException();
        }

        public void Update(CadastroExperienciaViewModel obj)
        {
            throw new NotImplementedException();
        }

     }
}
