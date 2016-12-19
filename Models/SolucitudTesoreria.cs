using System;

namespace Publicaciones.Models
{
    public class SolicitudTesoreria{

        public int Id { get; set; }
        public DateTime fechaRealizada;
        public DateTime fechaRecepcionFinanza;
        public int numeroAsignado;

        public int numeroArchivador;

        public DateTime fechaCancelacion;

        public SolicitudTesoreria(){
                
        }



    }

}