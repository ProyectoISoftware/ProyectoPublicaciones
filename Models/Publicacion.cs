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

        public Categoria CategoriaPublicar { get; set; }  // ???

        public Categoria CategoriaIndizar { get; set; }  // ???

        public Publicacion( int id, string doi, int pagIni, int paginaIni, int volumen, string issue, int pagFin, int numArt, int año, int mes, int dia, Categoria catIndi, Categoria catPub){
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
    
    }
}
