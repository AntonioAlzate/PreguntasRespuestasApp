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
    public partial class FrmConfiguracion : Form
    {
        private Form formInicio;
        private CategoriaRepositorio categoriaRepositorio;
        private PreguntaRepositorio preguntaRepositorio;

        public FrmConfiguracion()
        {
            InitializeComponent();

            categoriaRepositorio = new CategoriaRepositorio();
            preguntaRepositorio = new PreguntaRepositorio();

            CargarComboBox();
            ListarTodasPreguntas();
        }

        private void ListarTodasPreguntas()
        {
            List<Pregunta> preguntas = preguntaRepositorio.ObtenerTodasConCategoria();

            LlenarDataGridViewPreguntas(preguntas);
        }

        private void ListarPorCategoria(int categoria)
        {
            List<Pregunta> preguntas = preguntaRepositorio.ObtenerPorCategoria(categoria);

            LlenarDataGridViewPreguntas(preguntas);
        }

        private void LlenarDataGridViewPreguntas(List<Pregunta> preguntas)
        {
            dtgvPreguntasExistentes.Rows.Clear();

            foreach (Pregunta pregunta in preguntas)
            {
                dtgvPreguntasExistentes.Rows.Add(pregunta.Id, pregunta.Enunciado, pregunta.Categoria.NivelDificultad);
            }
        }

        private void CargarComboBox()
        {
            List<Categoria> categoriasBd = categoriaRepositorio.ObtenerTodos();

            foreach (Categoria categoria in categoriasBd)
            {
                cmbCategoria.Items.Add(categoria.NivelDificultad);
            }

            cmbCategoria.Items.Add("Todas");
            cmbCategoria.SelectedIndex = cmbCategoria.Items.Count - 1;
        }

        private void btnAgregarPregunta_Click(object sender, EventArgs e)
        {
            FrmAgregarNuevaPregunta frmAgregarNuevaPregunta = new FrmAgregarNuevaPregunta();
            frmAgregarNuevaPregunta.ShowDialog();
            ListarTodasPreguntas();
        }

        private void btnVolverInicio_Click(object sender, EventArgs e)
        {
            FrmInicio frmInicio = new FrmInicio();
            frmInicio.Show();

            this.Close();
        }

        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbCategoria.Text == "Todas")
            {
                ListarTodasPreguntas();
            }
            else
            {
                ListarPorCategoria(cmbCategoria.SelectedIndex + 1);
            }
        }
    }
}
