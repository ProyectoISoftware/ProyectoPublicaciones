using System;

namespace Publicaciones.Models
{
    public class Incentivo
    {
        public int Id { get; set; }
        public int monto { get; set; }

        public string Observacion { get; set; }

        public DateTime FechaCancelado { get; set; }

        public Incentivo(){
                
        }

    }    
}