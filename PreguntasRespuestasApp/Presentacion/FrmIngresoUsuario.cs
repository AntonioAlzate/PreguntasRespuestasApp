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
    public partial class FrmIngresoUsuario : Form
    {
        private JugadorRepositorio jugadorRepositorio;
        private string nombreUsuario;

        public FrmIngresoUsuario()
        {
            InitializeComponent();
            jugadorRepositorio = new JugadorRepositorio();

            CargarComboBox();
        }

        private void btnJugar_Click(object sender, EventArgs e)
        {

            if (rbUsuarioNuevo.Checked)
            {
                txtNombreUsuario.Text = Validaciones.EliminarEspaciosBlanco(txtNombreUsuario.Text);
                if (Validaciones.EsValidoContenidoTextBox(txtNombreUsuario, epIngresoUsuario) && JugadorNoExiste())
                {
                    CrearUsuarioNuevo();

                    MessageBox.Show("Se ha registrado exitosamente en nuevo jugador", "Ingresado", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    PasarAResponderPreguntas();
                }
                else
                    MessageBox.Show("El nombre de usuario ya existe en el sistema o el campo nombre se encuentra " +
                        "vacío por favor verificar antes de intentar iniciar la partida.",
                        "Requerido", MessageBoxButtons.OK,
                        MessageBoxIcon.Stop);
            }
            else if (rbUsuarioExistente.Checked)
            {
                if(cmbUsuarios.Items.Count <= 0)
                {
                    MessageBox.Show("No existen usuarios en el sistema por favor ingresarlo seleccionando \"Nuevo\"" +
                        " y agregando su nombre", "Sin Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    MessageBox.Show($"Bienvenido {cmbUsuarios.Text}!", "Bienvenido",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    nombreUsuario = cmbUsuarios.Text;

                    PasarAResponderPreguntas();
                }
            }
        }

        private void PasarAResponderPreguntas()
        {
            this.Hide();

            FrmResponderPregunta frmResponderPregunta = new FrmResponderPregunta(nombreUsuario);
            frmResponderPregunta.ShowDialog();

            this.Close();
        }

        private void CrearUsuarioNuevo()
        {
            string nombre = txtNombreUsuario.Text;

            Jugador jugador = new Jugador() { NombreUsuario = nombre };

            jugadorRepositorio.Insertar(jugador);

            nombreUsuario = nombre;
        }

        private bool JugadorNoExiste()
        {
            string nombre = txtNombreUsuario.Text;
            
            bool existe = jugadorRepositorio.ExistenciaPorNombre(nombre);

            if (!existe)
                return true;
            else
                return false;
        }

        private void rbUsuarioNuevo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbUsuarioNuevo.Checked)
                ActivarControlesBasadoEnUsuarioNuevo(esNuevo: true);
        }

        private void rbUsuarioExistente_CheckedChanged(object sender, EventArgs e)
        {
            if (rbUsuarioExistente.Checked)
                ActivarControlesBasadoEnUsuarioNuevo(esNuevo: false);
        }

        private void ActivarControlesBasadoEnUsuarioNuevo(bool esNuevo)
        {
            txtNombreUsuario.Enabled = esNuevo;
            cmbUsuarios.Enabled = !esNuevo;
        }

        private void CargarComboBox()
        {
            List<Jugador> jugadoresBd = jugadorRepositorio.ObtenerTodos();

            if (jugadoresBd.Count > 0)
            {
                foreach (Jugador jugador in jugadoresBd)
                {
                    cmbUsuarios.Items.Add(jugador.NombreUsuario);
                } 

                cmbUsuarios.SelectedIndex = 0;
            }

        }

        private void FrmIngresoUsuario_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.frmInicio.Show();
        }
    }
}
