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
            #region Creacion Categorias Iniciales
            // Insertando las categorias iniciales
            Categoria categoria1 = new Categoria()
            {
                Id = 1,
                NivelDificultad = "muy fácil",
                Puntos = 50
            };
            Categoria categoria2 = new Categoria()
            {
                Id = 2,
                NivelDificultad = "fácil",
                Puntos = 150
            };
            Categoria categoria3 = new Categoria()
            {
                Id = 3,
                NivelDificultad = "medio",
                Puntos = 250
            };
            Categoria categoria4 = new Categoria()
            {
                Id = 4,
                NivelDificultad = "difícil",
                Puntos = 800
            };
            Categoria categoria5 = new Categoria()
            {
                Id = 5,
                NivelDificultad = "muy difícil",
                Puntos = 1500
            };
            List<Categoria> categoriasIniciales = new List<Categoria>();
            categoriasIniciales.Add(categoria1);
            categoriasIniciales.Add(categoria2);
            categoriasIniciales.Add(categoria3);
            categoriasIniciales.Add(categoria4);
            categoriasIniciales.Add(categoria5); 
            #endregion

            modelBuilder.Entity<Categoria>().HasData(categoriasIniciales);

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
