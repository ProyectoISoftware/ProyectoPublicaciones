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

        public Publicacion(){

        }

        public Publicacion( int id, string doi, int pagIni, int volumen, string issue, int pagFin, int numArt, int año, int mes, int dia, Categoria catIndi, Categoria catPub){
            this.Id=id;
            this.DOI=doi;
            this.PaginaInicio=pagIni;

            this.Volumen=volumen;
            this.Issue=issue;
            this.PaginaFinal=pagFin;
            this.NumeroArticulo= numArt;
            this.Fecha= new DateTime(año,mes,dia);

            this.CategoriaPublicar= catPub;
            this.CategoriaIndizar= catIndi;
        }

        public bool Equals(Publicacion p){

            bool var = this.Id == p.Id;
            var = var && this.DOI == p.DOI;
            var = var && this.PaginaInicio == p.PaginaInicio;
            var = var && this.Volumen == p.Volumen;
            var = var && this.Issue == p.Issue;
            var = var && this.PaginaFinal == p.PaginaFinal;
            var = var && this.NumeroArticulo == p.NumeroArticulo;
            var = var && DateTime.Compare(this.Fecha, p.Fecha) == 0;
            if(this.CategoriaPublicar != null){
                var = var && this.CategoriaPublicar.Equals(p.CategoriaPublicar);
            }
            if(this.CategoriaIndizar != null){
                var = var && this.CategoriaIndizar.Equals(p.CategoriaIndizar);
            }
            return var;
        }
    }
}
