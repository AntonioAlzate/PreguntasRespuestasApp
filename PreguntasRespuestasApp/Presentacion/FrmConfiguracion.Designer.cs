
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
            this.idPregunta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enunciadoPregunta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoriaPregunta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgregarPregunta = new System.Windows.Forms.Button();
            this.btnVolverInicio = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPreguntasExistentes)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvPreguntasExistentes
            // 
            this.dtgvPreguntasExistentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvPreguntasExistentes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPregunta,
            this.enunciadoPregunta,
            this.categoriaPregunta});
            this.dtgvPreguntasExistentes.Location = new System.Drawing.Point(68, 92);
            this.dtgvPreguntasExistentes.Name = "dtgvPreguntasExistentes";
            this.dtgvPreguntasExistentes.RowTemplate.Height = 25;
            this.dtgvPreguntasExistentes.Size = new System.Drawing.Size(633, 213);
            this.dtgvPreguntasExistentes.TabIndex = 0;
            // 
            // idPregunta
            // 
            this.idPregunta.FillWeight = 2.73042F;
            this.idPregunta.HeaderText = "ID";
            this.idPregunta.Name = "idPregunta";
            this.idPregunta.Width = 50;
            // 
            // enunciadoPregunta
            // 
            this.enunciadoPregunta.FillWeight = 284.7716F;
            this.enunciadoPregunta.HeaderText = "Enunciado";
            this.enunciadoPregunta.Name = "enunciadoPregunta";
            this.enunciadoPregunta.Width = 400;
            // 
            // categoriaPregunta
            // 
            this.categoriaPregunta.FillWeight = 12.498F;
            this.categoriaPregunta.HeaderText = "Categoría";
            this.categoriaPregunta.Name = "categoriaPregunta";
            this.categoriaPregunta.Width = 150;
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(187, 42);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(121, 23);
            this.cmbCategoria.TabIndex = 1;
            this.cmbCategoria.SelectedIndexChanged += new System.EventHandler(this.cmbCategoria_SelectedIndexChanged);
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
            this.btnAgregarPregunta.Click += new System.EventHandler(this.btnAgregarPregunta_Click);
            // 
            // btnVolverInicio
            // 
            this.btnVolverInicio.Location = new System.Drawing.Point(390, 400);
            this.btnVolverInicio.Name = "btnVolverInicio";
            this.btnVolverInicio.Size = new System.Drawing.Size(75, 23);
            this.btnVolverInicio.TabIndex = 4;
            this.btnVolverInicio.Text = "Inicio";
            this.btnVolverInicio.UseVisualStyleBackColor = true;
            this.btnVolverInicio.Click += new System.EventHandler(this.btnVolverInicio_Click);
            // 
            // FrmConfiguracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVolverInicio);
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
        private System.Windows.Forms.Button btnVolverInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPregunta;
        private System.Windows.Forms.DataGridViewTextBoxColumn enunciadoPregunta;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoriaPregunta;
    }
}