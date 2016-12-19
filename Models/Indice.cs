namespace Publicaciones.Models
{
    public class Indice
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public Indice(int id, string nombre){
            this.Id= id;
            this.Nombre= nombre;
        }
    }
}
