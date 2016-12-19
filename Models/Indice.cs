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

        public bool Equals(Indice i ){
            bool var = this.Id == i.Id;
            var = var && this.Nombre.Equals(i.Nombre);
            return var;
        }
    }
}
