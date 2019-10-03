using BRQ.HRT.Colaboradores.Aplicacao.ViewModels;
using BRQ.HRT.Colaboradores.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using BRQ.HRT.Colaboradores.Aplicacao.ViewModels.Experiencia;
using BRQ.HRT.Colaboradores.Aplicacao.ViewModels.Pessoa;

namespace BRQ.HRT.Colaboradores.Aplicacao.AutoMapper.Perfis
{
    public class EntityToViewModel : Profile
    {
        public EntityToViewModel()
        {
            CreateMap<TipoSkill, SkillViewModel>()
                .ReverseMap();
            CreateMap<Experiencia, ExperienciaViewModel>()
                .ReverseMap();
            CreateMap<Experiencia, CadastroExperienciaViewModel>()
                .ReverseMap();
            CreateMap<Pessoa, CadastroPessoaViewModel>()
                .ReverseMap();
        }
        
    }
}
