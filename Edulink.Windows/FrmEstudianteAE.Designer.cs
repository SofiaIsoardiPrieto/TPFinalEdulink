namespace Edulink.Windows
{
    partial class FrmEstudianteAE
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAceptar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbCorrelativa = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tbNombres = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbApellidos = new System.Windows.Forms.TextBox();
            this.tbDireccion = new System.Windows.Forms.TextBox();
            this.rbLibre = new System.Windows.Forms.RadioButton();
            this.rbCorrelativa = new System.Windows.Forms.RadioButton();
            this.listBoxCorrelativas = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(12)))), ((int)(((byte)(166)))));
            this.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAceptar.Location = new System.Drawing.Point(69, 350);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(83, 33);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAceptar.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Myanmar Text", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 43);
            this.label3.TabIndex = 6;
            this.label3.Text = "Materia";
            // 
            // cbCorrelativa
            // 
            this.cbCorrelativa.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCorrelativa.FormattingEnabled = true;
            this.cbCorrelativa.Location = new System.Drawing.Point(20, 178);
            this.cbCorrelativa.Name = "cbCorrelativa";
            this.cbCorrelativa.Size = new System.Drawing.Size(192, 29);
            this.cbCorrelativa.TabIndex = 7;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(12)))), ((int)(((byte)(166)))));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancel.Location = new System.Drawing.Point(196, 350);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(83, 33);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // tbNombres
            // 
            this.tbNombres.Location = new System.Drawing.Point(90, 54);
            this.tbNombres.Name = "tbNombres";
            this.tbNombres.Size = new System.Drawing.Size(250, 20);
            this.tbNombres.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 23);
            this.label2.TabIndex = 12;
            this.label2.Text = "Nombres:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 23);
            this.label4.TabIndex = 13;
            this.label4.Text = "Año de la carrera:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(195, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 23);
            this.label5.TabIndex = 14;
            this.label5.Text = "Cuatrimestre:";
            // 
            // tbApellidos
            // 
            this.tbApellidos.Location = new System.Drawing.Point(139, 94);
            this.tbApellidos.Name = "tbApellidos";
            this.tbApellidos.Size = new System.Drawing.Size(50, 20);
            this.tbApellidos.TabIndex = 21;
            // 
            // tbDireccion
            // 
            this.tbDireccion.Location = new System.Drawing.Point(288, 93);
            this.tbDireccion.Name = "tbDireccion";
            this.tbDireccion.Size = new System.Drawing.Size(50, 20);
            this.tbDireccion.TabIndex = 26;
            // 
            // rbLibre
            // 
            this.rbLibre.AutoSize = true;
            this.rbLibre.Location = new System.Drawing.Point(20, 125);
            this.rbLibre.Name = "rbLibre";
            this.rbLibre.Size = new System.Drawing.Size(48, 17);
            this.rbLibre.TabIndex = 27;
            this.rbLibre.TabStop = true;
            this.rbLibre.Text = "Libre";
            this.rbLibre.UseVisualStyleBackColor = true;
            // 
            // rbCorrelativa
            // 
            this.rbCorrelativa.AutoSize = true;
            this.rbCorrelativa.Location = new System.Drawing.Point(20, 155);
            this.rbCorrelativa.Name = "rbCorrelativa";
            this.rbCorrelativa.Size = new System.Drawing.Size(75, 17);
            this.rbCorrelativa.TabIndex = 28;
            this.rbCorrelativa.TabStop = true;
            this.rbCorrelativa.Text = "Correlativa";
            this.rbCorrelativa.UseVisualStyleBackColor = true;
            // 
            // listBoxCorrelativas
            // 
            this.listBoxCorrelativas.FormattingEnabled = true;
            this.listBoxCorrelativas.Location = new System.Drawing.Point(20, 224);
            this.listBoxCorrelativas.Name = "listBoxCorrelativas";
            this.listBoxCorrelativas.Size = new System.Drawing.Size(192, 108);
            this.listBoxCorrelativas.TabIndex = 29;
            // 
            // FrmEstudianteAE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(245)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(358, 399);
            this.Controls.Add(this.listBoxCorrelativas);
            this.Controls.Add(this.rbCorrelativa);
            this.Controls.Add(this.rbLibre);
            this.Controls.Add(this.tbDireccion);
            this.Controls.Add(this.tbApellidos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbNombres);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.cbCorrelativa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAceptar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmEstudianteAE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio de sesión";
            this.Load += new System.EventHandler(this.FrmEstudianteAE_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbCorrelativa;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox tbNombres;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbApellidos;
        private System.Windows.Forms.TextBox tbDireccion;
        private System.Windows.Forms.RadioButton rbLibre;
        private System.Windows.Forms.RadioButton rbCorrelativa;
        private System.Windows.Forms.ListBox listBoxCorrelativas;
    }
}

