using System.Collections.Generic;

namespace Publicaciones.Models
{
    public class Postulacion
    {
        public int Id { get; set; }

        public List<Estado> Estado { get; set; }
    }
}