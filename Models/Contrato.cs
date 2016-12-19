using System;

namespace Publicaciones.Models
{
    public class Contrato
    {
        public int Id { get; set; }

        public string Jornada { get; set; }

        public int NumeroHoras { get; set; }

        public string Jerarquia { get; set; }

        public DateTime Fecha { get; set; }

        public string Vinculo { get; set; }

        public string Tipo { get; set; }

        public Unidad Unidad { get; set; } 
    }
}