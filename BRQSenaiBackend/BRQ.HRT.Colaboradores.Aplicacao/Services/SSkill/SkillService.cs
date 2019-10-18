using AutoMapper;
using BRQ.HRT.Colaboradores.Aplicacao.Interfaces;
using BRQ.HRT.Colaboradores.Aplicacao.ViewModels;
using BRQ.HRT.Colaboradores.Aplicacao.ViewModels.Skill;
using BRQ.HRT.Colaboradores.Aplicacao.ViewModels.VMSkill;
using BRQ.HRT.Colaboradores.Aplicacao.ViewModels.VMSkillPessoa;
using BRQ.HRT.Colaboradores.Dominio.Entidades;
using BRQ.HRT.Colaboradores.Dominio.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BRQ.HRT.Colaboradores.Aplicacao.Services.SSkill
{
    public class SkillService : ISkillService
    {
        private readonly IMapper _mapper;
        private readonly IPessoaRepository _pessoaRepository;
        private readonly ISkillRepository _skillRepository;

        public SkillService(IMapper mapper, ISkillRepository skillRepository, IPessoaRepository pessoaRepository)
        {
            _mapper = mapper;
            _skillRepository = skillRepository;
            _pessoaRepository = pessoaRepository;
        }

        //cadastra a skill utilizando viewModel
        public void Add(CadastroSkillViewModel obj)
        {
            try
            {
                Skill skill = _mapper.Map<Skill>(obj);
                _skillRepository.Add(skill);
            }
            catch (Exception)
            {

                throw;
            }
        }

        //lista todas as skills de um usuario utilizando viewModel
        public IEnumerable<SkillPorIdViewModel> GetAll(int userId)
        {
            try
            {
                return _mapper.Map<List<SkillPorIdViewModel>>(_skillRepository.ListaSkillsPorIdUsuario(userId));
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }

        //Lista todas as skills existentes
        public IEnumerable<SkillViewModel> GetAll()
        {
            try
            {
                return _mapper.Map<List<SkillViewModel>>(_skillRepository.ListaSkills());
            }
            catch (Exception)
            {

                throw new Exception();
            }
        }

        //lista uma skill pelo id dela
        public CadastroSkillViewModel GetById(int id)
        {
            try
            {
                return _mapper.Map<CadastroSkillViewModel>(_skillRepository.GetById(id));
            }
            catch (Exception)
            {

                throw new Exception();
            }
        }

        //edita uma skill utilizando viewModel
        public void Update(CadastroSkillViewModel obj, int id)
        {
            try
            {
                Skill skillBuscada = _mapper.Map<Skill>(obj);
                skillBuscada.Id = id;
                _skillRepository.Update(skillBuscada);
            }
            catch (Exception)
            {

                throw new Exception();
            }
        }
    }
}
