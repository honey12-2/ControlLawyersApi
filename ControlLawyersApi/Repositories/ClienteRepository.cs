using AutoMapper;
using ControlLawyersApi.Context;
using ControlLawyersApi.DTOs;
using ControlLawyersApi.Entities;
using ControlLawyersApi.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ControlLawyersApi.Repositories
{
    public class ClienteRepository : ICliente
    {

        private readonly ApplicationDbContext _db;
        private readonly IMapper _mapper;

        public ClienteRepository(ApplicationDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public async Task<ClienteDTO> Cliente(int id)
        {
            var entidad = await _db.clientes.FindAsync(id);
            var cliente = _mapper.Map<Cliente, ClienteDTO>(entidad);

            return cliente;
        }

        public async Task<ICollection<ClienteDTO>> clientes()
        {
            var entidades = await _db.clientes.ToListAsync();
            var clientes = _mapper.Map<ICollection<Cliente>, ICollection<ClienteDTO>>(entidades);

            return clientes;
        }

        public async Task<int> Crear(ClienteDTO cliente)
        {
            await _db.clientes.AddAsync(_mapper.Map<ClienteDTO, Cliente>(cliente));

            return await Guardar();
        }

        public async Task<int> Eliminar(int id)
        {
            var cliente = await _db.clientes.FindAsync(id);
            if (cliente == null)
                return 0;

            _db.clientes.Remove(cliente);
            return await Guardar();
        }

        public async Task<int> Guardar()
        {
            return await _db.SaveChangesAsync();
        }

        public async Task<int> Modificar(int id, ClienteDTO cliente)
        {
            var entidad = await _db.clientes.FindAsync(id);
            if (cliente == null)
                return 0;

            entidad.Nombre = cliente.Nombre;
            _db.clientes.Update(entidad);
            return await Guardar();
        }

        Task<ICollection<ICliente>> ICliente.clientes()
        {
            throw new NotImplementedException();
        }
    }
}
