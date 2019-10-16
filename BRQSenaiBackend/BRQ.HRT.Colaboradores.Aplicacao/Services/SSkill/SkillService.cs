using AutoMapper;
using BRQ.HRT.Colaboradores.Aplicacao.Interfaces;
using BRQ.HRT.Colaboradores.Aplicacao.ViewModels;
using BRQ.HRT.Colaboradores.Aplicacao.ViewModels.Skill;
using BRQ.HRT.Colaboradores.Aplicacao.ViewModels.VMSkillPessoa;
using BRQ.HRT.Colaboradores.Dominio.Entidades;
using BRQ.HRT.Colaboradores.Dominio.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

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

        public IEnumerable<SkillPessoaViewModel> GetAll(int userId)
        {
            try
            {
                Dominio.Entidades.Pessoa pessoa = _mapper.Map<Dominio.Entidades.Pessoa>(_pessoaRepository.GetById(userId));

                return _mapper.Map<List<SkillPessoaViewModel>>(pessoa.SkillPessoa);
            }
            catch (Exception)
            {

                throw new Exception();
            }
        }

        public IEnumerable<SkillViewModel> GetAll()
        {
            try
            {
                return _mapper.Map<List<SkillViewModel>>(_skillRepository.GetAll());
            }
            catch (Exception)
            {

                throw new Exception();
            }
        }

        public SkillViewModel GetById(int id)
        {
            return _mapper.Map<SkillViewModel>(_skillRepository.GetById(id));
        }

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
