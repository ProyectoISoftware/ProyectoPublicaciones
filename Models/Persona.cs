using System;
using System.Collections.Generic;

namespace Publicaciones.Models
{
    public class Persona
    {

        public string Id { get; set; }
        
        public string Rut { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public string Email { get; set; }

        public DateTime FechaNacimiento {get; set;}

        public List<Autor> Autores {get; set;}

        public List<Grado> Grados {get; set;}

        public Contrato Contrato {get; set;}

        public Persona(){
            
        }

        public Persona(string rut, string nombre, string email, DateTime fechaN){
            this.Rut = rut;
            this.Nombre = nombre;
            this.Email = email;
            this.FechaNacimiento = fechaN;
        }

        public void AgregarGrado(string nombre, DateTime fecha){
            this.Grados.Add(new Grado(nombre,fecha));
        }
    
    }
}