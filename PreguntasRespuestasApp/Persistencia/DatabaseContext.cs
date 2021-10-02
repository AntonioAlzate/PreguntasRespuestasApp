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

        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Jugador> Jugadores { get; set; }
        public DbSet<Pregunta> Preguntas { get; set; }
        public DbSet<Puntaje> Puntajes { get; set; }
        public DbSet<Respuesta> Respuestas { get; set; }
        public DbSet<Ronda> Rondas { get; set; }
    }
}
