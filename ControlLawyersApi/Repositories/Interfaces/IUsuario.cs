using ControlLawyersApi.DTOs;

namespace ControlLawyersApi.Repositories.Interfaces
{
    public interface IUsuario
    {
        Task<int> Crear(UsuarioDTO usuario);
        Task<ICollection<IUsuario>> usuarios();
        Task<UsuarioDTO> Usuario(int id);
        Task<int> Modificar(int id, UsuarioDTO usuario);
        Task<int> Eliminar(int id);
        Task<int> Guardar();
    }
}
