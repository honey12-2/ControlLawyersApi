using ControlLawyersApi.DTOs;

namespace ControlLawyersApi.Repositories.Interfaces
{
    public interface IAsesoria
    {
        Task<int> Crear(AsesoriaDTO asesoria);
        Task<ICollection<IAsesoria>> asesorias();
        Task<AsesoriaDTO> Asesoria(int id);
        Task<int> Modificar(int id, AsesoriaDTO asesoria);
        Task<int> Eliminar(int id);
        Task<int> Guardar();
    }
}
