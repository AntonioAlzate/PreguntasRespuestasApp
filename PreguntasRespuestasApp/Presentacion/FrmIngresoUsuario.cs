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
        public FrmIngresoUsuario()
        {
            InitializeComponent();
        }

        private void btnJugar_Click(object sender, EventArgs e)
        {
            FrmResponderPregunta frmResponderPregunta = new FrmResponderPregunta();
            frmResponderPregunta.Show();

            this.Close();
        }
    }
}
