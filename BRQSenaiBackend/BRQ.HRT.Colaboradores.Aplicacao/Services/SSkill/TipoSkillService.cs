using AutoMapper;
using BRQ.HRT.Colaboradores.Aplicacao.Interfaces.ISkill;
using BRQ.HRT.Colaboradores.Aplicacao.ViewModels.TipoSkill;
using BRQ.HRT.Colaboradores.Dominio.Entidades;
using BRQ.HRT.Colaboradores.Dominio.Interfaces;
using System;
using System.Collections.Generic;

namespace BRQ.HRT.Colaboradores.Aplicacao.Services.SSkill
{
    public class TipoSkillService : ITipoSkillService
    {

        private readonly IMapper _mapper;
        private readonly ITipoSkillRepository _tipoSkillRepository;
        private readonly IPessoaRepository _pessoaRepository;

        public TipoSkillService(IMapper mapper, ITipoSkillRepository tipoSkillRepository, IPessoaRepository pessoaRepository)
        {
            _mapper = mapper;
            _tipoSkillRepository = tipoSkillRepository;
            _pessoaRepository = pessoaRepository;
        }

        //cadastra o tipo da skill utilizando viewModel
        public void Add(CadastroTipoSkillViewModel obj)
        {
            try
            {
                TipoSkill tipoSkill = _mapper.Map<TipoSkill>(obj);
                _tipoSkillRepository.Add(tipoSkill);
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }

        //lista o tipo de skill utilizando viewModel
        public IEnumerable<TipoSkillViewModel> GetAll()
        {
            try
            {
                return _mapper.Map<List<TipoSkillViewModel>>(_tipoSkillRepository.GetAll());
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }

        //edita o tipo da skill
        public void Update(CadastroTipoSkillViewModel obj, int id)
        {
            try
            {
                TipoSkill tipoSkillBuscada = _mapper.Map<TipoSkill>(obj);
                tipoSkillBuscada.Id = id;
                _tipoSkillRepository.Update(tipoSkillBuscada);
            }
            catch (Exception)
            {

                throw new Exception();
            }
        }
    }
}
