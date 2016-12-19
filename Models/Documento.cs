using System;
using System.Collections.Generic;

namespace Publicaciones.Models
{
    public class Documento
    {
        public int Id { get; set; }

        public string Titulo { get; set; }

        public string Resumen { get; set; }

        public DateTime FechaInicio { get; set; }

        public DateTime FechaTermino { get; set; }

        public string LineaDeInvestigacion { get; set; }

        public string AreaDesarrollo { get; set; }

        public string Tipo { get; set; }

        public List<Postulacion> Postulaciones { get; set; }  

        public Publicacion Publicacion { get; set; } 

        public Autor AutorPrincipal { get; set; }  

        public Autor AutorCorrespondiente { get; set; } 

        public Documento (){

        }

        public Documento(string Titulo, string Resumen, DateTime FechaInicio, DateTime FechaTermino, string LineaDeInvestigacion, string AreaDesarrollo, string Tipo)
        {
            this.Id = 1;
            this.Titulo = Titulo;
            this.Resumen = Resumen;
            this.FechaInicio = FechaInicio;
            this.FechaTermino = FechaTermino;
            this.LineaDeInvestigacion = LineaDeInvestigacion;
            this.AreaDesarrollo = AreaDesarrollo;
            this.Tipo = Tipo;
        }
    }
}