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

        public FrmPuntuaciones(Form formInicio)
        {
            InitializeComponent();
            this.formInicio = formInicio;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            formInicio.Show();
            this.Close();
        }
    }
}
