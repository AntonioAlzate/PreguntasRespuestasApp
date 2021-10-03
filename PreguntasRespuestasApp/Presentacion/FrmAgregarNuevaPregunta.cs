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
    public partial class FrmAgregarNuevaPregunta : Form
    {
        CategoriaRepositorio categoriaRepositorio;
        PreguntaRepositorio preguntaRepositorio;
        RespuestaRepositorio respuestaRepositorio;

        public FrmAgregarNuevaPregunta()
        {
            InitializeComponent();

            categoriaRepositorio = new CategoriaRepositorio();
            preguntaRepositorio = new PreguntaRepositorio();
            respuestaRepositorio = new RespuestaRepositorio();
            CargarComboBox();
        }

        private void CargarComboBox()
        {
            List<Categoria> categoriasBd = categoriaRepositorio.ObtenerTodos();

            foreach (Categoria categoria in categoriasBd)
            {
                cmbCategoria.Items.Add(categoria.NivelDificultad);
            }

            cmbCategoria.SelectedIndex = 0;
        }

        private void btnAgregarPregunta_Click(object sender, EventArgs e)
        {
            SanitizarDatos();

            if (EsValidoFormulario())
            {
                CrearPreguntaConRespuestas();
                this.Close();
            }
            else
            {
                MessageBox.Show("No se puede Crear");
            }
        }

        private void CrearPreguntaConRespuestas()
        {
            string categoriaSeleccionada = cmbCategoria.SelectedItem.ToString();
            Categoria categoriaBD = categoriaRepositorio.ObtenerPorNivelDificultad(categoriaSeleccionada);

            string enunciadoPregunta = txtEnunciadoPregunta.Text;

            if (categoriaBD == null)
            {
                MessageBox.Show("Se presento un error interno al intentar crear la pregunta");
            }

            Pregunta pregunta = new Pregunta()
            {
                CategoriaId = categoriaBD.Id,
                Enunciado = enunciadoPregunta
            };

            preguntaRepositorio.Insertar(pregunta);
            Pregunta preguntaInsertada = preguntaRepositorio.ObtenerUltima();

            List<Respuesta> respuestas = CrearRespuestasParaIngresarBD(preguntaInsertada.Id);
            respuestaRepositorio.Insertar(respuestas);

            MessageBox.Show("Pregunta insertada correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private List<Respuesta> CrearRespuestasParaIngresarBD(int preguntaId)
        {
            string contenidoRA = txtOpcionA.Text;
            string contenidoRB = txtOpcionB.Text;
            string contenidoRC = txtOpcionC.Text;
            string contenidoRD = txtOpcionD.Text;

            bool esCorrectaA = rbOpcionA.Checked ? true : false;
            bool esCorrectaB = rbOpcionB.Checked ? true : false;
            bool esCorrectaC = rbOpcionC.Checked ? true : false;
            bool esCorrectaD = rbOpcionD.Checked ? true : false;

            List<Respuesta> respuestas = new List<Respuesta>()
            {
                new Respuesta()
                {
                    PreguntaId = preguntaId,
                    Contenido = contenidoRA,
                    EsCorrecta = esCorrectaA
                },
                new Respuesta()
                {
                    PreguntaId = preguntaId,
                    Contenido = contenidoRB,
                    EsCorrecta = esCorrectaB
                },
                new Respuesta()
                {
                    PreguntaId = preguntaId,
                    Contenido = contenidoRC,
                    EsCorrecta = esCorrectaC
                },
                new Respuesta()
                {
                    PreguntaId = preguntaId,
                    Contenido = contenidoRD,
                    EsCorrecta = esCorrectaD
                }
            };

            return respuestas;
        }

        private void SanitizarDatos()
        {
            txtEnunciadoPregunta.Text = Validaciones.EliminarEspaciosBlanco(txtEnunciadoPregunta.Text);
            txtOpcionA.Text = Validaciones.EliminarEspaciosBlanco(txtOpcionA.Text);
            txtOpcionB.Text = Validaciones.EliminarEspaciosBlanco(txtOpcionB.Text);
            txtOpcionC.Text = Validaciones.EliminarEspaciosBlanco(txtOpcionC.Text);
            txtOpcionD.Text = Validaciones.EliminarEspaciosBlanco(txtOpcionD.Text);
        }

        private bool EsValidoFormulario()
        {
            bool esValido = true;

            if (!EstaOpcionSeleccionada())
            {
                MessageBox.Show("Recuerde marcar la opción correcta para la pregunta");
                esValido = false;
            }

            if (!Validaciones.TieneElementosComboBox(cmbCategoria))
                esValido = false;

            if (!Validaciones.EsValidoContenidoTextBox(txtEnunciadoPregunta, erpNuevaPregunta))
                esValido = false;

            if (!Validaciones.EsValidoContenidoTextBox(txtOpcionA, erpNuevaPregunta))
                esValido = false;

            if (!Validaciones.EsValidoContenidoTextBox(txtOpcionB, erpNuevaPregunta))
                esValido = false;

            if (!Validaciones.EsValidoContenidoTextBox(txtOpcionC, erpNuevaPregunta))
                esValido = false;

            if (!Validaciones.EsValidoContenidoTextBox(txtOpcionD, erpNuevaPregunta))
                esValido = false;

            return esValido;
        }

        private bool EstaOpcionSeleccionada()
        {
            if (!Validaciones.RadioButtonSeleccionado(rbOpcionA) && !Validaciones.RadioButtonSeleccionado(rbOpcionB)
                && !Validaciones.RadioButtonSeleccionado(rbOpcionC) && !Validaciones.RadioButtonSeleccionado(rbOpcionD))
            {
                return false;
            }

            return true;
        }

    }
}
