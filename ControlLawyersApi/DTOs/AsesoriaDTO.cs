namespace ControlLawyersApi.DTOs
{
    public class AsesoriaDTO
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public string Descripcion { get; set; }
        public int IdCliente { get; set; }
        public int IdCategoria { get; set; }
        public int IdUsuario { get; set; }
        public string Estado { get; set; }
    }
}
