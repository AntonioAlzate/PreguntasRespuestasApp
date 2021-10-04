
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.dtgvPreguntasExistentes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(40)))), ((int)(((byte)(39)))));
            this.dtgvPreguntasExistentes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvPreguntasExistentes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(40)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvPreguntasExistentes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvPreguntasExistentes.ColumnHeadersHeight = 30;
            this.dtgvPreguntasExistentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgvPreguntasExistentes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPregunta,
            this.enunciadoPregunta,
            this.categoriaPregunta});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvPreguntasExistentes.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvPreguntasExistentes.EnableHeadersVisualStyles = false;
            this.dtgvPreguntasExistentes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.dtgvPreguntasExistentes.Location = new System.Drawing.Point(68, 92);
            this.dtgvPreguntasExistentes.Name = "dtgvPreguntasExistentes";
            this.dtgvPreguntasExistentes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvPreguntasExistentes.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvPreguntasExistentes.RowTemplate.Height = 25;
            this.dtgvPreguntasExistentes.Size = new System.Drawing.Size(633, 213);
            this.dtgvPreguntasExistentes.TabIndex = 0;
            // 
            // idPregunta
            // 
            this.idPregunta.FillWeight = 2.73042F;
            this.idPregunta.HeaderText = "ID";
            this.idPregunta.Name = "idPregunta";
            this.idPregunta.ReadOnly = true;
            this.idPregunta.Width = 50;
            // 
            // enunciadoPregunta
            // 
            this.enunciadoPregunta.FillWeight = 284.7716F;
            this.enunciadoPregunta.HeaderText = "Enunciado";
            this.enunciadoPregunta.Name = "enunciadoPregunta";
            this.enunciadoPregunta.ReadOnly = true;
            this.enunciadoPregunta.Width = 400;
            // 
            // categoriaPregunta
            // 
            this.categoriaPregunta.FillWeight = 12.498F;
            this.categoriaPregunta.HeaderText = "Categoría";
            this.categoriaPregunta.Name = "categoriaPregunta";
            this.categoriaPregunta.ReadOnly = true;
            this.categoriaPregunta.Width = 150;
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoria.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbCategoria.ForeColor = System.Drawing.Color.Black;
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(187, 42);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(121, 25);
            this.cmbCategoria.TabIndex = 1;
            this.cmbCategoria.SelectedIndexChanged += new System.EventHandler(this.cmbCategoria_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(72, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "CATEGORÍA";
            // 
            // btnAgregarPregunta
            // 
            this.btnAgregarPregunta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnAgregarPregunta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnAgregarPregunta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAgregarPregunta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarPregunta.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAgregarPregunta.ForeColor = System.Drawing.Color.LightGray;
            this.btnAgregarPregunta.Location = new System.Drawing.Point(68, 321);
            this.btnAgregarPregunta.Name = "btnAgregarPregunta";
            this.btnAgregarPregunta.Size = new System.Drawing.Size(290, 30);
            this.btnAgregarPregunta.TabIndex = 3;
            this.btnAgregarPregunta.Text = "AGREGAR NUEVA PREGUNTA";
            this.btnAgregarPregunta.UseVisualStyleBackColor = false;
            this.btnAgregarPregunta.Click += new System.EventHandler(this.btnAgregarPregunta_Click);
            // 
            // btnVolverInicio
            // 
            this.btnVolverInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnVolverInicio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnVolverInicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnVolverInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolverInicio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnVolverInicio.ForeColor = System.Drawing.Color.LightGray;
            this.btnVolverInicio.Location = new System.Drawing.Point(624, 398);
            this.btnVolverInicio.Name = "btnVolverInicio";
            this.btnVolverInicio.Size = new System.Drawing.Size(160, 40);
            this.btnVolverInicio.TabIndex = 4;
            this.btnVolverInicio.Text = "Menú principal";
            this.btnVolverInicio.UseVisualStyleBackColor = false;
            this.btnVolverInicio.Click += new System.EventHandler(this.btnVolverInicio_Click);
            // 
            // FrmConfiguracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVolverInicio);
            this.Controls.Add(this.btnAgregarPregunta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbCategoria);
            this.Controls.Add(this.dtgvPreguntasExistentes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "FrmConfiguracion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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