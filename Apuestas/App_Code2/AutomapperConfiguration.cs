using System;
using Apuestas.Models;
using ApuestasDTO;
using AutoMapper;

namespace Apuestas.App_Code
{
    public class AutoMapperConfiguration
    {

        public static IMapper mapper;

        public static void Configure()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<UsuarioViewModel, DTOUsuario>();
                cfg.CreateMap<DTOUsuario,UsuarioViewModel>();
            });
            mapper = config.CreateMapper();
        }
    }
}
