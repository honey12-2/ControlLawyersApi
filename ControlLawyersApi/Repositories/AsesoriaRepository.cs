using AutoMapper;
using ControlLawyersApi.Context;
using ControlLawyersApi.DTOs;
using ControlLawyersApi.Entities;
using ControlLawyersApi.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ControlLawyersApi.Repositories
{
    public class AsesoriaRepository : IAsesoria
    {
        private readonly ApplicationDbContext _db;
        private readonly IMapper _mapper;

        public AsesoriaRepository(ApplicationDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public async Task<AsesoriaDTO> Asesoria(int id)
        {
            var entidad = await _db.asesorias.FindAsync(id);
            var asesoria = _mapper.Map<Asesoria, AsesoriaDTO>(entidad);

            return asesoria;
        }

        public async  Task<ICollection<AsesoriaDTO>> asesorias()
        {
            var entidades = await _db.asesorias.ToListAsync();
            var asesorias = _mapper.Map<ICollection<Asesoria>, ICollection<AsesoriaDTO>>(entidades);

            return asesorias;
        }

        public async Task<int> Crear(AsesoriaDTO asesoria)
        {
            await _db.asesorias.AddAsync(_mapper.Map<AsesoriaDTO, Asesoria>(asesoria));

            return await Guardar();
        }

        public async Task<int> Eliminar(int id)
        {
            var asesoria = await _db.asesorias.FindAsync(id);
            if (asesoria == null)
                return 0;

            _db.asesorias.Remove(asesoria);
            return await Guardar();
        }

        public async Task<int> Guardar()
        {
            return await _db.SaveChangesAsync();
        }

        public async Task<int> Modificar(int id, AsesoriaDTO asesoria)
        {
            var entidad = await _db.asesorias.FindAsync(id);
            if (asesoria == null)
                return 0;

            entidad.Descripcion = asesoria.Descripcion;
            _db.asesorias.Update(entidad);
            return await Guardar();
        }

        Task<ICollection<IAsesoria>> IAsesoria.asesorias()
        {
            throw new NotImplementedException();
        }
    }
}
