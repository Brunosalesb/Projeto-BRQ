using AutoMapper;
using BRQ.HRT.Colaboradores.Aplicacao.Interfaces;
using BRQ.HRT.Colaboradores.Aplicacao.ViewModels;
using BRQ.HRT.Colaboradores.Aplicacao.ViewModels.Skill;
using BRQ.HRT.Colaboradores.Dominio.Entidades;
using BRQ.HRT.Colaboradores.Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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

        public void Add(string userId, CadastroSkillViewModel obj)
        {   
            throw new NotImplementedException();
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

        public IEnumerable<SkillViewModel> GetAll(int userId)
        {
            try
            {
                Dominio.Entidades.Pessoa pessoa = _mapper.Map<Dominio.Entidades.Pessoa>(_pessoaRepository.GetById(userId));

                return _mapper.Map<List<SkillViewModel>>(pessoa.SkillPessoa);
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
            catch (Exception ex)
            {

                throw new Exception();
            }
        }

        public SkillViewModel GetById(string userId, string Sid)
        {
            throw new NotImplementedException();
        }

        public SkillViewModel GetById(int id)
        {
            return _mapper.Map<SkillViewModel>(_skillRepository.GetById(id));
        }

        public void Remove(string id)
        {
            
        }

        public void Update(string id, SkillViewModel obj)
        {
            throw new NotImplementedException();
        }

        public void Update(SkillViewModel obj)
        {
            try
            {
                BRQ.HRT.Colaboradores.Dominio.Entidades.Skill skill= _mapper.Map<BRQ.HRT.Colaboradores.Dominio.Entidades.Skill>(obj);
                _skillRepository.Update(skill);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
