using AutoMapper;
using BRQ.HRT.Colaboradores.Aplicacao.AutoMapper.Perfis;
using System;
using System.Collections.Generic;
using System.Text;

namespace BRQ.HRT.Colaboradores.Aplicacao.AutoMapper
{
    public class AutoMapperConfiguration
    {
        public static MapperConfiguration ConfigureMappings()
        {
            var mapperConfiguration = new MapperConfiguration(cfg => {
                cfg.AddProfile(new EntityToViewModel());
            });
            return mapperConfiguration;
        }
    }
}
