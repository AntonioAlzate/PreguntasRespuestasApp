
namespace PreguntasRespuestasApp.Presentacion
{
    partial class FrmJuegoCompletado
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblFelicitaciones = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblFelicitaciones
            // 
            this.lblFelicitaciones.AutoSize = true;
            this.lblFelicitaciones.Location = new System.Drawing.Point(295, 59);
            this.lblFelicitaciones.Name = "lblFelicitaciones";
            this.lblFelicitaciones.Size = new System.Drawing.Size(219, 15);
            this.lblFelicitaciones.TabIndex = 0;
            this.lblFelicitaciones.Text = "FELICIDADES {NOMBRE DEL JUEGADOR}";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(348, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Resumen de partida";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(348, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Preguntas acertadas 5/5";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(348, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Puntuación final: {PUNTOS}";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(126, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(575, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Recuerda consultar la tabla de posiciones para ver tu lugar en la tabla o ver el " +
    "resumen de todas tus partidas!";
            // 
            // FrmJuegoCompletado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblFelicitaciones);
            this.Name = "FrmJuegoCompletado";
            this.Text = "FrmJuegoCompletado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFelicitaciones;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}