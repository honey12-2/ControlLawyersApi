using System.ComponentModel.DataAnnotations;

namespace ControlLawyersApi.Entities
{
    public class Categoria
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
    }
}
