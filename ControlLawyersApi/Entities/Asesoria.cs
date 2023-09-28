using System.ComponentModel.DataAnnotations;

namespace ControlLawyersApi.Entities
{
    public class Asesoria
    {
        [Key]
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public string Descripcion { get; set; }
        public int IdCliente { get; set; }
        public int IdCategoria { get; set; }
        public int IdUsuario { get; set; }
        public string Estado { get; set; }

    }
}
