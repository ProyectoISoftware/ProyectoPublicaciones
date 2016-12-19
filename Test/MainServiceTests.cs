using Xunit;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Publicaciones.Backend;
using System.Linq;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using Publicaciones.Models;

namespace Publicaciones.Service {

    public class MainServiceTest : IDisposable
    {
        IMainService Service { get; set; }

        ILogger Logger { get; set; }

        public MainServiceTest()
        {
            // Logger Factory
            ILoggerFactory loggerFactory = new LoggerFactory().AddConsole().AddDebug();
            Logger = loggerFactory.CreateLogger<MainServiceTest>();

            Logger.LogInformation("Initializing Test ..");

            // SQLite en memoria
            var connection = new SqliteConnection("DataSource=:memory:");
            connection.Open();

            // Opciones de inicializacion del BackendContext
            var options = new DbContextOptionsBuilder<BackendContext>()
            .UseSqlite(connection)
            .Options;

            // inicializacion del BackendContext
            BackendContext backend = new BackendContext(options);
            // Crear la base de datos
            backend.Database.EnsureCreated();

            // Servicio a probar
            Service = new MainService(backend, loggerFactory);

            Logger.LogInformation("Initialize Test ok.");
        }

        [Fact]
        public void InitializeTest()
        {
            Logger.LogInformation("Testing IMainService.Initialize() ..");
            Service.Initialize();

            // No se puede inicializar 2 veces
            Assert.Throws<Exception>( () => { Service.Initialize(); });

            // Personas en la BD
            List<Persona> personas = Service.Personas();

            // Debe ser !=  de null
            Assert.True(personas != null);

            // Debe haber solo 1
            Assert.True(personas.Count == 1);

            // Print de la persona
            foreach(Persona persona in personas) {
                Logger.LogInformation("Persona: {0}", persona);
            }

            Logger.LogInformation("Test IMainService.Initialize() ok");
        }

        [Fact]
        public void testObtenerPublicaciones()
        {
            Logger.LogInformation("Testing IMainService.ObtenerPublicaciones() ..");
            //Limpiar publicaciones
            Service.vaciarPublicaciones();
            //Obtener publicaciones -> debe ser cero
            List <Publicacion> listPublicaciones = Service.obtenerPublicaciones();
            Assert.True(listPublicaciones.Count == 0);
            Logger.LogInformation("ObtenerPublicaciones vacio ok");
            //Ingresar 1 publicacion
            int id = 10;
            string doi = "aa11";
            int pagIn = 5;
            int volumen = 12;
            string issue = "issue1";
            int pagFin = 15;
            int numArt = 15;
            int año = 2010;
            int mes = 10;
            int dia = 5;
            Categoria catInd = null;
            Categoria catPub = null;

            Publicacion p = new Publicacion(id, doi, pagIn, volumen, issue, pagFin, numArt, año, mes, dia, catInd, catPub);
            
            Service.addPublicacion(p);
            //Obtener publicaciones -> debe ser canitdad 1
            //                      -> datos que se ingresaron deben ser equivalentes al original
            listPublicaciones = Service.obtenerPublicaciones();

            Assert.True(listPublicaciones.Count == 1);
            Assert.True(listPublicaciones[0].Equals(p));

            Logger.LogInformation("ObtenerPublicaciones una publicacion ok");
            //Ingresar 28 nuevas publicaciones
            for( int i = 1; i <= 28; i++){
                id = 10 + i;
                doi = "aa11" + i;
                pagIn = 5 + i;
                volumen = 12 + i;
                issue = "issue1" + i;
                pagFin = 15 + i;
                numArt = 15 + i;
                año = 2010;
                mes = 10;
                dia = 1 + i;
                catInd = null;
                catPub = null;

                p = new Publicacion(id, doi, pagIn, volumen, issue, pagFin, numArt, año, mes, dia, catInd, catPub);
                Service.addPublicacion(p);
            }
            //Obtener publicaciones -> debe ser cantidad 29
            Assert.True(listPublicaciones.Count == 29);

            Logger.LogInformation("ObtenerPublicaciones varias publicaciones ok");

            Logger.LogInformation("Test IMainService.ObtenerPublicaciones() ok");
        }

        void IDisposable.Dispose()
        {
             // Aca eliminar el Service
        }
    }

}