
using AutoMapper;
using ControlLawyersApi.Context;
using ControlLawyersApi.DTOs;
using ControlLawyersApi.Entities;
using ControlLawyersApi.Repositories.Interfaces;

namespace ControlLawyersApi.Repositories
{
    public class UsuarioRepository : IUsuario

    {
        private readonly ApplicationDbContext _db;
        private readonly IMapper _mapper;

        public UsuarioRepository(ApplicationDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }
        public async Task<UsuarioDTO> Usuario(int id)
        {
            var entidad = await _db.usuarios.findAsync(id);
            var usuario = _mapper.Map<Usuario, UsuarioDTO>(entidad);

            return usuario;
        }
        public async Task<ICollection<UsuarioDTO>> usuarios()
        {
            var entidades = await _db.usuarios.ToListAsync();
            var usuarios = _mapper.Map<ICollection<Usuario>, ICollection<UsuarioDTO>>(entidades);
            return usuarios;
        }
        public Task<int> Crear(UsuarioDTO usuario)
        {
            throw new NotImplementedException();
        }

        public Task<int> Eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> Guardar()
        {
            throw new NotImplementedException();
        }

        public Task<int> Modificar(int id, UsuarioDTO usuario)
        {
            throw new NotImplementedException();
        }

        public Task<UsuarioDTO> Usuario(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<IUsuario>> 
            
            eeusuarios()
        {
            throw new NotImplementedException();
        }

        Task<ICollection<IUsuario>> IUsuario.usuarios()
        {
            throw new NotImplementedException();
        }
    }
}
