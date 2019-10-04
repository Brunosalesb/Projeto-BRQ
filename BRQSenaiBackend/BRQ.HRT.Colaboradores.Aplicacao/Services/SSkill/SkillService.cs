using AutoMapper;
using BRQ.HRT.Colaboradores.Aplicacao.Interfaces;
using BRQ.HRT.Colaboradores.Aplicacao.ViewModels;
using BRQ.HRT.Colaboradores.Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BRQ.HRT.Colaboradores.Aplicacao.Services.SSkill
{
    public class SkillService : ISkillService
    {
        private  readonly IMapper _mapper;
        private  readonly ISkillRepository _skillRepository;
        private  readonly IPessoaRepository _pessoaRepository;

        public SkillService(IMapper mapper, ISkillRepository skillRepository, IPessoaRepository pessoaRepository)
        {
            _mapper = mapper;
            _skillRepository = skillRepository;
            _pessoaRepository = pessoaRepository;
        }

        public void Add(string userId, SkillViewModel obj)
        {
            throw new NotImplementedException();
        }

        public void Add(SkillViewModel obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SkillViewModel> GetAll(string userId)
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
                return _mapper.Map<List<SkillViewModel>>(_skillRepository.GetAll().ToList());
            }
            catch (Exception)
            {

                throw new Exception();
            }
        }

        public SkillViewModel GetById(string userId, string id)
        {
            throw new NotImplementedException();
        }

        public SkillViewModel GetById(string id)
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
            throw new NotImplementedException();
        }
    }
}
