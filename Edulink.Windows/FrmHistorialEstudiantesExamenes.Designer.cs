namespace Edulink.Windows
{
    partial class FrmHistorialEstudiantesExamenes
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsImprimir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsVolver = new System.Windows.Forms.ToolStripButton();
            this.lblPaginaActual = new System.Windows.Forms.Label();
            this.lblPaginasTotales = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRegistros = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUltimo = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnPrimero = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.dgvDatosHistorialEstudiantesMateria = new System.Windows.Forms.DataGridView();
            this.ColMateria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblLegajo = new System.Windows.Forms.Label();
            this.lblNombreEstudiante = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosHistorialEstudiantesMateria)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lblNombreEstudiante);
            this.splitContainer1.Panel1.Controls.Add(this.lblLegajo);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.toolStrip1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lblPaginaActual);
            this.splitContainer1.Panel2.Controls.Add(this.lblPaginasTotales);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.lblRegistros);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.btnUltimo);
            this.splitContainer1.Panel2.Controls.Add(this.btnSiguiente);
            this.splitContainer1.Panel2.Controls.Add(this.btnAnterior);
            this.splitContainer1.Panel2.Controls.Add(this.btnPrimero);
            this.splitContainer1.Panel2.Controls.Add(this.splitter1);
            this.splitContainer1.Panel2.Controls.Add(this.dgvDatosHistorialEstudiantesMateria);
            this.splitContainer1.Size = new System.Drawing.Size(523, 376);
            this.splitContainer1.SplitterDistance = 67;
            this.splitContainer1.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsImprimir,
            this.toolStripSeparator1,
            this.toolStripSeparator2,
            this.tsVolver});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(523, 66);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsImprimir
            // 
            this.tsImprimir.Font = new System.Drawing.Font("Myanmar Text", 9.75F);
            this.tsImprimir.Image = global::Edulink.Windows.Properties.Resources.certificado;
            this.tsImprimir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsImprimir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsImprimir.Name = "tsImprimir";
            this.tsImprimir.Size = new System.Drawing.Size(63, 63);
            this.tsImprimir.Text = "Imprimir";
            this.tsImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsImprimir.Click += new System.EventHandler(this.tsImprimir_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 66);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 66);
            // 
            // tsVolver
            // 
            this.tsVolver.Font = new System.Drawing.Font("Myanmar Text", 9.75F);
            this.tsVolver.Image = global::Edulink.Windows.Properties.Resources.volver;
            this.tsVolver.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsVolver.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsVolver.Name = "tsVolver";
            this.tsVolver.Size = new System.Drawing.Size(51, 63);
            this.tsVolver.Text = "Volver";
            this.tsVolver.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsVolver.Click += new System.EventHandler(this.tsVolver_Click);
            // 
            // lblPaginaActual
            // 
            this.lblPaginaActual.AutoSize = true;
            this.lblPaginaActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaginaActual.Location = new System.Drawing.Point(66, 283);
            this.lblPaginaActual.Name = "lblPaginaActual";
            this.lblPaginaActual.Size = new System.Drawing.Size(14, 13);
            this.lblPaginaActual.TabIndex = 11;
            this.lblPaginaActual.Text = "0";
            // 
            // lblPaginasTotales
            // 
            this.lblPaginasTotales.AutoSize = true;
            this.lblPaginasTotales.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaginasTotales.Location = new System.Drawing.Point(137, 282);
            this.lblPaginasTotales.Name = "lblPaginasTotales";
            this.lblPaginasTotales.Size = new System.Drawing.Size(14, 13);
            this.lblPaginasTotales.TabIndex = 10;
            this.lblPaginasTotales.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(108, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "de:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Página:";
            // 
            // lblRegistros
            // 
            this.lblRegistros.AutoSize = true;
            this.lblRegistros.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistros.Location = new System.Drawing.Point(138, 262);
            this.lblRegistros.Name = "lblRegistros";
            this.lblRegistros.Size = new System.Drawing.Size(14, 13);
            this.lblRegistros.TabIndex = 7;
            this.lblRegistros.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 262);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Cantidad de registros:";
            // 
            // btnUltimo
            // 
            this.btnUltimo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUltimo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnUltimo.Image = global::Edulink.Windows.Properties.Resources.ultimo;
            this.btnUltimo.Location = new System.Drawing.Point(441, 262);
            this.btnUltimo.Name = "btnUltimo";
            this.btnUltimo.Size = new System.Drawing.Size(51, 35);
            this.btnUltimo.TabIndex = 5;
            this.btnUltimo.UseVisualStyleBackColor = true;
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiguiente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSiguiente.Image = global::Edulink.Windows.Properties.Resources.siguiente;
            this.btnSiguiente.Location = new System.Drawing.Point(380, 262);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(51, 35);
            this.btnSiguiente.TabIndex = 4;
            this.btnSiguiente.UseVisualStyleBackColor = true;
            // 
            // btnAnterior
            // 
            this.btnAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnterior.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAnterior.Image = global::Edulink.Windows.Properties.Resources.atras;
            this.btnAnterior.Location = new System.Drawing.Point(323, 262);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(51, 35);
            this.btnAnterior.TabIndex = 3;
            this.btnAnterior.UseVisualStyleBackColor = true;
            // 
            // btnPrimero
            // 
            this.btnPrimero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrimero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPrimero.Image = global::Edulink.Windows.Properties.Resources.primero;
            this.btnPrimero.Location = new System.Drawing.Point(262, 262);
            this.btnPrimero.Name = "btnPrimero";
            this.btnPrimero.Size = new System.Drawing.Size(51, 35);
            this.btnPrimero.TabIndex = 2;
            this.btnPrimero.UseVisualStyleBackColor = true;
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter1.Location = new System.Drawing.Point(0, 255);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(523, 50);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // dgvDatosHistorialEstudiantesMateria
            // 
            this.dgvDatosHistorialEstudiantesMateria.AllowUserToAddRows = false;
            this.dgvDatosHistorialEstudiantesMateria.AllowUserToDeleteRows = false;
            this.dgvDatosHistorialEstudiantesMateria.AllowUserToResizeColumns = false;
            this.dgvDatosHistorialEstudiantesMateria.AllowUserToResizeRows = false;
            this.dgvDatosHistorialEstudiantesMateria.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(245)))), ((int)(((byte)(253)))));
            this.dgvDatosHistorialEstudiantesMateria.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDatosHistorialEstudiantesMateria.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvDatosHistorialEstudiantesMateria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatosHistorialEstudiantesMateria.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColMateria,
            this.ColNota,
            this.ColEstado});
            this.dgvDatosHistorialEstudiantesMateria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDatosHistorialEstudiantesMateria.Location = new System.Drawing.Point(0, 0);
            this.dgvDatosHistorialEstudiantesMateria.Name = "dgvDatosHistorialEstudiantesMateria";
            this.dgvDatosHistorialEstudiantesMateria.ReadOnly = true;
            this.dgvDatosHistorialEstudiantesMateria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatosHistorialEstudiantesMateria.Size = new System.Drawing.Size(523, 305);
            this.dgvDatosHistorialEstudiantesMateria.TabIndex = 0;
            // 
            // ColMateria
            // 
            this.ColMateria.HeaderText = "Materia";
            this.ColMateria.Name = "ColMateria";
            this.ColMateria.ReadOnly = true;
            // 
            // ColNota
            // 
            this.ColNota.HeaderText = "Nota";
            this.ColNota.Name = "ColNota";
            this.ColNota.ReadOnly = true;
            // 
            // ColEstado
            // 
            this.ColEstado.HeaderText = "Estado";
            this.ColEstado.Name = "ColEstado";
            this.ColEstado.ReadOnly = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(183, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Estudiante:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(183, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Legajo:";
            // 
            // lblLegajo
            // 
            this.lblLegajo.AutoSize = true;
            this.lblLegajo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLegajo.Location = new System.Drawing.Point(231, 9);
            this.lblLegajo.Name = "lblLegajo";
            this.lblLegajo.Size = new System.Drawing.Size(11, 13);
            this.lblLegajo.TabIndex = 12;
            this.lblLegajo.Text = "-";
            // 
            // lblNombreEstudiante
            // 
            this.lblNombreEstudiante.AutoSize = true;
            this.lblNombreEstudiante.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreEstudiante.Location = new System.Drawing.Point(249, 34);
            this.lblNombreEstudiante.Name = "lblNombreEstudiante";
            this.lblNombreEstudiante.Size = new System.Drawing.Size(11, 13);
            this.lblNombreEstudiante.TabIndex = 14;
            this.lblNombreEstudiante.Text = "-";
            // 
            // FrmHistorialEstudiantesMateria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(245)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(523, 376);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmHistorialEstudiantesMateria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmEstudiantes";
            this.Load += new System.EventHandler(this.FrmMaterias_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosHistorialEstudiantesMateria)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.DataGridView dgvDatosHistorialEstudiantesMateria;
        private System.Windows.Forms.ToolStripButton tsImprimir;
        private System.Windows.Forms.ToolStripButton tsVolver;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button btnPrimero;
        private System.Windows.Forms.Button btnUltimo;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Label lblRegistros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPaginaActual;
        private System.Windows.Forms.Label lblPaginasTotales;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNombreEstudiante;
        private System.Windows.Forms.Label lblLegajo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMateria;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNota;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEstado;
    }
}