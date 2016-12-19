using System;

namespace Publicaciones.Models
{
    public class Categoria
    {
        public int Id { get; set; }

        public string Q { get; set; }

        public float JIF { get; set; }

        public DateTime Fecha { get; set; }

        public Indice Indice { get; set; }  

        public Categoria(int id, string q, float jif, int año, int mes, int dia, Indice indi){
            this.Id=id;
            this.Q= q;
            this.JIF=jif;

            this.Fecha=new DateTime(año,mes,dia);

            this.Indice= indi;
        }
    }
}
