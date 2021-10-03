using PreguntasRespuestasApp.Entidades;
using PreguntasRespuestasApp.Repository;
using PreguntasRespuestasApp.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PreguntasRespuestasApp.Presentacion
{
    public partial class FrmResponderPregunta : Form
    {

        #region Para Presentación
        private int categoria = 1;
        private string valorCategoria;
        private int ronda = 1;
        private int puntosPreguntaActual = 0;
        private int puntosAcumulados = 0;
        private string nombreJugador;

        private string RONDA_ACTUAL = "RONDA NÚMERO: ";
        private string CATEGORIA_PREGUNTA = "CATEGORÍA DE LA PREGUNTA: ";
        private string PUNTOS_PREGUNTA = "PUNTOS POR ACERTAR ESTA PREGUNTA: ";
        private string PUNTAJE_ACUMULADO = "ACTUALMENTE TIENES: ";
        #endregion

        #region Datos internos
        private int idPreguntaElegida;

        private bool EsCorrectaRespuestaA;
        private bool EsCorrectaRespuestaB;
        private bool EsCorrectaRespuestaC;
        private bool EsCorrectaRespuestaD;
        #endregion

        PreguntaRepositorio preguntaRepositorio;
        CategoriaRepositorio categoriaRepositorio;
        PuntajeRepositorio puntajeRepositorio;

        public FrmResponderPregunta()
        {
            InitializeComponent();
            preguntaRepositorio = new PreguntaRepositorio();
            categoriaRepositorio = new CategoriaRepositorio();
            puntajeRepositorio = new PuntajeRepositorio();

            PasarASiguientePregunta();
        }

        private void PasarASiguientePregunta()
        {
            ActualizarValorCategoria();
            ActualizarPregunta(categoria);
            ActualizarMarcadoresEnPantalla();
            QuitarSeleccionRespuesta();
        }

        private void ActualizarPregunta(int categoria)
        {
            Pregunta preguntaConRespuestas = SeleccionarPreguntaCategoria(categoria);

            PonerEnPantallaPreguntaElegida(preguntaConRespuestas);
            AsignarValidesDeRespuestas(preguntaConRespuestas);

            puntosPreguntaActual = categoriaRepositorio.ObtenerPorNivelDificultad(valorCategoria).Puntos;

        }

        private void ActualizarMarcadoresEnPantalla()
        {
            lblNumeroRonda.Text = RONDA_ACTUAL + ronda.ToString();
            lblCategoriaPregunta.Text = CATEGORIA_PREGUNTA + valorCategoria;
            lblPuntosPregunta.Text = PUNTOS_PREGUNTA + puntosPreguntaActual.ToString();
            lblPuntajeActual.Text = PUNTAJE_ACUMULADO + puntosAcumulados.ToString() + " PUNTOS";

        }

        private void ActualizarValorCategoria()
        {
            if (categoria == 1)
                valorCategoria = CategoriasExistentes.CATEGORIA_1;

            if (categoria == 2)
                valorCategoria = CategoriasExistentes.CATEGORIA_2;

            if (categoria == 3)
                valorCategoria = CategoriasExistentes.CATEGORIA_3;

            if (categoria == 4)
                valorCategoria = CategoriasExistentes.CATEGORIA_4;

            if (categoria == 5)
                valorCategoria = CategoriasExistentes.CATEGORIA_5;
        }

        private void QuitarSeleccionRespuesta()
        {
            rbOpcionA.Checked = false;
            rbOpcionB.Checked = false;
            rbOpcionC.Checked = false;
            rbOpcionD.Checked = false;
        }

        private Pregunta SeleccionarPreguntaCategoria(int categoria)
        {
            List<Pregunta> preguntas = preguntaRepositorio.ObtenerPorCategoriaConRespuestas(categoria);

            return SeleccionarPreguntaRandom(preguntas);
        }

        private Pregunta SeleccionarPreguntaRandom(List<Pregunta> preguntas)
        {
            Random random = new Random();
            int n = random.Next(0, preguntas.Count());

            return preguntas[n];
        }

        private void PonerEnPantallaPreguntaElegida(Pregunta preguntaConRespuestas)
        {
            gboxRespuestas.Text = preguntaConRespuestas.Enunciado;

            rbOpcionA.Text = preguntaConRespuestas.Respuestas[0].Contenido;
            rbOpcionB.Text = preguntaConRespuestas.Respuestas[1].Contenido;
            rbOpcionC.Text = preguntaConRespuestas.Respuestas[2].Contenido;
            rbOpcionD.Text = preguntaConRespuestas.Respuestas[3].Contenido;
        }

        private void AsignarValidesDeRespuestas(Pregunta preguntaConRespuestas)
        {
            EsCorrectaRespuestaA = preguntaConRespuestas.Respuestas[0].EsCorrecta;
            EsCorrectaRespuestaB = preguntaConRespuestas.Respuestas[1].EsCorrecta;
            EsCorrectaRespuestaC = preguntaConRespuestas.Respuestas[2].EsCorrecta;
            EsCorrectaRespuestaD = preguntaConRespuestas.Respuestas[3].EsCorrecta;
        }

        private void btnAbandonar_Click(object sender, EventArgs e)
        {
            FrmInicio frmInicio = new FrmInicio();
            frmInicio.Show();

            this.Close();
        }

        private void btnResponder_Click(object sender, EventArgs e)
        {

            if (!EstaSeleccionadaRespuesta())
            {
                MessageBox.Show("Debes seleccionar una respuesta", "Sin selección",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                DialogResult result = MessageBox.Show("ÚLTIMA PALABRA", "¿Estás seguro?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    if (EsRespuestaCorrecta())
                    {
                        MessageBox.Show($"MUY BIEN ACABAS DE GANAR {puntosPreguntaActual} PUNTOS");
                        categoria++;
                        ronda++;
                        puntosAcumulados += puntosPreguntaActual;

                        if(ronda < 6)
                            PasarASiguientePregunta();
                        else
                            MessageBox.Show("Juego Completado!");
                    }
                    else
                    {
                        MessageBox.Show("PAILAS");
                    } 
                }
            }
        }

        private void ResponderIncorrectamente()
        {

        }

        private void AbandonarJuegoVoluntariamente()
        {

        }

        private bool EstaSeleccionadaRespuesta()
        {

            if (rbOpcionA.Checked)
                return true;

            if (rbOpcionB.Checked)
                return true;

            if (rbOpcionC.Checked)
                return true;

            if (rbOpcionD.Checked)
                return true;

            return false;
        }

        private bool EsRespuestaCorrecta()
        {
            if (rbOpcionA.Checked)
                return EsCorrectaRespuestaA;

            if (rbOpcionB.Checked)
                return EsCorrectaRespuestaB;

            if (rbOpcionC.Checked)
                return EsCorrectaRespuestaC;

            if (rbOpcionD.Checked)
                return EsCorrectaRespuestaD;

            return false;
        }
    }
}
