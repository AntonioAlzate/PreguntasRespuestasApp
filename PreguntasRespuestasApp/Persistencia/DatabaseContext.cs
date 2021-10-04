using Microsoft.EntityFrameworkCore;
using PreguntasRespuestasApp.Entidades;
using PreguntasRespuestasApp.Utilidades;
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
            List<Categoria> categoriasIniciales = new List<Categoria>()
            {
                new Categoria()
                {
                    Id = 1,
                    NivelDificultad = "Muy fácil",
                    Puntos = 50
                },
                new Categoria()
                {
                    Id = 2,
                    NivelDificultad = "Fácil",
                    Puntos = 150
                },
                new Categoria()
                {
                    Id = 3,
                    NivelDificultad = "Medio",
                    Puntos = 250
                },
                new Categoria()
                {
                    Id = 4,
                    NivelDificultad = "Difícil",
                    Puntos = 800
                },
                new Categoria()
                {
                    Id = 5,
                    NivelDificultad = "Muy difícil",
                    Puntos = 1500
                }
            };
        
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

            List<Respuesta> respuestas = BancoPreguntasRespuestasIniciales.ObtenerRespuestasIniciales();
            List<Pregunta> preguntas = BancoPreguntasRespuestasIniciales.ObtenerPreguntasIniciales();

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
