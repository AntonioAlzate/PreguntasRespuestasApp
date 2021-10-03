
namespace PreguntasRespuestasApp.Presentacion
{
    partial class FrmIngresoUsuario
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
            this.components = new System.ComponentModel.Container();
            this.gboxTipoUsuario = new System.Windows.Forms.GroupBox();
            this.rbUsuarioExistente = new System.Windows.Forms.RadioButton();
            this.rbUsuarioNuevo = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.cmbUsuarios = new System.Windows.Forms.ComboBox();
            this.btnJugar = new System.Windows.Forms.Button();
            this.epIngresoUsuario = new System.Windows.Forms.ErrorProvider(this.components);
            this.gboxTipoUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epIngresoUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // gboxTipoUsuario
            // 
            this.gboxTipoUsuario.Controls.Add(this.rbUsuarioExistente);
            this.gboxTipoUsuario.Controls.Add(this.rbUsuarioNuevo);
            this.gboxTipoUsuario.Location = new System.Drawing.Point(87, 21);
            this.gboxTipoUsuario.Name = "gboxTipoUsuario";
            this.gboxTipoUsuario.Size = new System.Drawing.Size(209, 53);
            this.gboxTipoUsuario.TabIndex = 0;
            this.gboxTipoUsuario.TabStop = false;
            this.gboxTipoUsuario.Text = "Tipo de usuario";
            // 
            // rbUsuarioExistente
            // 
            this.rbUsuarioExistente.AutoSize = true;
            this.rbUsuarioExistente.Location = new System.Drawing.Point(108, 22);
            this.rbUsuarioExistente.Name = "rbUsuarioExistente";
            this.rbUsuarioExistente.Size = new System.Drawing.Size(72, 19);
            this.rbUsuarioExistente.TabIndex = 1;
            this.rbUsuarioExistente.TabStop = true;
            this.rbUsuarioExistente.Text = "Existente";
            this.rbUsuarioExistente.UseVisualStyleBackColor = true;
            this.rbUsuarioExistente.CheckedChanged += new System.EventHandler(this.rbUsuarioExistente_CheckedChanged);
            // 
            // rbUsuarioNuevo
            // 
            this.rbUsuarioNuevo.AutoSize = true;
            this.rbUsuarioNuevo.Location = new System.Drawing.Point(7, 23);
            this.rbUsuarioNuevo.Name = "rbUsuarioNuevo";
            this.rbUsuarioNuevo.Size = new System.Drawing.Size(60, 19);
            this.rbUsuarioNuevo.TabIndex = 0;
            this.rbUsuarioNuevo.TabStop = true;
            this.rbUsuarioNuevo.Text = "Nuevo";
            this.rbUsuarioNuevo.UseVisualStyleBackColor = true;
            this.rbUsuarioNuevo.CheckedChanged += new System.EventHandler(this.rbUsuarioNuevo_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre:";
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Location = new System.Drawing.Point(145, 81);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(121, 23);
            this.txtNombreUsuario.TabIndex = 2;
            // 
            // cmbUsuarios
            // 
            this.cmbUsuarios.FormattingEnabled = true;
            this.cmbUsuarios.Location = new System.Drawing.Point(145, 119);
            this.cmbUsuarios.Name = "cmbUsuarios";
            this.cmbUsuarios.Size = new System.Drawing.Size(121, 23);
            this.cmbUsuarios.TabIndex = 3;
            // 
            // btnJugar
            // 
            this.btnJugar.Location = new System.Drawing.Point(145, 159);
            this.btnJugar.Name = "btnJugar";
            this.btnJugar.Size = new System.Drawing.Size(75, 23);
            this.btnJugar.TabIndex = 4;
            this.btnJugar.Text = "Jugar";
            this.btnJugar.UseVisualStyleBackColor = true;
            this.btnJugar.Click += new System.EventHandler(this.btnJugar_Click);
            // 
            // epIngresoUsuario
            // 
            this.epIngresoUsuario.ContainerControl = this;
            // 
            // FrmIngresoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 204);
            this.Controls.Add(this.btnJugar);
            this.Controls.Add(this.cmbUsuarios);
            this.Controls.Add(this.txtNombreUsuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gboxTipoUsuario);
            this.Name = "FrmIngresoUsuario";
            this.Text = "FrmIngresoUsuario";
            this.gboxTipoUsuario.ResumeLayout(false);
            this.gboxTipoUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epIngresoUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gboxTipoUsuario;
        private System.Windows.Forms.RadioButton rbUsuarioExistente;
        private System.Windows.Forms.RadioButton rbUsuarioNuevo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.ComboBox cmbUsuarios;
        private System.Windows.Forms.Button btnJugar;
        private System.Windows.Forms.ErrorProvider epIngresoUsuario;
    }
}