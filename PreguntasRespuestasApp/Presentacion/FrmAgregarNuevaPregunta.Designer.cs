
namespace PreguntasRespuestasApp.Presentacion
{
    partial class FrmAgregarNuevaPregunta
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtEnunciadoPregunta = new System.Windows.Forms.TextBox();
            this.gboxRespuestas = new System.Windows.Forms.GroupBox();
            this.rbOpcionA = new System.Windows.Forms.RadioButton();
            this.rbOpcionB = new System.Windows.Forms.RadioButton();
            this.rbOpcionC = new System.Windows.Forms.RadioButton();
            this.rbOpcionD = new System.Windows.Forms.RadioButton();
            this.btnAgregarPregunta = new System.Windows.Forms.Button();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gboxRespuestas.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enunciado pregunta";
            // 
            // txtEnunciadoPregunta
            // 
            this.txtEnunciadoPregunta.Location = new System.Drawing.Point(57, 110);
            this.txtEnunciadoPregunta.Name = "txtEnunciadoPregunta";
            this.txtEnunciadoPregunta.Size = new System.Drawing.Size(667, 23);
            this.txtEnunciadoPregunta.TabIndex = 1;
            // 
            // gboxRespuestas
            // 
            this.gboxRespuestas.Controls.Add(this.rbOpcionD);
            this.gboxRespuestas.Controls.Add(this.rbOpcionC);
            this.gboxRespuestas.Controls.Add(this.rbOpcionB);
            this.gboxRespuestas.Controls.Add(this.rbOpcionA);
            this.gboxRespuestas.Location = new System.Drawing.Point(57, 157);
            this.gboxRespuestas.Name = "gboxRespuestas";
            this.gboxRespuestas.Size = new System.Drawing.Size(667, 196);
            this.gboxRespuestas.TabIndex = 2;
            this.gboxRespuestas.TabStop = false;
            this.gboxRespuestas.Text = "Respuestas";
            // 
            // rbOpcionA
            // 
            this.rbOpcionA.AutoSize = true;
            this.rbOpcionA.Location = new System.Drawing.Point(7, 34);
            this.rbOpcionA.Name = "rbOpcionA";
            this.rbOpcionA.Size = new System.Drawing.Size(79, 19);
            this.rbOpcionA.TabIndex = 0;
            this.rbOpcionA.TabStop = true;
            this.rbOpcionA.Text = "OPCIÓN 1";
            this.rbOpcionA.UseVisualStyleBackColor = true;
            // 
            // rbOpcionB
            // 
            this.rbOpcionB.AutoSize = true;
            this.rbOpcionB.Location = new System.Drawing.Point(7, 74);
            this.rbOpcionB.Name = "rbOpcionB";
            this.rbOpcionB.Size = new System.Drawing.Size(79, 19);
            this.rbOpcionB.TabIndex = 0;
            this.rbOpcionB.TabStop = true;
            this.rbOpcionB.Text = "OPCIÓN 2";
            this.rbOpcionB.UseVisualStyleBackColor = true;
            // 
            // rbOpcionC
            // 
            this.rbOpcionC.AutoSize = true;
            this.rbOpcionC.Location = new System.Drawing.Point(7, 115);
            this.rbOpcionC.Name = "rbOpcionC";
            this.rbOpcionC.Size = new System.Drawing.Size(79, 19);
            this.rbOpcionC.TabIndex = 0;
            this.rbOpcionC.TabStop = true;
            this.rbOpcionC.Text = "OPCIÓN 3";
            this.rbOpcionC.UseVisualStyleBackColor = true;
            // 
            // rbOpcionD
            // 
            this.rbOpcionD.AutoSize = true;
            this.rbOpcionD.Location = new System.Drawing.Point(6, 158);
            this.rbOpcionD.Name = "rbOpcionD";
            this.rbOpcionD.Size = new System.Drawing.Size(79, 19);
            this.rbOpcionD.TabIndex = 0;
            this.rbOpcionD.TabStop = true;
            this.rbOpcionD.Text = "OPCIÓN 4";
            this.rbOpcionD.UseVisualStyleBackColor = true;
            // 
            // btnAgregarPregunta
            // 
            this.btnAgregarPregunta.Location = new System.Drawing.Point(344, 375);
            this.btnAgregarPregunta.Name = "btnAgregarPregunta";
            this.btnAgregarPregunta.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarPregunta.TabIndex = 3;
            this.btnAgregarPregunta.Text = "AGREGAR";
            this.btnAgregarPregunta.UseVisualStyleBackColor = true;
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(121, 51);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(121, 23);
            this.cmbCategoria.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Categoría";
            // 
            // FrmAgregarNuevaPregunta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbCategoria);
            this.Controls.Add(this.btnAgregarPregunta);
            this.Controls.Add(this.gboxRespuestas);
            this.Controls.Add(this.txtEnunciadoPregunta);
            this.Controls.Add(this.label1);
            this.Name = "FrmAgregarNuevaPregunta";
            this.Text = "FrmAgregarNuevaPregunta";
            this.gboxRespuestas.ResumeLayout(false);
            this.gboxRespuestas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEnunciadoPregunta;
        private System.Windows.Forms.GroupBox gboxRespuestas;
        private System.Windows.Forms.RadioButton rbOpcionD;
        private System.Windows.Forms.RadioButton rbOpcionC;
        private System.Windows.Forms.RadioButton rbOpcionB;
        private System.Windows.Forms.RadioButton rbOpcionA;
        private System.Windows.Forms.Button btnAgregarPregunta;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.Label label2;
    }
}