using Microsoft.AspNetCore;
using ControlLawyersApi.DTOs; 
using ControlLawyersApi.Entities;

namespace ControlLawyersApi.Mappings
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()

        {
            //Entidad -> DTO
            CreateMap<Usuario, UsuarioDTO>();
            CreateMap<Categoria, CategoriaDTO>();
            CreateMap<Cliente, ClienteDTO>();
            CreateMap<Asesoria, AsesoriaDTO>();

            //DTO -> Entidad
            CreateMap<UsuarioDTO, Usuario>();
            CreateMap<CategoriaDTO, Categoria>();
            CreateMap<ClienteDTO, Cliente>();
            CreateMap<AsesoriaDTO, Asesoria>();
        }
    }
}
    }
}
