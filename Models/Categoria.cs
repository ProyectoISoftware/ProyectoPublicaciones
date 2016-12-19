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

        public bool Equals(Categoria c ){
            bool var = this.Id == c.Id;
            var = var && this.Q.Equals(c.Q);
            var = var && this.JIF == c.JIF;
            var = var && this.Indice.Equals(c.Indice);
            int result = DateTime.Compare(this.Fecha, c.Fecha);
            if(result!=0){var =false;}
            return var;
        }
    }
}
