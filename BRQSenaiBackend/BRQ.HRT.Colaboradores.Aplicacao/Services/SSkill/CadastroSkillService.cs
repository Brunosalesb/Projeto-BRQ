using AutoMapper;
using BRQ.HRT.Colaboradores.Aplicacao.Interfaces.Skill;
using BRQ.HRT.Colaboradores.Aplicacao.ViewModels.Skill;
using BRQ.HRT.Colaboradores.Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BRQ.HRT.Colaboradores.Aplicacao.Services.SSkill
{
    public class CadastroSkillService : ICadastroSkillService
    {

        private readonly IMapper _mapper;

        private readonly ISkillRepository _skillRepository;

        public void Add(string userId, CadastroSkillViewModel obj)
        {
            Dominio.Entidades.Skill skill = _mapper.Map<Dominio.Entidades.Skill>(obj);
            _skillRepository.Add(skill);
        }

        public void Add(CadastroSkillViewModel obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CadastroSkillViewModel> GetAll(int userId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CadastroSkillViewModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public CadastroSkillViewModel GetById(string userId, string id)
        {
            throw new NotImplementedException();
        }

        public CadastroSkillViewModel GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(string id)
        {
            throw new NotImplementedException();
        }

        public void Update(string id, CadastroSkillViewModel obj)
        {
            throw new NotImplementedException();
        }

        public void Update(CadastroSkillViewModel obj)
        {
            throw new NotImplementedException();
        }
    }
}
