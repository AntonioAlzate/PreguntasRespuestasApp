using PreguntasRespuestasApp.Entidades;
using PreguntasRespuestasApp.Persistencia;
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
    public partial class FrmInicio : Form
    {

        public FrmInicio()
        {
            InitializeComponent();

            InicializarBaseDatos();
        }

        private void InicializarBaseDatos()
        {
            using(DatabaseContext db = new DatabaseContext())
            {
                db.Database.EnsureCreated();
            }
        }

        private void btnIniciarJuego_Click(object sender, EventArgs e)
        {
            FrmIngresoUsuario frmIngresoUsuario = new FrmIngresoUsuario();
            frmIngresoUsuario.Show();

            this.Hide();
        }

        private void btnConfiguracion_Click(object sender, EventArgs e)
        {
            FrmConfiguracion frmConfiguracion = new FrmConfiguracion(this);
            frmConfiguracion.Show();

            this.Hide();
        }

        private void btnPuntuaciones_Click(object sender, EventArgs e)
        {
            FrmPuntuaciones frmPuntuaciones = new FrmPuntuaciones(this);
            frmPuntuaciones.Show();

            this.Hide();
        }
    }
}
