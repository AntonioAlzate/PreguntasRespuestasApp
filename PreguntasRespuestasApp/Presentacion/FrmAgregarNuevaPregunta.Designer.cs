
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEnunciadoPregunta = new System.Windows.Forms.TextBox();
            this.gboxRespuestas = new System.Windows.Forms.GroupBox();
            this.txtOpcionD = new System.Windows.Forms.TextBox();
            this.txtOpcionC = new System.Windows.Forms.TextBox();
            this.txtOpcionB = new System.Windows.Forms.TextBox();
            this.txtOpcionA = new System.Windows.Forms.TextBox();
            this.rbOpcionD = new System.Windows.Forms.RadioButton();
            this.rbOpcionC = new System.Windows.Forms.RadioButton();
            this.rbOpcionB = new System.Windows.Forms.RadioButton();
            this.rbOpcionA = new System.Windows.Forms.RadioButton();
            this.btnAgregarPregunta = new System.Windows.Forms.Button();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.erpNuevaPregunta = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnCancelar = new System.Windows.Forms.Button();
            this.gboxRespuestas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpNuevaPregunta)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(57, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enunciado pregunta";
            // 
            // txtEnunciadoPregunta
            // 
            this.txtEnunciadoPregunta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(40)))), ((int)(((byte)(39)))));
            this.txtEnunciadoPregunta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEnunciadoPregunta.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEnunciadoPregunta.ForeColor = System.Drawing.Color.LightGray;
            this.txtEnunciadoPregunta.Location = new System.Drawing.Point(57, 115);
            this.txtEnunciadoPregunta.Name = "txtEnunciadoPregunta";
            this.txtEnunciadoPregunta.Size = new System.Drawing.Size(667, 27);
            this.txtEnunciadoPregunta.TabIndex = 1;
            // 
            // gboxRespuestas
            // 
            this.gboxRespuestas.Controls.Add(this.txtOpcionD);
            this.gboxRespuestas.Controls.Add(this.txtOpcionC);
            this.gboxRespuestas.Controls.Add(this.txtOpcionB);
            this.gboxRespuestas.Controls.Add(this.txtOpcionA);
            this.gboxRespuestas.Controls.Add(this.rbOpcionD);
            this.gboxRespuestas.Controls.Add(this.rbOpcionC);
            this.gboxRespuestas.Controls.Add(this.rbOpcionB);
            this.gboxRespuestas.Controls.Add(this.rbOpcionA);
            this.gboxRespuestas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gboxRespuestas.ForeColor = System.Drawing.Color.DimGray;
            this.gboxRespuestas.Location = new System.Drawing.Point(57, 157);
            this.gboxRespuestas.Name = "gboxRespuestas";
            this.gboxRespuestas.Size = new System.Drawing.Size(667, 196);
            this.gboxRespuestas.TabIndex = 2;
            this.gboxRespuestas.TabStop = false;
            this.gboxRespuestas.Text = "Respuestas";
            // 
            // txtOpcionD
            // 
            this.txtOpcionD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(40)))), ((int)(((byte)(39)))));
            this.txtOpcionD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOpcionD.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtOpcionD.ForeColor = System.Drawing.Color.LightGray;
            this.txtOpcionD.Location = new System.Drawing.Point(27, 154);
            this.txtOpcionD.Name = "txtOpcionD";
            this.txtOpcionD.Size = new System.Drawing.Size(620, 23);
            this.txtOpcionD.TabIndex = 5;
            // 
            // txtOpcionC
            // 
            this.txtOpcionC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(40)))), ((int)(((byte)(39)))));
            this.txtOpcionC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOpcionC.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtOpcionC.ForeColor = System.Drawing.Color.LightGray;
            this.txtOpcionC.Location = new System.Drawing.Point(27, 111);
            this.txtOpcionC.Name = "txtOpcionC";
            this.txtOpcionC.Size = new System.Drawing.Size(620, 23);
            this.txtOpcionC.TabIndex = 4;
            // 
            // txtOpcionB
            // 
            this.txtOpcionB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(40)))), ((int)(((byte)(39)))));
            this.txtOpcionB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOpcionB.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtOpcionB.ForeColor = System.Drawing.Color.LightGray;
            this.txtOpcionB.Location = new System.Drawing.Point(27, 70);
            this.txtOpcionB.Name = "txtOpcionB";
            this.txtOpcionB.Size = new System.Drawing.Size(620, 23);
            this.txtOpcionB.TabIndex = 3;
            // 
            // txtOpcionA
            // 
            this.txtOpcionA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(40)))), ((int)(((byte)(39)))));
            this.txtOpcionA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOpcionA.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtOpcionA.ForeColor = System.Drawing.Color.LightGray;
            this.txtOpcionA.Location = new System.Drawing.Point(27, 30);
            this.txtOpcionA.Name = "txtOpcionA";
            this.txtOpcionA.Size = new System.Drawing.Size(620, 23);
            this.txtOpcionA.TabIndex = 2;
            // 
            // rbOpcionD
            // 
            this.rbOpcionD.AutoSize = true;
            this.rbOpcionD.Location = new System.Drawing.Point(6, 158);
            this.rbOpcionD.Name = "rbOpcionD";
            this.rbOpcionD.Size = new System.Drawing.Size(14, 13);
            this.rbOpcionD.TabIndex = 10;
            this.rbOpcionD.TabStop = true;
            this.rbOpcionD.UseVisualStyleBackColor = true;
            // 
            // rbOpcionC
            // 
            this.rbOpcionC.AutoSize = true;
            this.rbOpcionC.Location = new System.Drawing.Point(7, 115);
            this.rbOpcionC.Name = "rbOpcionC";
            this.rbOpcionC.Size = new System.Drawing.Size(14, 13);
            this.rbOpcionC.TabIndex = 9;
            this.rbOpcionC.TabStop = true;
            this.rbOpcionC.UseVisualStyleBackColor = true;
            // 
            // rbOpcionB
            // 
            this.rbOpcionB.AutoSize = true;
            this.rbOpcionB.Location = new System.Drawing.Point(7, 74);
            this.rbOpcionB.Name = "rbOpcionB";
            this.rbOpcionB.Size = new System.Drawing.Size(14, 13);
            this.rbOpcionB.TabIndex = 8;
            this.rbOpcionB.TabStop = true;
            this.rbOpcionB.UseVisualStyleBackColor = true;
            // 
            // rbOpcionA
            // 
            this.rbOpcionA.AutoSize = true;
            this.rbOpcionA.Location = new System.Drawing.Point(7, 34);
            this.rbOpcionA.Name = "rbOpcionA";
            this.rbOpcionA.Size = new System.Drawing.Size(14, 13);
            this.rbOpcionA.TabIndex = 7;
            this.rbOpcionA.TabStop = true;
            this.rbOpcionA.UseVisualStyleBackColor = true;
            // 
            // btnAgregarPregunta
            // 
            this.btnAgregarPregunta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnAgregarPregunta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAgregarPregunta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarPregunta.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAgregarPregunta.ForeColor = System.Drawing.Color.LightGray;
            this.btnAgregarPregunta.Location = new System.Drawing.Point(57, 359);
            this.btnAgregarPregunta.Name = "btnAgregarPregunta";
            this.btnAgregarPregunta.Size = new System.Drawing.Size(150, 30);
            this.btnAgregarPregunta.TabIndex = 6;
            this.btnAgregarPregunta.Text = "AGREGAR";
            this.btnAgregarPregunta.UseVisualStyleBackColor = true;
            this.btnAgregarPregunta.Click += new System.EventHandler(this.btnAgregarPregunta_Click);
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoria.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(154, 51);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(121, 25);
            this.cmbCategoria.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.DarkGray;
            this.label2.Location = new System.Drawing.Point(57, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Categoría";
            // 
            // erpNuevaPregunta
            // 
            this.erpNuevaPregunta.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.erpNuevaPregunta.ContainerControl = this;
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancelar.ForeColor = System.Drawing.Color.LightGray;
            this.btnCancelar.Location = new System.Drawing.Point(574, 359);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(150, 30);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FrmAgregarNuevaPregunta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbCategoria);
            this.Controls.Add(this.btnAgregarPregunta);
            this.Controls.Add(this.gboxRespuestas);
            this.Controls.Add(this.txtEnunciadoPregunta);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "FrmAgregarNuevaPregunta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAgregarNuevaPregunta";
            this.gboxRespuestas.ResumeLayout(false);
            this.gboxRespuestas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpNuevaPregunta)).EndInit();
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
        private System.Windows.Forms.ErrorProvider erpNuevaPregunta;
        private System.Windows.Forms.TextBox txtOpcionD;
        private System.Windows.Forms.TextBox txtOpcionC;
        private System.Windows.Forms.TextBox txtOpcionB;
        private System.Windows.Forms.TextBox txtOpcionA;
        private System.Windows.Forms.Button btnCancelar;
    }
}