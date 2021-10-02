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

        public FrmConfiguracion(Form formInicio)
        {
            InitializeComponent();
            this.formInicio = formInicio;
        }

        private void btnAgregarPregunta_Click(object sender, EventArgs e)
        {
            FrmAgregarNuevaPregunta frmAgregarNuevaPregunta = new FrmAgregarNuevaPregunta();
            frmAgregarNuevaPregunta.ShowDialog();
        }

        private void btnVolverInicio_Click(object sender, EventArgs e)
        {
            formInicio.Show();
            this.Close();
        }
    }
}
