﻿namespace Edulink.Windows
{
    partial class FrmEstudiantes
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
            this.tsNuevo = new System.Windows.Forms.ToolStripButton();
            this.tsEditar = new System.Windows.Forms.ToolStripButton();
            this.tsBorrar = new System.Windows.Forms.ToolStripButton();
            this.tsMaterias = new System.Windows.Forms.ToolStripButton();
            this.tsFinales = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsFiltrar = new System.Windows.Forms.ToolStripButton();
            this.tsBuscar = new System.Windows.Forms.ToolStripButton();
            this.tsActualizar = new System.Windows.Forms.ToolStripButton();
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
            this.dgvDatosEstudiantes = new System.Windows.Forms.DataGridView();
            this.ColLegajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNombreApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCiudad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDireccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColFechaNac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosEstudiantes)).BeginInit();
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
            this.splitContainer1.Panel2.Controls.Add(this.dgvDatosEstudiantes);
            this.splitContainer1.Size = new System.Drawing.Size(824, 374);
            this.splitContainer1.SplitterDistance = 65;
            this.splitContainer1.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsNuevo,
            this.tsEditar,
            this.tsBorrar,
            this.tsMaterias,
            this.tsFinales,
            this.toolStripSeparator1,
            this.tsFiltrar,
            this.tsBuscar,
            this.tsActualizar,
            this.toolStripSeparator2,
            this.tsVolver});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(824, 66);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsNuevo
            // 
            this.tsNuevo.Font = new System.Drawing.Font("Myanmar Text", 9.75F);
            this.tsNuevo.Image = global::Edulink.Windows.Properties.Resources.nuevo1;
            this.tsNuevo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsNuevo.Name = "tsNuevo";
            this.tsNuevo.Size = new System.Drawing.Size(52, 63);
            this.tsNuevo.Text = "Nuevo";
            this.tsNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsNuevo.Click += new System.EventHandler(this.tsNuevo_Click);
            // 
            // tsEditar
            // 
            this.tsEditar.Font = new System.Drawing.Font("Myanmar Text", 9.75F);
            this.tsEditar.Image = global::Edulink.Windows.Properties.Resources.editar1;
            this.tsEditar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsEditar.Name = "tsEditar";
            this.tsEditar.Size = new System.Drawing.Size(48, 63);
            this.tsEditar.Text = "Editar";
            this.tsEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsEditar.Click += new System.EventHandler(this.tsEditar_Click);
            // 
            // tsBorrar
            // 
            this.tsBorrar.Font = new System.Drawing.Font("Myanmar Text", 9.75F);
            this.tsBorrar.Image = global::Edulink.Windows.Properties.Resources.borrar1;
            this.tsBorrar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsBorrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBorrar.Name = "tsBorrar";
            this.tsBorrar.Size = new System.Drawing.Size(51, 63);
            this.tsBorrar.Text = "Borrar";
            this.tsBorrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsBorrar.Click += new System.EventHandler(this.tsBorrar_Click);
            // 
            // tsMaterias
            // 
            this.tsMaterias.Font = new System.Drawing.Font("Myanmar Text", 9.75F);
            this.tsMaterias.Image = global::Edulink.Windows.Properties.Resources.materias1;
            this.tsMaterias.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsMaterias.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsMaterias.Name = "tsMaterias";
            this.tsMaterias.Size = new System.Drawing.Size(65, 63);
            this.tsMaterias.Text = "Materias";
            this.tsMaterias.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsMaterias.Click += new System.EventHandler(this.tsMaterias_Click);
            // 
            // tsFinales
            // 
            this.tsFinales.Font = new System.Drawing.Font("Myanmar Text", 9.75F);
            this.tsFinales.Image = global::Edulink.Windows.Properties.Resources.examen1;
            this.tsFinales.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsFinales.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsFinales.Name = "tsFinales";
            this.tsFinales.Size = new System.Drawing.Size(53, 63);
            this.tsFinales.Text = "Finales";
            this.tsFinales.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsFinales.Click += new System.EventHandler(this.tsFinales_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 66);
            // 
            // tsFiltrar
            // 
            this.tsFiltrar.Font = new System.Drawing.Font("Myanmar Text", 9.75F);
            this.tsFiltrar.Image = global::Edulink.Windows.Properties.Resources.filtrar1;
            this.tsFiltrar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsFiltrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsFiltrar.Name = "tsFiltrar";
            this.tsFiltrar.Size = new System.Drawing.Size(47, 63);
            this.tsFiltrar.Text = "Filtrar";
            this.tsFiltrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsFiltrar.Click += new System.EventHandler(this.tsFiltrar_Click);
            // 
            // tsBuscar
            // 
            this.tsBuscar.Font = new System.Drawing.Font("Myanmar Text", 9.75F);
            this.tsBuscar.Image = global::Edulink.Windows.Properties.Resources.buscar1;
            this.tsBuscar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBuscar.Name = "tsBuscar";
            this.tsBuscar.Size = new System.Drawing.Size(52, 63);
            this.tsBuscar.Text = "Buscar";
            this.tsBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsBuscar.Click += new System.EventHandler(this.tsBuscar_Click);
            // 
            // tsActualizar
            // 
            this.tsActualizar.Font = new System.Drawing.Font("Myanmar Text", 9.75F);
            this.tsActualizar.Image = global::Edulink.Windows.Properties.Resources.actualizar1;
            this.tsActualizar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsActualizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsActualizar.Name = "tsActualizar";
            this.tsActualizar.Size = new System.Drawing.Size(70, 63);
            this.tsActualizar.Text = "Actualizar";
            this.tsActualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsActualizar.Click += new System.EventHandler(this.tsActualizar_Click);
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
            this.label3.Location = new System.Drawing.Point(109, 282);
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
            this.btnUltimo.Click += new System.EventHandler(this.btnUltimo_Click);
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
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
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
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
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
            this.btnPrimero.Click += new System.EventHandler(this.btnPrimero_Click);
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter1.Location = new System.Drawing.Point(0, 255);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(824, 50);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // dgvDatosEstudiantes
            // 
            this.dgvDatosEstudiantes.AllowUserToAddRows = false;
            this.dgvDatosEstudiantes.AllowUserToDeleteRows = false;
            this.dgvDatosEstudiantes.AllowUserToResizeColumns = false;
            this.dgvDatosEstudiantes.AllowUserToResizeRows = false;
            this.dgvDatosEstudiantes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(245)))), ((int)(((byte)(253)))));
            this.dgvDatosEstudiantes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDatosEstudiantes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvDatosEstudiantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatosEstudiantes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColLegajo,
            this.ColNombreApellido,
            this.ColEstado,
            this.ColCiudad,
            this.ColDireccion,
            this.ColTelefono,
            this.ColEmail,
            this.ColDNI,
            this.ColFechaNac});
            this.dgvDatosEstudiantes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDatosEstudiantes.Location = new System.Drawing.Point(0, 0);
            this.dgvDatosEstudiantes.Name = "dgvDatosEstudiantes";
            this.dgvDatosEstudiantes.ReadOnly = true;
            this.dgvDatosEstudiantes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatosEstudiantes.Size = new System.Drawing.Size(824, 305);
            this.dgvDatosEstudiantes.TabIndex = 0;
            // 
            // ColLegajo
            // 
            this.ColLegajo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColLegajo.HeaderText = "Legajo";
            this.ColLegajo.Name = "ColLegajo";
            this.ColLegajo.ReadOnly = true;
            // 
            // ColNombreApellido
            // 
            this.ColNombreApellido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColNombreApellido.HeaderText = "Nombre y Apellido";
            this.ColNombreApellido.Name = "ColNombreApellido";
            this.ColNombreApellido.ReadOnly = true;
            // 
            // ColEstado
            // 
            this.ColEstado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColEstado.HeaderText = "Estado";
            this.ColEstado.Name = "ColEstado";
            this.ColEstado.ReadOnly = true;
            // 
            // ColCiudad
            // 
            this.ColCiudad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColCiudad.HeaderText = "Ciudad";
            this.ColCiudad.Name = "ColCiudad";
            this.ColCiudad.ReadOnly = true;
            // 
            // ColDireccion
            // 
            this.ColDireccion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColDireccion.HeaderText = "Dirección";
            this.ColDireccion.Name = "ColDireccion";
            this.ColDireccion.ReadOnly = true;
            // 
            // ColTelefono
            // 
            this.ColTelefono.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColTelefono.HeaderText = "Teléfono";
            this.ColTelefono.Name = "ColTelefono";
            this.ColTelefono.ReadOnly = true;
            // 
            // ColEmail
            // 
            this.ColEmail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColEmail.HeaderText = "Email";
            this.ColEmail.Name = "ColEmail";
            this.ColEmail.ReadOnly = true;
            // 
            // ColDNI
            // 
            this.ColDNI.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColDNI.HeaderText = "DNI";
            this.ColDNI.Name = "ColDNI";
            this.ColDNI.ReadOnly = true;
            // 
            // ColFechaNac
            // 
            this.ColFechaNac.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColFechaNac.HeaderText = "Fecha Nac.";
            this.ColFechaNac.Name = "ColFechaNac";
            this.ColFechaNac.ReadOnly = true;
            // 
            // FrmEstudiantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(245)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(824, 374);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmEstudiantes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmEstudiantes";
            this.Load += new System.EventHandler(this.FrmEstudiantes_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosEstudiantes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.DataGridView dgvDatosEstudiantes;
        private System.Windows.Forms.ToolStripButton tsNuevo;
        private System.Windows.Forms.ToolStripButton tsEditar;
        private System.Windows.Forms.ToolStripButton tsBorrar;
        private System.Windows.Forms.ToolStripButton tsVolver;
        private System.Windows.Forms.ToolStripButton tsFinales;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsFiltrar;
        private System.Windows.Forms.ToolStripButton tsActualizar;
        private System.Windows.Forms.ToolStripButton tsBuscar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsMaterias;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn ColLegajo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNombreApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCiudad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDireccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColFechaNac;
    }
}