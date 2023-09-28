using System.ComponentModel.DataAnnotations;

namespace ControlLawyersApi.Entities
{
    public class Usuario
    {
        [Key]

        public int Id { get; set; }
        public string NombreUsuario { get; set; }
        public string Clave { get; set; }
        public string Rol { get; set; }

    }
}
