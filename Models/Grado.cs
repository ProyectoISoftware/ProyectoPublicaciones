using System;

namespace Publicaciones.Models
{
    public class Grado
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public DateTime Fecha { get; set; }

        public Grado ()
        {

        }

        public Grado (string Nombre, DateTime Fecha)
        {
            this.Id = 1;
            this.Nombre = Nombre;
            this.Fecha = Fecha;
        }
    }
}