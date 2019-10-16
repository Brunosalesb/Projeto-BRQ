using AutoMapper;
using BRQ.HRT.Colaboradores.Aplicacao.Interfaces.Pessoa;
using BRQ.HRT.Colaboradores.Aplicacao.ViewModels.Pessoa;
using BRQ.HRT.Colaboradores.Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BRQ.HRT.Colaboradores.Aplicacao.Services.Pessoa
{
    public class CadastroPessoaService : ICadastroPessoaService
    {
        private readonly IMapper _mapper;

        private readonly IPessoaRepository _pessoaRepository;

        public CadastroPessoaService(IMapper mapper, IPessoaRepository pessoaRepository)
        {
            _mapper = mapper;
            _pessoaRepository = pessoaRepository;
        }

        public void Add(CadastroPessoaViewModel obj)
        {
            BRQ.HRT.Colaboradores.Dominio.Entidades.Pessoa p = _mapper.Map<BRQ.HRT.Colaboradores.Dominio.Entidades.Pessoa>(obj);
            _pessoaRepository.Add(p);
        }
        public void Update(CadastroPessoaViewModel obj, int idPessoa)
        {
            Dominio.Entidades.Pessoa p = _mapper.Map<Dominio.Entidades.Pessoa>(obj);
            p.Id = idPessoa;
            _pessoaRepository.Update(p);
        }
    }
}
