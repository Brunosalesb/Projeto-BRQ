using AutoMapper;
using BRQ.HRT.Colaboradores.Aplicacao.Interfaces;
using BRQ.HRT.Colaboradores.Aplicacao.ViewModels.VMContato;
using BRQ.HRT.Colaboradores.Dominio.Entidades;
using BRQ.HRT.Colaboradores.Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BRQ.HRT.Colaboradores.Aplicacao.Services
{
    public class ContatoService : IContatoService
    {
        private readonly IMapper _mapper;
        private readonly IContatoRepository _contatoRepository;

        public ContatoService(IMapper mapper, IContatoRepository contatoRepository)
        {
            _mapper = mapper;
            _contatoRepository = contatoRepository;
        }

        public void Add(ContatoCadastroViewModel obj)
        {
            try
            {
                Contato contato = _mapper.Map<Contato>(obj);
                _contatoRepository.Add(contato);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Update(ContatoCadastroViewModel obj, int id)
        {
            Contato ct = _mapper.Map<Contato>(obj);
            ct.Id = id;
            _contatoRepository.Update(ct);
        }
    }
}
