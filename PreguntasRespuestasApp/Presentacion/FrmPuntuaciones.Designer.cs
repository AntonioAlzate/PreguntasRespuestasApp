
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.cmbFiltrar.BackColor = System.Drawing.Color.White;
            this.cmbFiltrar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltrar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbFiltrar.ForeColor = System.Drawing.Color.Black;
            this.cmbFiltrar.FormattingEnabled = true;
            this.cmbFiltrar.Location = new System.Drawing.Point(368, 48);
            this.cmbFiltrar.Name = "cmbFiltrar";
            this.cmbFiltrar.Size = new System.Drawing.Size(121, 25);
            this.cmbFiltrar.TabIndex = 0;
            this.cmbFiltrar.SelectedIndexChanged += new System.EventHandler(this.cmbFiltrar_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(161, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mostrar Puntuaciones de:";
            // 
            // dtgvPuntuacion
            // 
            this.dtgvPuntuacion.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(40)))), ((int)(((byte)(39)))));
            this.dtgvPuntuacion.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(40)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvPuntuacion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvPuntuacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvPuntuacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombre,
            this.Puntos,
            this.Ronda,
            this.causa});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvPuntuacion.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvPuntuacion.EnableHeadersVisualStyles = false;
            this.dtgvPuntuacion.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.dtgvPuntuacion.Location = new System.Drawing.Point(40, 107);
            this.dtgvPuntuacion.Name = "dtgvPuntuacion";
            this.dtgvPuntuacion.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvPuntuacion.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
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
            this.nombre.Width = 204;
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
            this.causa.ReadOnly = true;
            this.causa.Width = 230;
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnVolver.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnVolver.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnVolver.ForeColor = System.Drawing.Color.LightGray;
            this.btnVolver.Location = new System.Drawing.Point(321, 377);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(150, 40);
            this.btnVolver.TabIndex = 3;
            this.btnVolver.Text = "Menú principal";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // FrmPuntuaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.dtgvPuntuacion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbFiltrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmPuntuaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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