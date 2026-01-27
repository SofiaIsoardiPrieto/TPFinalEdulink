namespace Edulink.Windows
{
    partial class FrmMateriaAE
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
            this.listBoxCorrelativas = new System.Windows.Forms.ListBox();
            this.rbCorrelativa = new System.Windows.Forms.RadioButton();
            this.rbLibre = new System.Windows.Forms.RadioButton();
            this.tbCuatrimestre = new System.Windows.Forms.TextBox();
            this.tbanioCarrera = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNombres = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cbCorrelativa = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxCorrelativas
            // 
            this.listBoxCorrelativas.FormattingEnabled = true;
            this.listBoxCorrelativas.Location = new System.Drawing.Point(20, 221);
            this.listBoxCorrelativas.Name = "listBoxCorrelativas";
            this.listBoxCorrelativas.Size = new System.Drawing.Size(192, 108);
            this.listBoxCorrelativas.TabIndex = 42;
            // 
            // rbCorrelativa
            // 
            this.rbCorrelativa.AutoSize = true;
            this.rbCorrelativa.Location = new System.Drawing.Point(20, 152);
            this.rbCorrelativa.Name = "rbCorrelativa";
            this.rbCorrelativa.Size = new System.Drawing.Size(75, 17);
            this.rbCorrelativa.TabIndex = 41;
            this.rbCorrelativa.TabStop = true;
            this.rbCorrelativa.Text = "Correlativa";
            this.rbCorrelativa.UseVisualStyleBackColor = true;
            // 
            // rbLibre
            // 
            this.rbLibre.AutoSize = true;
            this.rbLibre.Location = new System.Drawing.Point(20, 122);
            this.rbLibre.Name = "rbLibre";
            this.rbLibre.Size = new System.Drawing.Size(48, 17);
            this.rbLibre.TabIndex = 40;
            this.rbLibre.TabStop = true;
            this.rbLibre.Text = "Libre";
            this.rbLibre.UseVisualStyleBackColor = true;
            // 
            // tbCuatrimestre
            // 
            this.tbCuatrimestre.Location = new System.Drawing.Point(288, 90);
            this.tbCuatrimestre.Name = "tbCuatrimestre";
            this.tbCuatrimestre.Size = new System.Drawing.Size(50, 20);
            this.tbCuatrimestre.TabIndex = 39;
            // 
            // tbanioCarrera
            // 
            this.tbanioCarrera.Location = new System.Drawing.Point(139, 91);
            this.tbanioCarrera.Name = "tbanioCarrera";
            this.tbanioCarrera.Size = new System.Drawing.Size(50, 20);
            this.tbanioCarrera.TabIndex = 38;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(195, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 23);
            this.label5.TabIndex = 37;
            this.label5.Text = "Cuatrimestre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 23);
            this.label4.TabIndex = 36;
            this.label4.Text = "Año de la carrera:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 23);
            this.label2.TabIndex = 35;
            this.label2.Text = "Nombres:";
            // 
            // tbNombres
            // 
            this.tbNombres.Location = new System.Drawing.Point(90, 51);
            this.tbNombres.Name = "tbNombres";
            this.tbNombres.Size = new System.Drawing.Size(250, 20);
            this.tbNombres.TabIndex = 34;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancel.Location = new System.Drawing.Point(196, 347);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(83, 33);
            this.btnCancel.TabIndex = 33;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // cbCorrelativa
            // 
            this.cbCorrelativa.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCorrelativa.FormattingEnabled = true;
            this.cbCorrelativa.Location = new System.Drawing.Point(20, 175);
            this.cbCorrelativa.Name = "cbCorrelativa";
            this.cbCorrelativa.Size = new System.Drawing.Size(192, 29);
            this.cbCorrelativa.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Myanmar Text", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 43);
            this.label3.TabIndex = 31;
            this.label3.Text = "Materia";
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAceptar.Location = new System.Drawing.Point(69, 347);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(83, 33);
            this.btnAceptar.TabIndex = 30;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAceptar.UseVisualStyleBackColor = false;
            // 
            // FrmMateriaAE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(245)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(362, 388);
            this.Controls.Add(this.listBoxCorrelativas);
            this.Controls.Add(this.rbCorrelativa);
            this.Controls.Add(this.rbLibre);
            this.Controls.Add(this.tbCuatrimestre);
            this.Controls.Add(this.tbanioCarrera);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbNombres);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.cbCorrelativa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAceptar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMateriaAE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio de sesión";
            this.Load += new System.EventHandler(this.FrmEstudianteAE_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxCorrelativas;
        private System.Windows.Forms.RadioButton rbCorrelativa;
        private System.Windows.Forms.RadioButton rbLibre;
        private System.Windows.Forms.TextBox tbCuatrimestre;
        private System.Windows.Forms.TextBox tbanioCarrera;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNombres;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cbCorrelativa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAceptar;
    }
}

