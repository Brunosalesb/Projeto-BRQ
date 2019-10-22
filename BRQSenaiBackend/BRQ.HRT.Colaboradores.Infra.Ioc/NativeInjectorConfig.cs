using BRQ.HRT.Colaboradores.Aplicacao.Interfaces;
using BRQ.HRT.Colaboradores.Aplicacao.Interfaces.IPessoa;
using BRQ.HRT.Colaboradores.Aplicacao.Interfaces.ISkill;
using BRQ.HRT.Colaboradores.Aplicacao.Interfaces.ITipoExperiencia;
using BRQ.HRT.Colaboradores.Aplicacao.Interfaces.Pessoa;
using BRQ.HRT.Colaboradores.Aplicacao.Services;
using BRQ.HRT.Colaboradores.Aplicacao.Services.Pessoa;
using BRQ.HRT.Colaboradores.Aplicacao.Services.SPessoa;
using BRQ.HRT.Colaboradores.Aplicacao.Services.SSkill;
using BRQ.HRT.Colaboradores.Aplicacao.Services.STipoExperiencia;
using BRQ.HRT.Colaboradores.Dominio.Interfaces;
using BRQ.HRT.Colaboradores.Infra.Data.Repositorios;
using Microsoft.Extensions.DependencyInjection;

namespace BRQ.HRT.Colaboradores.Infra.Ioc
{
    /// <summary>
    /// Classe Responsavel por controllar a Injeção de dependencias
    /// </summary>
    public static class NativeInjectorConfig
    {
        public static void RegisterServices(this IServiceCollection services)
        {

            #region Repository
            services.AddScoped<ITipoSkillRepository, TipoSkillRepository>();
            services.AddScoped<ISkillRepository, SkillRepository>();
            services.AddScoped<ITipoExperienciaRepository, TipoExperienciaRepository>();
            services.AddScoped<IExperienciaRepository, ExperienciaRepository>();
            services.AddScoped<ITipoContatoRepository, TipoContatoRepository>();
            services.AddScoped<IContatoRepository, ContatoRepository>();
            services.AddScoped<IPessoaRepository, PessoaRepository>();
            services.AddScoped<ISkillPessoaRepository, SkillPessoaRepository>();
            #endregion

            #region Services
            services.AddScoped<IPessoaService, PessoaService>();
            services.AddScoped<IPessoaContatoService, PessoaContatoService>();
            services.AddScoped<ICadastroPessoaService, CadastroPessoaService>();
            services.AddScoped<IExperienciaService, ExperienciaService>();
            services.AddScoped<ITipoExperienciaService, TipoExperienciaService>();
            services.AddScoped<ISkillService, SkillService>();
            services.AddScoped<ITipoSkillService, TipoSkillService>();
            services.AddScoped<IContatoService,ContatoService>();
            #endregion

        }
    }
}
