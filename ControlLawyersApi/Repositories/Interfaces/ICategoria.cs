using ControlLawyersApi.DTOs;

namespace ControlLawyersApi.Repositories.Interfaces
{
    public interface ICategoria
    {
        Task<int> Crear(CategoriaDTO categoria);
        Task<ICollection<ICategoria>> categorias();
        Task<CategoriaDTO> Categoria(int id);
        Task<int> Modificar(int id, CategoriaDTO categoria);
        Task<int> Eliminar(int id);
        Task<int> Guardar();
    }
}

    

