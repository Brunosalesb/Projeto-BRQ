using AutoMapper;
using BRQ.HRT.Colaboradores.Aplicacao.Interfaces.Pessoa;
using BRQ.HRT.Colaboradores.Aplicacao.ViewModels;
using BRQ.HRT.Colaboradores.Dominio.Interfaces;
using BRQ.HRT.Colaboradores.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace BRQ.HRT.Colaboradores.Aplicacao.Services.Pessoa
{
    public class PessoaContatoService : IPessoaContatoService
    {
        private readonly IMapper _mapper;

        private readonly IPessoaRepository _pessoaRepository;

        public PessoaContatoService(IMapper mapper, IPessoaRepository pessoaRepository)
        {
            _mapper = mapper;
            _pessoaRepository = pessoaRepository;
        }

        public IEnumerable<PessoaContatoViewModel> GetAll()
        {
            return _mapper.Map<List<PessoaContatoViewModel>>(_pessoaRepository.GetAll().ToList());
        }

        public PessoaContatoViewModel GetById(int id)
        {
            return _mapper.Map<PessoaContatoViewModel>(_pessoaRepository.GetById(id));
        }
    }
}

