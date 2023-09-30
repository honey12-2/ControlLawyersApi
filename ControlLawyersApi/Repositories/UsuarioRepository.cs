
using AutoMapper;
using Microsoft.EntityFrameworkCore;
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

        public async Task<UsuarioDTO> usuario(int id)
        {
            var entidad = await _db.usuarios.FindAsync(id);
            var usuario = _mapper.Map<Usuario, UsuarioDTO>(entidad);
            return usuario;
        }
        public async Task<ICollection<UsuarioDTO>> Usuarios()
        {
            var entidades = await _db.usuarios.ToListAsync();
            var usuarios = _mapper.Map<ICollection<Usuario>, ICollection<UsuarioDTO>>(entidades);
            return usuarios;
        }


        public async Task<int> Crear(UsuarioDTO usuario)
        {
            await _db.usuarios.AddAsync(_mapper.Map<UsuarioDTO, Usuario>(usuario));

            return await Guardar();
        }

        public async Task<int> Eliminar(int id)
        {
            var usuario = await _db.usuarios.FindAsync(id);
            if (usuario == null)
                return 0;

            _db.usuarios.Remove(usuario);
            return await Guardar();
        }

        public async Task<int> Guardar()
        {
            return await _db.SaveChangesAsync();
        }

        public async Task<int> Modificar(int id, UsuarioDTO usuario)
        {
            var entidad = await _db.usuarios.FindAsync(id);
            if (usuario == null)
                return 0;

            entidad.NombreUsuario = usuario.NombreUsuario;
            _db.usuarios.Update(entidad);
            return await Guardar();
        }

        public Task<ICollection<IUsuario>> usuarios()
        {
            throw new NotImplementedException();
        }

        public Task<UsuarioDTO> Usuario(int id)
        {
            throw new NotImplementedException();
        }
    }
}


       
