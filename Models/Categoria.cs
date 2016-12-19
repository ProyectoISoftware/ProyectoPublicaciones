using System;

namespace Publicaciones.Models
{
    public class Categoria
    {
        public int Id { get; set; }

        public string Q { get; set; }

        public string JIF { get; set; }

        public DateTime Fecha { get; set; }

        public Indice Indice { get; set; }  
    }
}