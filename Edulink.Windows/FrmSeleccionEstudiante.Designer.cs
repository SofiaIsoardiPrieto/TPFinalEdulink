namespace Edulink.Windows
{
    partial class FrmSeleccionEstudiante
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
            this.btnExamenes = new System.Windows.Forms.Button();
            this.btnMaterias = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExamenes
            // 
            this.btnExamenes.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnExamenes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExamenes.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExamenes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExamenes.Image = global::Edulink.Windows.Properties.Resources.examen;
            this.btnExamenes.Location = new System.Drawing.Point(203, 51);
            this.btnExamenes.Name = "btnExamenes";
            this.btnExamenes.Size = new System.Drawing.Size(110, 72);
            this.btnExamenes.TabIndex = 10;
            this.btnExamenes.Text = "Examenes";
            this.btnExamenes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExamenes.UseVisualStyleBackColor = false;
            this.btnExamenes.Click += new System.EventHandler(this.btnExamenes_Click);
            // 
            // btnMaterias
            // 
            this.btnMaterias.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnMaterias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaterias.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaterias.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMaterias.Image = global::Edulink.Windows.Properties.Resources.materia;
            this.btnMaterias.Location = new System.Drawing.Point(52, 51);
            this.btnMaterias.Name = "btnMaterias";
            this.btnMaterias.Size = new System.Drawing.Size(110, 72);
            this.btnMaterias.TabIndex = 9;
            this.btnMaterias.Text = "Materias";
            this.btnMaterias.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnMaterias.UseVisualStyleBackColor = false;
            this.btnMaterias.Click += new System.EventHandler(this.btnMaterias_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnVolver.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnVolver.Location = new System.Drawing.Point(316, 157);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(83, 33);
            this.btnVolver.TabIndex = 18;
            this.btnVolver.Text = "Volver";
            this.btnVolver.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // FrmSeleccionEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(245)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(404, 196);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnExamenes);
            this.Controls.Add(this.btnMaterias);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSeleccionEstudiante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio de sesión";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnMaterias;
        private System.Windows.Forms.Button btnExamenes;
        private System.Windows.Forms.Button btnVolver;
    }
}

