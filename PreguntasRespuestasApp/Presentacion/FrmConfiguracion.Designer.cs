﻿
namespace PreguntasRespuestasApp.Presentacion
{
    partial class FrmConfiguracion
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
            this.dtgvPreguntasExistentes = new System.Windows.Forms.DataGridView();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgregarPregunta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPreguntasExistentes)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvPreguntasExistentes
            // 
            this.dtgvPreguntasExistentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvPreguntasExistentes.Location = new System.Drawing.Point(68, 92);
            this.dtgvPreguntasExistentes.Name = "dtgvPreguntasExistentes";
            this.dtgvPreguntasExistentes.RowTemplate.Height = 25;
            this.dtgvPreguntasExistentes.Size = new System.Drawing.Size(633, 213);
            this.dtgvPreguntasExistentes.TabIndex = 0;
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(187, 42);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(121, 23);
            this.cmbCategoria.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "CATEGORÍA";
            // 
            // btnAgregarPregunta
            // 
            this.btnAgregarPregunta.Location = new System.Drawing.Point(68, 342);
            this.btnAgregarPregunta.Name = "btnAgregarPregunta";
            this.btnAgregarPregunta.Size = new System.Drawing.Size(198, 23);
            this.btnAgregarPregunta.TabIndex = 3;
            this.btnAgregarPregunta.Text = "AGREGAR NUEVA PREGUNTA";
            this.btnAgregarPregunta.UseVisualStyleBackColor = true;
            // 
            // FrmConfiguracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAgregarPregunta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbCategoria);
            this.Controls.Add(this.dtgvPreguntasExistentes);
            this.Name = "FrmConfiguracion";
            this.Text = "FrmConfiguracion";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPreguntasExistentes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvPreguntasExistentes;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAgregarPregunta;
    }
}