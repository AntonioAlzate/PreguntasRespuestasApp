using PreguntasRespuestasApp.Entidades;
using PreguntasRespuestasApp.Repository;
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
    public partial class FrmPuntuaciones : Form
    {
        private Form formInicio;

        JugadorRepositorio jugadorRepositorio;
        PuntajeRepositorio puntajeRepositorio;

        public FrmPuntuaciones(Form formInicio)
        {
            InitializeComponent();

            jugadorRepositorio = new JugadorRepositorio();
            puntajeRepositorio = new PuntajeRepositorio();
            this.formInicio = formInicio;

            CargarComboBox();
            ListarTodasPuntuaciones();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            formInicio.Show();
            this.Close();
        }

        private void CargarComboBox()
        {
            List<Jugador> jugadoresBd = jugadorRepositorio.ObtenerTodos();

            cmbFiltrar.Items.Add("Todos");

            if (jugadoresBd.Count > 0)
            {
                foreach (Jugador jugador in jugadoresBd)
                {
                    cmbFiltrar.Items.Add(jugador.NombreUsuario);
                }
                cmbFiltrar.SelectedIndex = 0;
            }
        }

        private void ListarTodasPuntuaciones()
        {
            List<Puntaje> puntajes = puntajeRepositorio.ObtenerTodosConJugadorRonda();

            LlenarDataGridViewPuntuaciones(puntajes);
        }

        private void LlenarDataGridViewPuntuaciones(List<Puntaje> puntajes)
        {
            dtgvPuntuacion.Rows.Clear();

            foreach (Puntaje puntaje in puntajes)
            {
                dtgvPuntuacion.Rows.Add(puntaje.Jugador.NombreUsuario, puntaje.Valor, puntaje.Ronda.Numero, puntaje.Causa);
            }
        }

        private void cmbFiltrar_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmbFiltrar.Text == "Todos")
            {
                ListarTodasPuntuaciones();
            }
            else
            {
                ListarPorJugador(cmbFiltrar.Text);
            }

        }

        private void ListarPorJugador(string nombreJugador)
        {
            int idJugador = jugadorRepositorio.ObtenerPorNombre(nombreJugador).Id;
            List<Puntaje> puntajes = puntajeRepositorio.ObtenerTodosPorNombre(idJugador);

            LlenarDataGridViewPuntuaciones(puntajes);
        }
    }
}
