using AutoMapper;
using BRQ.HRT.Colaboradores.Aplicacao.Interfaces.IPessoa;
using BRQ.HRT.Colaboradores.Aplicacao.ViewModels.VMPessoa;
using BRQ.HRT.Colaboradores.Aplicacao.ViewModels.VMSkillPessoa;
using BRQ.HRT.Colaboradores.Dominio.Entidades;
using BRQ.HRT.Colaboradores.Dominio.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace BRQ.HRT.Colaboradores.Aplicacao.Services.SPessoa
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

        public void AtribuirSkill(SkillPessoaCadastroViewModel skillPessoa)
        {
            SkillPessoa sp = _mapper.Map<SkillPessoa>(skillPessoa);

             _pessoaRepository.AtribuirSKill(sp);
        }

        public IEnumerable<PessoaViewModel> GetAll()
        {
            return _mapper.Map<List<PessoaViewModel>>(_pessoaRepository.GetAll().ToList());
        }

        public PessoaViewModel GetById(int id)
        {
            return _mapper.Map<PessoaViewModel>(_pessoaRepository.GetById(id));
        }



    }
}
