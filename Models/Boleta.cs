using System;

namespace Publicaciones.Models
{
    public class Boleta{

        public int Id { get; set; }
        
        public int Numero { get; set; }

        public DateTime fechaEmision { get; set; }

        public int Monto { get; set; }

        public DateTime fechaEntrega { get; set; }

        public Boleta(){
                
        }

    }
}