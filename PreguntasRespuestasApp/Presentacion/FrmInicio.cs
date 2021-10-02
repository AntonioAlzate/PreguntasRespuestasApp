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
        private PreguntaRepository preguntaRepository;

        public FrmInicio()
        {
            InitializeComponent();
            preguntaRepository = new PreguntaRepository();
        }

        private void btnIniciarJuego_Click(object sender, EventArgs e)
        {
            Pregunta pregunta = new Pregunta()
            {
                Enunciado = "¿Cuanto es 2+5?",
                CategoriaId = 1
            };

            preguntaRepository.Insertar(pregunta);
        }
    }
}
