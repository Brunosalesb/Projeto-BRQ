﻿using BRQ.HRT.Colaboradores.Aplicacao.ViewModels;
using BRQ.HRT.Colaboradores.Dominio.Entidades;
using AutoMapper;
using BRQ.HRT.Colaboradores.Aplicacao.ViewModels.Experiencia;
using BRQ.HRT.Colaboradores.Aplicacao.ViewModels.Pessoa;
using BRQ.HRT.Colaboradores.Aplicacao.ViewModels.VMPessoa;
using BRQ.HRT.Colaboradores.Aplicacao.ViewModels.VMTipoExperiencia;
using BRQ.HRT.Colaboradores.Aplicacao.ViewModels.Skill;
using BRQ.HRT.Colaboradores.Aplicacao.ViewModels.TipoSkill;
using BRQ.HRT.Colaboradores.Aplicacao.ViewModels.VMSkill;

namespace BRQ.HRT.Colaboradores.Aplicacao.AutoMapper.Perfis
{
    public class EntityToViewModel : Profile
    {
        public EntityToViewModel()
        {
            CreateMap<TipoSkill, TipoSkillViewModel>()
    .ReverseMap();
            CreateMap<TipoSkill, CadastroTipoSkillViewModel>()
                .ReverseMap();
            CreateMap<Skill, SkillViewModel>()
               .ReverseMap();
            CreateMap<Skill, CadastroSkillViewModel>()
                 .ReverseMap();
            CreateMap<SkillPessoa, SkillPorIdViewModel>()
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

            CreateMap<SkillPessoa, SkillViewModel>()
                .ReverseMap();

            CreateMap<Contato, ContatoViewModel>()
                .ReverseMap();

            CreateMap<TipoContato, TipoContatoViewModel>()
                .ReverseMap();
            CreateMap<TipoExperiencia, TipoExperienciaViewModel>()
                .ReverseMap();
            CreateMap<TipoExperiencia, CadastroTipoExperienciaViewModel>()
                .ReverseMap();
        }

    }
}
