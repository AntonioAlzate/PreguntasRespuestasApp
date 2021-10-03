
namespace PreguntasRespuestasApp.Presentacion
{
    partial class FrmResponderPregunta
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
            this.gboxRespuestas = new System.Windows.Forms.GroupBox();
            this.rbOpcionD = new System.Windows.Forms.RadioButton();
            this.rbOpcionC = new System.Windows.Forms.RadioButton();
            this.rbOpcionB = new System.Windows.Forms.RadioButton();
            this.rbOpcionA = new System.Windows.Forms.RadioButton();
            this.lblNumeroRonda = new System.Windows.Forms.Label();
            this.lblPuntosPregunta = new System.Windows.Forms.Label();
            this.lblPuntajeActual = new System.Windows.Forms.Label();
            this.btnResponder = new System.Windows.Forms.Button();
            this.btnAbandonar = new System.Windows.Forms.Button();
            this.lblCategoriaPregunta = new System.Windows.Forms.Label();
            this.gboxRespuestas.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboxRespuestas
            // 
            this.gboxRespuestas.Controls.Add(this.rbOpcionD);
            this.gboxRespuestas.Controls.Add(this.rbOpcionC);
            this.gboxRespuestas.Controls.Add(this.rbOpcionB);
            this.gboxRespuestas.Controls.Add(this.rbOpcionA);
            this.gboxRespuestas.Location = new System.Drawing.Point(80, 114);
            this.gboxRespuestas.Name = "gboxRespuestas";
            this.gboxRespuestas.Size = new System.Drawing.Size(657, 271);
            this.gboxRespuestas.TabIndex = 1;
            this.gboxRespuestas.TabStop = false;
            this.gboxRespuestas.Text = "¿En qué país se utilizó la primera bomba atómica en un contexto de combate?";
            // 
            // rbOpcionD
            // 
            this.rbOpcionD.AutoSize = true;
            this.rbOpcionD.Location = new System.Drawing.Point(6, 214);
            this.rbOpcionD.Name = "rbOpcionD";
            this.rbOpcionD.Size = new System.Drawing.Size(53, 19);
            this.rbOpcionD.TabIndex = 0;
            this.rbOpcionD.Text = "Rusia";
            this.rbOpcionD.UseVisualStyleBackColor = true;
            // 
            // rbOpcionC
            // 
            this.rbOpcionC.AutoSize = true;
            this.rbOpcionC.Location = new System.Drawing.Point(6, 158);
            this.rbOpcionC.Name = "rbOpcionC";
            this.rbOpcionC.Size = new System.Drawing.Size(56, 19);
            this.rbOpcionC.TabIndex = 0;
            this.rbOpcionC.Text = "Japon";
            this.rbOpcionC.UseVisualStyleBackColor = true;
            // 
            // rbOpcionB
            // 
            this.rbOpcionB.AutoSize = true;
            this.rbOpcionB.Location = new System.Drawing.Point(6, 99);
            this.rbOpcionB.Name = "rbOpcionB";
            this.rbOpcionB.Size = new System.Drawing.Size(105, 19);
            this.rbOpcionB.TabIndex = 0;
            this.rbOpcionB.Text = "Estados Unidos";
            this.rbOpcionB.UseVisualStyleBackColor = true;
            // 
            // rbOpcionA
            // 
            this.rbOpcionA.AutoSize = true;
            this.rbOpcionA.Location = new System.Drawing.Point(6, 43);
            this.rbOpcionA.Name = "rbOpcionA";
            this.rbOpcionA.Size = new System.Drawing.Size(56, 19);
            this.rbOpcionA.TabIndex = 0;
            this.rbOpcionA.Text = "China";
            this.rbOpcionA.UseVisualStyleBackColor = true;
            // 
            // lblNumeroRonda
            // 
            this.lblNumeroRonda.AutoSize = true;
            this.lblNumeroRonda.Location = new System.Drawing.Point(80, 13);
            this.lblNumeroRonda.Name = "lblNumeroRonda";
            this.lblNumeroRonda.Size = new System.Drawing.Size(107, 15);
            this.lblNumeroRonda.TabIndex = 2;
            this.lblNumeroRonda.Text = "RONDA NÚMERO: ";
            // 
            // lblPuntosPregunta
            // 
            this.lblPuntosPregunta.AutoSize = true;
            this.lblPuntosPregunta.Location = new System.Drawing.Point(80, 61);
            this.lblPuntosPregunta.Name = "lblPuntosPregunta";
            this.lblPuntosPregunta.Size = new System.Drawing.Size(220, 15);
            this.lblPuntosPregunta.TabIndex = 2;
            this.lblPuntosPregunta.Text = "PUNTOS POR ACERTAR ESTA PREGUNTA:";
            // 
            // lblPuntajeActual
            // 
            this.lblPuntajeActual.AutoSize = true;
            this.lblPuntajeActual.Location = new System.Drawing.Point(581, 13);
            this.lblPuntajeActual.Name = "lblPuntajeActual";
            this.lblPuntajeActual.Size = new System.Drawing.Size(105, 15);
            this.lblPuntajeActual.TabIndex = 3;
            this.lblPuntajeActual.Text = "PUNTAJE ACTUAL:";
            // 
            // btnResponder
            // 
            this.btnResponder.Location = new System.Drawing.Point(365, 391);
            this.btnResponder.Name = "btnResponder";
            this.btnResponder.Size = new System.Drawing.Size(81, 23);
            this.btnResponder.TabIndex = 4;
            this.btnResponder.Text = "RESPONDER";
            this.btnResponder.UseVisualStyleBackColor = true;
            this.btnResponder.Click += new System.EventHandler(this.btnResponder_Click);
            // 
            // btnAbandonar
            // 
            this.btnAbandonar.Location = new System.Drawing.Point(647, 391);
            this.btnAbandonar.Name = "btnAbandonar";
            this.btnAbandonar.Size = new System.Drawing.Size(90, 23);
            this.btnAbandonar.TabIndex = 4;
            this.btnAbandonar.Text = "ABANDONAR";
            this.btnAbandonar.UseVisualStyleBackColor = true;
            this.btnAbandonar.Click += new System.EventHandler(this.btnAbandonar_Click);
            // 
            // lblCategoriaPregunta
            // 
            this.lblCategoriaPregunta.AutoSize = true;
            this.lblCategoriaPregunta.Location = new System.Drawing.Point(80, 37);
            this.lblCategoriaPregunta.Name = "lblCategoriaPregunta";
            this.lblCategoriaPregunta.Size = new System.Drawing.Size(167, 15);
            this.lblCategoriaPregunta.TabIndex = 5;
            this.lblCategoriaPregunta.Text = "CATEGORÍA DE LA PREGUNTA:";
            // 
            // FrmResponderPregunta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCategoriaPregunta);
            this.Controls.Add(this.btnAbandonar);
            this.Controls.Add(this.btnResponder);
            this.Controls.Add(this.lblPuntajeActual);
            this.Controls.Add(this.lblPuntosPregunta);
            this.Controls.Add(this.lblNumeroRonda);
            this.Controls.Add(this.gboxRespuestas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmResponderPregunta";
            this.Text = "FrmResponderPregunta";
            this.gboxRespuestas.ResumeLayout(false);
            this.gboxRespuestas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gboxRespuestas;
        private System.Windows.Forms.RadioButton rbOpcionD;
        private System.Windows.Forms.RadioButton rbOpcionC;
        private System.Windows.Forms.RadioButton rbOpcionB;
        private System.Windows.Forms.RadioButton rbOpcionA;
        private System.Windows.Forms.Label lblNumeroRonda;
        private System.Windows.Forms.Label lblPuntosPregunta;
        private System.Windows.Forms.Label lblPuntajeActual;
        private System.Windows.Forms.Button btnResponder;
        private System.Windows.Forms.Button btnAbandonar;
        private System.Windows.Forms.Label lblCategoriaPregunta;
    }
}