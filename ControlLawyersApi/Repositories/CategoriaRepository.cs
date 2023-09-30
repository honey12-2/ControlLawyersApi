using AutoMapper;
using ControlLawyersApi.Context;
using ControlLawyersApi.DTOs;
using ControlLawyersApi.Entities;
using ControlLawyersApi.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ControlLawyersApi.Repositories
{
    public class CategoriaRepository : ICategoria

    {
        private readonly ApplicationDbContext _db;
        private readonly IMapper _mapper;

        public CategoriaRepository(ApplicationDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public  async Task<CategoriaDTO> Categoria(int id)
        {
            var entidad = await _db.categorias.FindAsync(id);
            var categoria = _mapper.Map<Categoria, CategoriaDTO>(entidad);

            return categoria;
        }

        public async Task<ICollection<CategoriaDTO>> Categorias()
        {
            var entidades = await _db.categorias.ToListAsync();
            var categorias = _mapper.Map<ICollection<Categoria>, ICollection<CategoriaDTO>>(entidades);

            return categorias;
        }

        public Task<ICollection<ICategoria>> categorias()
        {
            throw new NotImplementedException();
        }

        public async Task<int> Crear(CategoriaDTO categoria)
        {
            await _db.categorias.AddAsync(_mapper.Map<CategoriaDTO, Categoria>(categoria));

            return await Guardar();
        }

        public async Task<int> Eliminar(int id)
        {
            var categoria = await _db.categorias.FindAsync(id);
            if (categoria == null)
                return 0;

            _db.categorias.Remove(categoria);
            return await Guardar();
        }

        public async Task<int> Guardar()
        {
            return await _db.SaveChangesAsync();
        }

        public async Task<int> Modificar(int id, CategoriaDTO categoria)
        {
            var entidad = await _db.categorias.FindAsync(id);
            if (categoria == null)
                return 0;

            entidad.Nombre = categoria.Nombre;
            _db.categorias.Update(entidad);
            return await Guardar();


        }
    }
}
