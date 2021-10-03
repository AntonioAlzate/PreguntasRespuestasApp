﻿
namespace PreguntasRespuestasApp.Presentacion
{
    partial class FrmPuntuaciones
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
            this.cmbFiltrar = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgvPuntuacion = new System.Windows.Forms.DataGridView();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Puntos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ronda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.causa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPuntuacion)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbFiltrar
            // 
            this.cmbFiltrar.FormattingEnabled = true;
            this.cmbFiltrar.Location = new System.Drawing.Point(368, 48);
            this.cmbFiltrar.Name = "cmbFiltrar";
            this.cmbFiltrar.Size = new System.Drawing.Size(121, 23);
            this.cmbFiltrar.TabIndex = 0;
            this.cmbFiltrar.SelectedIndexChanged += new System.EventHandler(this.cmbFiltrar_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(220, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mostrar Puntuaciones de:";
            // 
            // dtgvPuntuacion
            // 
            this.dtgvPuntuacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvPuntuacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombre,
            this.Puntos,
            this.Ronda,
            this.causa});
            this.dtgvPuntuacion.Location = new System.Drawing.Point(40, 107);
            this.dtgvPuntuacion.Name = "dtgvPuntuacion";
            this.dtgvPuntuacion.RowTemplate.Height = 25;
            this.dtgvPuntuacion.Size = new System.Drawing.Size(717, 264);
            this.dtgvPuntuacion.TabIndex = 2;
            // 
            // nombre
            // 
            this.nombre.FillWeight = 369.5432F;
            this.nombre.HeaderText = "JUGADOR";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 200;
            // 
            // Puntos
            // 
            this.Puntos.FillWeight = 5.886964F;
            this.Puntos.HeaderText = "PUNTUACIÓN";
            this.Puntos.Name = "Puntos";
            this.Puntos.ReadOnly = true;
            this.Puntos.Width = 120;
            // 
            // Ronda
            // 
            this.Ronda.FillWeight = 24.52185F;
            this.Ronda.HeaderText = "RONDA ALCANZADA";
            this.Ronda.Name = "Ronda";
            this.Ronda.ReadOnly = true;
            this.Ronda.Width = 120;
            // 
            // causa
            // 
            this.causa.FillWeight = 0.04803598F;
            this.causa.HeaderText = "CAUSA FIN JUEGO";
            this.causa.Name = "causa";
            this.causa.Width = 250;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(347, 404);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(121, 23);
            this.btnVolver.TabIndex = 3;
            this.btnVolver.Text = "Volver Inicio";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // FrmPuntuaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.dtgvPuntuacion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbFiltrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmPuntuaciones";
            this.Text = "FrmPuntuaciones";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPuntuacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbFiltrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgvPuntuacion;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Puntos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ronda;
        private System.Windows.Forms.DataGridViewTextBoxColumn causa;
    }
}