using AutoMapper;
using BRQ.HRT.Colaboradores.Aplicacao.Interfaces;
using BRQ.HRT.Colaboradores.Aplicacao.ViewModels;
using BRQ.HRT.Colaboradores.Dominio.Entidades;
using BRQ.HRT.Colaboradores.Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BRQ.HRT.Colaboradores.Aplicacao.Services
{
    public class ExperienciaService : IExperienciaService
    {
        private readonly IMapper _mapper;

        private readonly IPessoaRepository _pessoaRepository;

        private readonly IExperienciaRepository _experienciaRepository;

        public ExperienciaService(IMapper mapper, IPessoaRepository pessoaRepository, IExperienciaRepository experienciaRepository )
        {
            _mapper = mapper;
            _pessoaRepository = pessoaRepository;
            _experienciaRepository = experienciaRepository;
        }

        public void Add(string userId, ExperienciaViewModel obj)
        {
            throw new NotImplementedException();
        }

        public void Add(ExperienciaViewModel obj)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Metodo que converte Para ViewModel
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public IEnumerable<ExperienciaViewModel> GetAll(string userId)
        {
            try
            {
                BRQ.HRT.Colaboradores.Dominio.Entidades.Pessoa pessoa = _mapper.Map<BRQ.HRT.Colaboradores.Dominio.Entidades.Pessoa>(_pessoaRepository.GetById(userId));

                return _mapper.Map<List<ExperienciaViewModel>>(pessoa.Experiencia);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public IEnumerable<ExperienciaViewModel> GetAll()
        {
            try
            {
                return _mapper.Map<List<ExperienciaViewModel>>(_experienciaRepository.GetAll());
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public ExperienciaViewModel GetById(string userId, string id)
        {
            throw new NotImplementedException();
        }

        public ExperienciaViewModel GetById(string id)
        {
            return _mapper.Map<ExperienciaViewModel>(_experienciaRepository.GetById(id));
        }

        public void Remove(string id)
        {
            throw new NotImplementedException();
        }

        public void Update(ExperienciaViewModel obj)
        {
            BRQ.HRT.Colaboradores.Dominio.Entidades.Experiencia exp = _mapper.Map<BRQ.HRT.Colaboradores.Dominio.Entidades.Experiencia>(obj);
            _experienciaRepository.Update(exp);

        }

        public void Update(string id, ExperienciaViewModel obj)
        {
            throw new NotImplementedException();
        }
    }
}
