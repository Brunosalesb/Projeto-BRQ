using BRQ.HRT.Colaboradores.Aplicacao.Interfaces;
using BRQ.HRT.Colaboradores.Aplicacao.Interfaces.Experiencia;
using BRQ.HRT.Colaboradores.Aplicacao.Interfaces.IPessoa;
using BRQ.HRT.Colaboradores.Aplicacao.Interfaces.Pessoa;
using BRQ.HRT.Colaboradores.Aplicacao.Interfaces.Skill;
using BRQ.HRT.Colaboradores.Aplicacao.Services;
using BRQ.HRT.Colaboradores.Aplicacao.Services.Experiencia;
using BRQ.HRT.Colaboradores.Aplicacao.Services.Pessoa;
using BRQ.HRT.Colaboradores.Aplicacao.Services.SPessoa;
using BRQ.HRT.Colaboradores.Aplicacao.Services.SSkill;
using BRQ.HRT.Colaboradores.Dominio.Interfaces;
using BRQ.HRT.Colaboradores.Infra.Data.Repositorios;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace BRQ.HRT.Colaboradores.Infra.Ioc
{
    /// <summary>
    /// Classe Responsavel por controllar a Injeção de dependencias
    /// </summary>
    public static class NativeInjectorConfig
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<IPessoaService,PessoaService>();
            services.AddScoped<ITipoSkillRepository, TipoSkillRepository>();
            services.AddScoped<ISkillRepository, SkillRepository>();

            services.AddScoped<ITipoExperienciaRepository, TipoExperienciaRepository>();
            services.AddScoped<IExperienciaRepository, ExperienciaRepository>();

            services.AddScoped<ITipoContatoRepository, TipoContatoRepository>();
            services.AddScoped<IContatoRepository, ContatoRepository>();

            services.AddScoped<ISkillPessoaRepository, SkillPessoaRepository>();

            services.AddScoped<IPessoaRepository, PessoaRepository>();

            services.AddScoped<ICadastroPessoaService, CadastroPessoaService>();
            services.AddScoped<IPessoaContatoService, PessoaContatoService>();
            services.AddScoped<ICadastroExperienciaService, CadastroExperienciaService>();
            services.AddScoped<IExperienciaService, ExperienciaService>();
            services.AddScoped<ISkillService, SkillService>();
            services.AddScoped<ICadastroSkillService, CadastroSkillService>();

            //services.AddScoped<IPessoaRepository, PessoaRepository>();



        }
    }
}
