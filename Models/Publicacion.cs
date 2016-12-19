using System;

namespace Publicaciones.Models
{
    public class Publicacion
    {
        public int Id { get; set; }

        public string DOI { get; set; }

        public int PaginaInicio { get; set; }

        public int Volumen { get; set; }

        public string Issue { get; set; }

        public int PaginaFinal { get; set; }

        public int NumeroArticulo { get; set; }

        public DateTime Fecha { get; set; }

        public Categoria CategoriaPublicar { get; set; }  

        public Categoria CategoriaIndizar { get; set; }  
    
    }
}