using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PreguntasRespuestasApp.Utilidades
{
    public static class Validaciones
    {
        private static string REQUERIDO = "Campo Requerido";


        public static bool TieneContenido(string texto)
        {
            if (string.IsNullOrEmpty(texto))
                return false;

            return true;
        }

        public static string EliminarEspaciosBlanco(string texto)
        {
            return texto.Trim();
        }

        public static bool RadioButtonSeleccionado(RadioButton rb)
        {
            if (rb.Checked == true)
                return true;
            else
                return false;
        }

        public static bool EsValidoContenidoTextBox(TextBox txt, ErrorProvider eProvider)
        {
            if (!Validaciones.TieneContenido(txt.Text))
            {
                EnviarError(eProvider, enviar: true, txt, REQUERIDO);
                return false;
            }
            else
            {
                EnviarError(eProvider, enviar: false, txt, REQUERIDO);
                return true;

            }
        }

        public static void EnviarError(ErrorProvider eProvider, bool enviar, Control ctrl, string mensaje)
        {
            if (enviar)
            {
                eProvider.SetError(ctrl, mensaje);
            }
            else
            {
                eProvider.SetError(ctrl, null);
            }
        }

        public static bool TieneElementosComboBox(ComboBox cmBox)
        {
            if (cmBox.Items.Count == 0)
                return false;
            else
                return true;
        }
    }
}
