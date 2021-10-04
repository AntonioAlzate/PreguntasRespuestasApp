using PreguntasRespuestasApp.Persistencia;
using System;

using System.Windows.Forms;

namespace PreguntasRespuestasApp.Presentacion
{
    public partial class FrmInicio : Form
    {

        public FrmInicio()
        {
            InitializeComponent();

            GarantizarExistenciaBaseDatos();
        }

        private void GarantizarExistenciaBaseDatos()
        {
            using(DatabaseContext db = new DatabaseContext())
            {
                db.Database.EnsureCreated();
            }
        }

        private void btnIniciarJuego_Click(object sender, EventArgs e)
        {
            Program.frmInicio.Hide();

            FrmIngresoUsuario frmIngresoUsuario = new FrmIngresoUsuario();
            frmIngresoUsuario.ShowDialog();

        }

        private void btnConfiguracion_Click(object sender, EventArgs e)
        {
            Program.frmInicio.Hide();

            FrmConfiguracion frmConfiguracion = new FrmConfiguracion();
            frmConfiguracion.ShowDialog();

            Program.frmInicio.Show();
        }

        private void btnPuntuaciones_Click(object sender, EventArgs e)
        {
            Program.frmInicio.Hide();

            FrmPuntuaciones frmPuntuaciones = new FrmPuntuaciones(this);
            frmPuntuaciones.ShowDialog();

            Program.frmInicio.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
