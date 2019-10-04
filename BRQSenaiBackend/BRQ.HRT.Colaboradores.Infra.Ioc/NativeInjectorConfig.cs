using BRQ.HRT.Colaboradores.Aplicacao.Interfaces;
using BRQ.HRT.Colaboradores.Aplicacao.Interfaces.Skill;
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
            services.AddScoped<ITipoSkillRepository, TipoSkillRepository>();
            services.AddScoped<ISkillRepository, SkillRepository>();

            services.AddScoped<ITipoExperienciaRepository, TipoExperienciaRepository>();
            services.AddScoped<IExperienciaRepository, ExperienciaRepository>();

            services.AddScoped<ITipoContatoRepository, TipoContatoRepository>();
            services.AddScoped<IContatoRepository, ContatoRepository>();

            services.AddScoped<ISkillPessoaRepository, SkillPessoaRepository>();

            services.AddScoped<IPessoaRepository, PessoaRepository>();

            services.AddScoped<ISkillService, SkillService>();
            services.AddScoped<ICadastroSkillService, CadastroSkillService>();
        }
    }
}
