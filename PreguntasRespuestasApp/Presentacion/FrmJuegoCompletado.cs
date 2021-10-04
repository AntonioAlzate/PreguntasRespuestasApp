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
    public partial class FrmJuegoCompletado : Form
    {

        private static string FELICITACIONES = "FELICIDADES! ";
        private static string PUNTOS_ALCANZADOS = "TU PUNTUACIÓN FINAL SON: ";

        public FrmJuegoCompletado(string nombreJugador, string puntos)
        {
            InitializeComponent();

            lblFelicitaciones.Text = Mensaje.FELICITACIONES + nombreJugador;
            lblPuntuacion.Text = Mensaje.PUNTOS_ALCANZADOS + puntos + " PUNTOS";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
