namespace Publicaciones.Models
{
    public class Unidad
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public string Direccion { get; set; }

        public Unidad UnidadSuperior { get; set; } 
    }
}