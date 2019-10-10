using BRQ.HRT.Colaboradores.Aplicacao.ViewModels;
using BRQ.HRT.Colaboradores.Dominio.Entidades;
using AutoMapper;
using BRQ.HRT.Colaboradores.Aplicacao.ViewModels.Experiencia;
using BRQ.HRT.Colaboradores.Aplicacao.ViewModels.Pessoa;
using BRQ.HRT.Colaboradores.Aplicacao.ViewModels.VMPessoa;

namespace BRQ.HRT.Colaboradores.Aplicacao.AutoMapper.Perfis
{
    public class EntityToViewModel : Profile
    {
        public EntityToViewModel()
        {
            CreateMap<Skill, SkillViewModel>()
                .ReverseMap();
            CreateMap<TipoSkill, SkillViewModel>()
                .ReverseMap();
            CreateMap<Experiencia, ExperienciaViewModel>()
                .ReverseMap();
            CreateMap<Experiencia, CadastroExperienciaViewModel>()
                .ReverseMap();

            CreateMap<Pessoa, CadastroPessoaViewModel>()
                .ReverseMap();

            CreateMap<Pessoa, PessoaContatoViewModel>()
                .ReverseMap();
            CreateMap<Pessoa, PessoaViewModel>()
                .ReverseMap();

            CreateMap<Contato, ContatoViewModel>()
                .ReverseMap();

            CreateMap<TipoContato, TipoContatoViewModel>()
                .ReverseMap();
        }
        
    }
}
