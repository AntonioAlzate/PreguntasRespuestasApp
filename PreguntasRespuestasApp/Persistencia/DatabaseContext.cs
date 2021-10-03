using Microsoft.EntityFrameworkCore;
using PreguntasRespuestasApp.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PreguntasRespuestasApp.Persistencia
{
    public class DatabaseContext : DbContext
    {
        private string nameDb = "preguntas_respuestas.db";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(connectionString: $"FileName={nameDb}", sqliteOptionsAction: option =>
            {
                option.MigrationsAssembly(Assembly.GetExecutingAssembly().FullName);
            });
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Creación Categorías Iniciales
            Categoria categoria1 = new Categoria()
            {
                Id = 1,
                NivelDificultad = "Muy fácil",
                Puntos = 50
            };
            Categoria categoria2 = new Categoria()
            {
                Id = 2,
                NivelDificultad = "Fácil",
                Puntos = 150
            };
            Categoria categoria3 = new Categoria()
            {
                Id = 3,
                NivelDificultad = "Medio",
                Puntos = 250
            };
            Categoria categoria4 = new Categoria()
            {
                Id = 4,
                NivelDificultad = "Difícil",
                Puntos = 800
            };
            Categoria categoria5 = new Categoria()
            {
                Id = 5,
                NivelDificultad = "Muy difícil",
                Puntos = 1500
            };
            List<Categoria> categoriasIniciales = new List<Categoria>();
            categoriasIniciales.Add(categoria1);
            categoriasIniciales.Add(categoria2);
            categoriasIniciales.Add(categoria3);
            categoriasIniciales.Add(categoria4);
            categoriasIniciales.Add(categoria5);
            #endregion

            #region Creación Número rondas
            List<Ronda> rondas = new List<Ronda>()
            {
                new Ronda()
                {
                    Id=1, Numero=1
                },
                new Ronda()
                {
                    Id=2, Numero=2
                },
                new Ronda()
                {
                    Id=3, Numero=3
                },
                new Ronda()
                {
                    Id=4, Numero=4
                },
                new Ronda()
                {
                    Id=5, Numero=5
                }
            };

            #endregion

            #region Creación Preguntas
            List<Pregunta> preguntas = new List<Pregunta>()
            {
                new Pregunta()
                {
                    Id=1,
                    Enunciado = "¿Cuál es la capital de Venezuela?",
                    CategoriaId = 1
                },
                new Pregunta()
                {
                    Id=2,
                    Enunciado = "¿Cuál es la capital de Colombia?",
                    CategoriaId = 2
                },
                new Pregunta()
                {
                    Id=3,
                    Enunciado = "¿Cuál es la capital de EEUU?",
                    CategoriaId = 3
                },
                new Pregunta()
                {
                    Id=4,
                    Enunciado = "¿Cuál es la capital de Perú?",
                    CategoriaId = 4
                },
                new Pregunta()
                {
                    Id=5,
                    Enunciado = "¿Cuál es la capital de Uruguay?",
                    CategoriaId = 5
                }
            };

            #endregion

            #region Creación Respuestas

            List<Respuesta> respuestas = new List<Respuesta>()
            {
                new Respuesta(){ Id=1, PreguntaId = 1, Contenido = "Bogotá", EsCorrecta = false },
                new Respuesta(){Id=2,PreguntaId = 1,Contenido = "Venezuela",EsCorrecta = false},
                new Respuesta(){Id=3,PreguntaId = 1,Contenido = "Caracas",EsCorrecta = true},
                new Respuesta(){Id=4,PreguntaId = 1,Contenido = "Lima",EsCorrecta = false },

                new Respuesta(){Id=5, PreguntaId = 2, Contenido = "Bogotá", EsCorrecta = true },
                new Respuesta(){Id=6,PreguntaId = 2,Contenido = "Venezuela",EsCorrecta = false},
                new Respuesta(){Id=7,PreguntaId = 2,Contenido = "Caracas",EsCorrecta = false},
                new Respuesta(){Id=8,PreguntaId = 2,Contenido = "Lima",EsCorrecta = false },

                new Respuesta(){Id=9, PreguntaId = 3, Contenido = "Bogotá", EsCorrecta = false },
                new Respuesta(){Id=10,PreguntaId = 3,Contenido = "California",EsCorrecta = false},
                new Respuesta(){Id=11,PreguntaId = 3,Contenido = "Washington",EsCorrecta = true},
                new Respuesta(){Id=12,PreguntaId = 3,Contenido = "Lima",EsCorrecta = false },

                new Respuesta(){Id=13, PreguntaId = 4, Contenido = "Bogotá", EsCorrecta = false },
                new Respuesta(){Id=14,PreguntaId = 4,Contenido = "Venezuela",EsCorrecta = false},
                new Respuesta(){Id=15,PreguntaId = 4,Contenido = "Caracas",EsCorrecta = false},
                new Respuesta(){Id=16,PreguntaId = 4,Contenido = "Lima",EsCorrecta = true },

                new Respuesta(){ Id=17,PreguntaId = 5, Contenido = "Bogotá", EsCorrecta = false },
                new Respuesta(){Id=18,PreguntaId = 5,Contenido = "Montevideo",EsCorrecta = true},
                new Respuesta(){Id=19,PreguntaId = 5,Contenido = "Caracas",EsCorrecta = false},
                new Respuesta(){Id=20,PreguntaId = 5,Contenido = "Lima",EsCorrecta = false }
            };
            #endregion

            modelBuilder.Entity<Categoria>().HasData(categoriasIniciales);
            modelBuilder.Entity<Ronda>().HasData(rondas);
            modelBuilder.Entity<Pregunta>().HasData(preguntas);
            modelBuilder.Entity<Respuesta>().HasData(respuestas);

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Jugador> Jugadores { get; set; }
        public DbSet<Pregunta> Preguntas { get; set; }
        public DbSet<Puntaje> Puntajes { get; set; }
        public DbSet<Respuesta> Respuestas { get; set; }
        public DbSet<Ronda> Rondas { get; set; }
    }
}
