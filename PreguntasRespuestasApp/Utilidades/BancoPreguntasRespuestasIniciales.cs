using PreguntasRespuestasApp.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreguntasRespuestasApp.Utilidades
{
    public static class BancoPreguntasRespuestasIniciales
    {
        public static List<Pregunta> ObtenerPreguntasIniciales()
        {

            List<Pregunta> preguntas = new List<Pregunta>()
            {
                // Categoría 1
                new Pregunta(){ Id=1, Enunciado = "¿Cuál es el resultado de hacer la operación 2+2?", CategoriaId = 1 },
                new Pregunta(){ Id=2,Enunciado = "¿Cuál es la capital de Venezuela?",CategoriaId = 1 },
                new Pregunta(){ Id=3,Enunciado = "¿En qué país se encuentra ubicada la Torre Eiffel?",CategoriaId = 1},
                new Pregunta(){ Id=4, Enunciado = "¿Cuál es el resultado de hacer la operación 5x2?", CategoriaId = 1},
                new Pregunta(){Id=5,Enunciado = "¿Cuál es la capital de Colombia?",CategoriaId = 1},

                // Categoría 2
                new Pregunta(){ Id=6, Enunciado = "¿Cuántas patas tiene una araña?", CategoriaId = 2 },
                new Pregunta(){ Id=7,Enunciado = "¿Cuál es la moneda oficial de Estados Unidos?",CategoriaId = 2 },
                new Pregunta(){ Id=8,Enunciado = "¿A quién le crecía la nariz cuando mentía?",CategoriaId = 2},
                new Pregunta(){ Id=9, Enunciado = "¿Quién traicionó a Jesús?", CategoriaId = 2},
                new Pregunta(){Id=10,Enunciado = "¿Cuál es la capital de Italia?",CategoriaId = 2},

                // Categoría 3
                new Pregunta(){ Id=11, Enunciado = "El triángulo que tiene sus tres lados iguales ¿Cómo se llama?", CategoriaId = 3 },
                new Pregunta(){ Id=12,Enunciado = "¿En qué país se usó la primera bomba atómica en combate?",CategoriaId = 3 },
                new Pregunta(){ Id=13,Enunciado = "¿Cómo se llama el fundador de Facebook?",CategoriaId = 3},
                new Pregunta(){ Id=14, Enunciado = "¿Qué selección nacional ha ganado más Copas Mundiales de Fútbol?", CategoriaId = 3},
                new Pregunta(){Id=15,Enunciado = "¿Cuál es el órgano más grande del cuerpo humano?",CategoriaId = 3},

                // Categoría 4
                new Pregunta(){ Id=16, Enunciado = "¿En qué año cayó el muro de Berlín?", CategoriaId = 4 },
                new Pregunta(){ Id=17,Enunciado = "¿Cuál es el “País del Sol Naciente”?",CategoriaId = 4 },
                new Pregunta(){ Id=18,Enunciado = "¿En qué país se encuentra la región de Transilvania?",CategoriaId = 4},
                new Pregunta(){ Id=19, Enunciado = "¿Cuáles son los cinco tipos de sabores primarios?", CategoriaId = 4},
                new Pregunta(){Id=20,Enunciado = "¿Cuál es el lugar más frío de la tierra?",CategoriaId = 4},

                // Categoría 5
                new Pregunta(){ Id=21, Enunciado = "¿En qué año finalizo la II Guerra Mundial?", CategoriaId = 5 },
                new Pregunta(){ Id=22,Enunciado = "¿Cómo se llama la estación espacial rusa?",CategoriaId = 5 },
                new Pregunta(){ Id=23,Enunciado = "¿A qué país pertenece la ciudad de Varsovia?",CategoriaId = 5},
                new Pregunta(){ Id=24, Enunciado = "¿Cuál es la capital de Croacia?", CategoriaId = 5},
                new Pregunta(){Id=25,Enunciado = "¿Cuál es el metal más caro del mundo?",CategoriaId = 5}
            };

            return preguntas;
        }

        public static List<Respuesta> ObtenerRespuestasIniciales()
        {

            List<Respuesta> respuestas = new List<Respuesta>()
            {
                new Respuesta(){ Id=1, PreguntaId = 1, Contenido = "5", EsCorrecta = false },
                new Respuesta(){Id=2,PreguntaId = 1,Contenido = "2",EsCorrecta = false},
                new Respuesta(){Id=3,PreguntaId = 1,Contenido = "4",EsCorrecta = true},
                new Respuesta(){Id=4,PreguntaId = 1,Contenido = "7",EsCorrecta = false },

                new Respuesta(){Id=5, PreguntaId = 2, Contenido = "Bogotá", EsCorrecta = false },
                new Respuesta(){Id=6,PreguntaId = 2,Contenido = "Caracas",EsCorrecta = true},
                new Respuesta(){Id=7,PreguntaId = 2,Contenido = "Lima",EsCorrecta = false},
                new Respuesta(){Id=8,PreguntaId = 2,Contenido = "Maracaibo",EsCorrecta = false },

                new Respuesta(){Id=9, PreguntaId = 3, Contenido = "Francia", EsCorrecta = true },
                new Respuesta(){Id=10,PreguntaId = 3,Contenido = "Inglaterra",EsCorrecta = false},
                new Respuesta(){Id=11,PreguntaId = 3,Contenido = "Estados Unidos",EsCorrecta = false},
                new Respuesta(){Id=12,PreguntaId = 3,Contenido = "Japón",EsCorrecta = false },

                new Respuesta(){Id=13, PreguntaId = 4, Contenido = "11", EsCorrecta = false },
                new Respuesta(){Id=14,PreguntaId = 4,Contenido = "10",EsCorrecta = true},
                new Respuesta(){Id=15,PreguntaId = 4,Contenido = "8",EsCorrecta = false},
                new Respuesta(){Id=16,PreguntaId = 4,Contenido = "5",EsCorrecta = false },

                new Respuesta(){ Id=17,PreguntaId = 5, Contenido = "Bogotá", EsCorrecta = true },
                new Respuesta(){Id=18,PreguntaId = 5,Contenido = "Caracas",EsCorrecta = false},
                new Respuesta(){Id=19,PreguntaId = 5,Contenido = "Lima",EsCorrecta = false},
                new Respuesta(){Id=20,PreguntaId = 5,Contenido = "Maracaibo",EsCorrecta = false },

                new Respuesta(){ Id=21, PreguntaId = 6, Contenido = "6", EsCorrecta = false },
                new Respuesta(){Id=22,PreguntaId = 6,Contenido = "9",EsCorrecta = false},
                new Respuesta(){Id=23,PreguntaId = 6,Contenido = "8",EsCorrecta = true},
                new Respuesta(){Id=24,PreguntaId = 6,Contenido = "10",EsCorrecta = false },

                new Respuesta(){Id=25, PreguntaId = 7, Contenido = "Peso Americano", EsCorrecta = false },
                new Respuesta(){Id=26,PreguntaId = 7,Contenido = "Peseta",EsCorrecta = false},
                new Respuesta(){Id=27,PreguntaId = 7,Contenido = "Euro",EsCorrecta = false},
                new Respuesta(){Id=28,PreguntaId = 7,Contenido = "Dólar",EsCorrecta = true },

                new Respuesta(){Id=29, PreguntaId = 8, Contenido = "Pinocho", EsCorrecta = true },
                new Respuesta(){Id=30,PreguntaId = 8,Contenido = "Cenicienta",EsCorrecta = false},
                new Respuesta(){Id=31,PreguntaId = 8,Contenido = "Bestia",EsCorrecta = false},
                new Respuesta(){Id=32,PreguntaId = 8,Contenido = "Gepetto",EsCorrecta = false },

                new Respuesta(){Id=33, PreguntaId = 9, Contenido = "Pablo", EsCorrecta = false },
                new Respuesta(){Id=34,PreguntaId = 9,Contenido = "Judas",EsCorrecta = true},
                new Respuesta(){Id=35,PreguntaId = 9,Contenido = "Gabriel",EsCorrecta = false},
                new Respuesta(){Id=36,PreguntaId = 9,Contenido = "Juan",EsCorrecta = false },

                new Respuesta(){ Id=37,PreguntaId = 10, Contenido = "Milán", EsCorrecta = false },
                new Respuesta(){Id=38,PreguntaId = 10,Contenido = "Roma",EsCorrecta = true},
                new Respuesta(){Id=39,PreguntaId = 10,Contenido = "Napoli",EsCorrecta = false},
                new Respuesta(){Id=40,PreguntaId = 10,Contenido = "Ámsterdam",EsCorrecta = false },

                new Respuesta(){ Id=41, PreguntaId = 11, Contenido = "Isósceles", EsCorrecta = false },
                new Respuesta(){Id=42,PreguntaId = 11,Contenido = "Rectángulo",EsCorrecta = false},
                new Respuesta(){Id=43,PreguntaId = 11,Contenido = "Equilátero",EsCorrecta = true},
                new Respuesta(){Id=44,PreguntaId = 11,Contenido = "Igualitario",EsCorrecta = false },

                new Respuesta(){Id=45, PreguntaId = 12, Contenido = "Estados Unidos", EsCorrecta = false },
                new Respuesta(){Id=46,PreguntaId = 12,Contenido = "Alemania",EsCorrecta = false},
                new Respuesta(){Id=47,PreguntaId = 12,Contenido = "Japón",EsCorrecta = true},
                new Respuesta(){Id=48,PreguntaId = 12,Contenido = "Rusia",EsCorrecta = false },

                new Respuesta(){Id=49, PreguntaId = 13, Contenido = "Elon Musk", EsCorrecta = false },
                new Respuesta(){Id=50,PreguntaId = 13,Contenido = "Mark Zuckerberg",EsCorrecta = true},
                new Respuesta(){Id=51,PreguntaId = 13,Contenido = "Tim Cook",EsCorrecta = false},
                new Respuesta(){Id=52,PreguntaId = 13,Contenido = "Bill Gates",EsCorrecta = false },

                new Respuesta(){Id=53, PreguntaId = 14, Contenido = "Italia", EsCorrecta = false },
                new Respuesta(){Id=54,PreguntaId = 14,Contenido = "Alemania",EsCorrecta = false},
                new Respuesta(){Id=55,PreguntaId = 14,Contenido = "Francia",EsCorrecta = false},
                new Respuesta(){Id=56,PreguntaId = 14,Contenido = "Brasil",EsCorrecta = true },

                new Respuesta(){ Id=57,PreguntaId = 15, Contenido = "Corazón", EsCorrecta = false },
                new Respuesta(){Id=58,PreguntaId = 15,Contenido = "Pulmón",EsCorrecta = true},
                new Respuesta(){Id=59,PreguntaId = 15,Contenido = "Riñón",EsCorrecta = false},
                new Respuesta(){Id=60,PreguntaId = 15,Contenido = "Piel",EsCorrecta = true },

                new Respuesta(){ Id=61, PreguntaId = 16, Contenido = "1990", EsCorrecta = false },
                new Respuesta(){Id=62,PreguntaId = 16,Contenido = "1989",EsCorrecta = true},
                new Respuesta(){Id=63,PreguntaId = 16,Contenido = "1955",EsCorrecta = false},
                new Respuesta(){Id=64,PreguntaId = 16,Contenido = "1978",EsCorrecta = false },

                new Respuesta(){Id=65, PreguntaId = 17, Contenido = "Estados Unidos", EsCorrecta = false },
                new Respuesta(){Id=66,PreguntaId = 17,Contenido = "Australia",EsCorrecta = false},
                new Respuesta(){Id=67,PreguntaId = 17,Contenido = "Japón",EsCorrecta = true},
                new Respuesta(){Id=68,PreguntaId = 17,Contenido = "Mexico",EsCorrecta = false },

                new Respuesta(){Id=69, PreguntaId = 18, Contenido = "Rumania", EsCorrecta = true },
                new Respuesta(){Id=70,PreguntaId = 18,Contenido = "Rusia",EsCorrecta = false},
                new Respuesta(){Id=71,PreguntaId = 18,Contenido = "España",EsCorrecta = false},
                new Respuesta(){Id=72,PreguntaId = 18,Contenido = "Inglaterra",EsCorrecta = false },

                new Respuesta(){Id=73, PreguntaId = 19, Contenido = "Dulce, amargo, ácido, salado, rancio", EsCorrecta = false },
                new Respuesta(){Id=74,PreguntaId = 19,Contenido = "Dulce, amargo, fuerte, salado, umami",EsCorrecta = false},
                new Respuesta(){Id=75,PreguntaId = 19,Contenido = "Dulce, invasivo, ácido, salado, rancio",EsCorrecta = false},
                new Respuesta(){Id=76,PreguntaId = 19,Contenido = "Dulce, amargo, ácido, salado, umami",EsCorrecta = true },

                new Respuesta(){ Id=77,PreguntaId = 20, Contenido = "Islandia", EsCorrecta = false },
                new Respuesta(){Id=78,PreguntaId = 20,Contenido = "La Antártida",EsCorrecta = true},
                new Respuesta(){Id=79,PreguntaId = 20,Contenido = "Finlandia",EsCorrecta = false},
                new Respuesta(){Id=80,PreguntaId = 20,Contenido = "Rusia",EsCorrecta = false },

                new Respuesta(){ Id=81, PreguntaId = 21, Contenido = "1944", EsCorrecta = false },
                new Respuesta(){Id=82,PreguntaId = 21,Contenido = "1943",EsCorrecta = false},
                new Respuesta(){Id=83,PreguntaId = 21,Contenido = "1945",EsCorrecta = true},
                new Respuesta(){Id=84,PreguntaId = 21,Contenido = "1949",EsCorrecta = false },

                new Respuesta(){Id=85, PreguntaId = 22, Contenido = "Estación espacial internacional", EsCorrecta = false },
                new Respuesta(){Id=86,PreguntaId = 22,Contenido = "Mir",EsCorrecta = true},
                new Respuesta(){Id=87,PreguntaId = 22,Contenido = "Putin",EsCorrecta = false},
                new Respuesta(){Id=88,PreguntaId = 22,Contenido = "Estación Rusa",EsCorrecta = false },

                new Respuesta(){Id=89, PreguntaId = 23, Contenido = "Polonia", EsCorrecta = true },
                new Respuesta(){Id=90,PreguntaId = 23,Contenido = "Rusia",EsCorrecta = false},
                new Respuesta(){Id=91,PreguntaId = 23,Contenido = "Suecia",EsCorrecta = false},
                new Respuesta(){Id=92,PreguntaId = 23,Contenido = "Rumania",EsCorrecta = false },

                new Respuesta(){Id=93, PreguntaId = 24, Contenido = "Zadar", EsCorrecta = false },
                new Respuesta(){Id=94,PreguntaId = 24,Contenido = "Pula",EsCorrecta = false},
                new Respuesta(){Id=95,PreguntaId = 24,Contenido = "Zagreb",EsCorrecta = true},
                new Respuesta(){Id=96,PreguntaId = 24,Contenido = "Rijeka",EsCorrecta = false },

                new Respuesta(){ Id=97,PreguntaId = 25, Contenido = "Oro", EsCorrecta = false },
                new Respuesta(){Id=98,PreguntaId = 25,Contenido = "Platino",EsCorrecta = false},
                new Respuesta(){Id=99,PreguntaId = 25,Contenido = "Paladio",EsCorrecta = false},
                new Respuesta(){Id=100,PreguntaId = 25,Contenido = "Rodio",EsCorrecta = true },
            };

            return respuestas;
        }
    }
}
