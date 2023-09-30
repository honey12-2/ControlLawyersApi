using ControlLawyersApi.DTOs;

namespace ControlLawyersApi.Repositories.Interfaces
{
    public interface ICliente
    {
        Task<int> Crear(ClienteDTO cliente);
        Task<ICollection<ICliente>> clientes();
        Task<ClienteDTO> Cliente(int id);
        Task<int> Modificar(int id, ClienteDTO cliente);
        Task<int> Eliminar(int id);
        Task<int> Guardar();
    }
}
}
