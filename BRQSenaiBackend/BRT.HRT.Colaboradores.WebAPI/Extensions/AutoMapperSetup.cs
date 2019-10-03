using BRQ.HRT.Colaboradores.Aplicacao.AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using AutoMapper;
using System.Reflection;

namespace BRQ.HRT.Colaboradores.WebAPI.Extensions
{
    public static class AutoMapperSetup
    {
        public static void AddAutoMapperSetup(this IServiceCollection services)
        {
            var mapper = AutoMapperConfiguration.ConfigureMappings();
            services.AddAutoMapper(x => mapper.CreateMapper(), Assembly.Load("BRQ.HRT.Colaboradores.Aplicacao"));
        }
    }
}
