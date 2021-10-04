using PreguntasRespuestasApp.Entidades;
using PreguntasRespuestasApp.Repository;
using PreguntasRespuestasApp.Utilidades;
using System;
using System.Collections.Generic;
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

        private void CargarComboBox()
        {
            try
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
            catch (Exception)
            {

                MessageBox.Show(Mensaje.ERROR_INESPERADO, Mensaje.ERROR_TITULO,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                Application.Exit();
            }

        }

        private void btnJugar_Click(object sender, EventArgs e)
        {
            if (rbUsuarioNuevo.Checked)
            {
                txtNombreUsuario.Text = Validaciones.EliminarEspaciosBlanco(txtNombreUsuario.Text);
                if (Validaciones.EsValidoContenidoTextBox(txtNombreUsuario, epIngresoUsuario) && JugadorNoExiste())
                {
                    try
                    {
                        CrearUsuarioNuevo();

                        MessageBox.Show(Mensaje.REGISTRO_JUGADOR_EXITOSO, Mensaje.REGISTRO_JUGADOR_TITULO,
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        PasarAResponderPreguntas();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show(Mensaje.REGISTRO_JUGADOR_ERROR, Mensaje.ERROR_TITULO,
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                    MessageBox.Show(Mensaje.JUGADOR_EXISTE_MAL_INGRESO_DATOS, Mensaje.CAMPO_REQUERIDO_TITULO,
                        MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else if (rbUsuarioExistente.Checked)
            {
                if (cmbUsuarios.Items.Count <= 0)
                {
                    MessageBox.Show(Mensaje.NO_EXISTEN_USUARIOS, Mensaje.SIN_USUARIOS,
                        MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    MessageBox.Show($"Bienvenido {cmbUsuarios.Text}!", Mensaje.BIENVENIDO_TITULO,
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

        private void FrmIngresoUsuario_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.frmInicio.Show();
        }
    }
}
