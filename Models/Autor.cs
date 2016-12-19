using System;
using System.Collections.Generic;
using Publicaciones.Service;

namespace Publicaciones.Models
{
    public class Autor
    {
        public int Id { get; set; }

        public DateTime Fecha { get; set; }

        public List<Documento> Documentos { get; set;}  

        public List<Unidad> Unidad { get; set;} 

        public List<Grado> Grado { get; set;} 

    }
}