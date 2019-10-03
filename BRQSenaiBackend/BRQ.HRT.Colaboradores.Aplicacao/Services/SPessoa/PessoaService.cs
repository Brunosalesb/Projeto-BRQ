using AutoMapper;
using BRQ.HRT.Colaboradores.Aplicacao.Interfaces.Pessoa;
using BRQ.HRT.Colaboradores.Aplicacao.ViewModels;
using BRQ.HRT.Colaboradores.Dominio.Interfaces;
using BRQ.HRT.Colaboradores.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace BRQ.HRT.Colaboradores.Aplicacao.Services.Pessoa
{
    public class PessoaService : IPessoaService
    {
        private readonly IMapper _mapper;

        private readonly IPessoaRepository _pessoaRepository;

        public PessoaService(IMapper mapper, IPessoaRepository pessoaRepository)
        {
            _mapper = mapper;
            _pessoaRepository = pessoaRepository;
        }

        public void Add(string userId, PessoaViewModel obj)
        {
            throw new NotImplementedException();
        }

        public void Add(PessoaViewModel obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PessoaViewModel> GetAll(string userId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PessoaViewModel> GetAll()
        {
            return _mapper.Map<List<PessoaViewModel>>(_pessoaRepository.GetAll());
        }

        public PessoaViewModel GetById(string userId, string id)
        {
            throw new NotImplementedException();
        }

        public PessoaViewModel GetById(string id)
        {
            return _mapper.Map<PessoaViewModel>(_pessoaRepository.GetById(id));
        }

        public void Remove(string id)
        {
            throw new NotImplementedException();
        }

        public void Update(string id, PessoaViewModel obj)
        {
            throw new NotImplementedException();
        }

        public void Update(PessoaViewModel obj)
        {
            Dominio.Entidades.Pessoa p = _mapper.Map<Dominio.Entidades.Pessoa>(obj);
            _pessoaRepository.Update(p);
        }
    }
}
