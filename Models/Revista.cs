using System.Collections.Generic;

namespace Publicaciones.Models
{
    public class Revista
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public string ISSN { get; set; }

        public string IndiceMayorCategoria { get; set; }  

        public List<Categoria> categorias { get; set; }  
    }
}