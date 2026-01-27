namespace Edulink.Windows
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
            this.label5 = new System.Windows.Forms.Label();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsAlta = new System.Windows.Forms.ToolStripButton();
            this.tsEditar = new System.Windows.Forms.ToolStripButton();
            this.tsBorrar = new System.Windows.Forms.ToolStripButton();
            this.tsMaterias = new System.Windows.Forms.ToolStripButton();
            this.tsFinales = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsOrdenar = new System.Windows.Forms.ToolStripDropDownButton();
            this.estadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.regularToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.libreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recibidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FechaIngresoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CiudadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsBuscar = new System.Windows.Forms.ToolStripDropDownButton();
            this.legajoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dNIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsActualizar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsVolver = new System.Windows.Forms.ToolStripButton();
            this.label3 = new System.Windows.Forms.Label();
            this.lblRegistros = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUltimo = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnPrimero = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.dgvDatosEstudiantes = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPaginasTotales = new System.Windows.Forms.Label();
            this.lblPaginaActual = new System.Windows.Forms.Label();
            this.ColLegajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNombreApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColFechaAlta = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.toolStripContainer1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lblPaginaActual);
            this.splitContainer1.Panel2.Controls.Add(this.lblPaginasTotales);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.lblRegistros);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.btnUltimo);
            this.splitContainer1.Panel2.Controls.Add(this.btnSiguiente);
            this.splitContainer1.Panel2.Controls.Add(this.btnAnterior);
            this.splitContainer1.Panel2.Controls.Add(this.btnPrimero);
            this.splitContainer1.Panel2.Controls.Add(this.splitter1);
            this.splitContainer1.Panel2.Controls.Add(this.dgvDatosEstudiantes);
            this.splitContainer1.Size = new System.Drawing.Size(878, 372);
            this.splitContainer1.SplitterDistance = 64;
            this.splitContainer1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(90, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "ESTUDIANTES";
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(515, 0);
            this.toolStripContainer1.Location = new System.Drawing.Point(355, 3);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(515, 60);
            this.toolStripContainer1.TabIndex = 1;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip1);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsAlta,
            this.tsEditar,
            this.tsBorrar,
            this.tsMaterias,
            this.tsFinales,
            this.toolStripSeparator1,
            this.tsOrdenar,
            this.tsBuscar,
            this.tsActualizar,
            this.toolStripSeparator2,
            this.tsVolver});
            this.toolStrip1.Location = new System.Drawing.Point(3, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(508, 66);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsAlta
            // 
            this.tsAlta.Font = new System.Drawing.Font("Myanmar Text", 9.75F);
            this.tsAlta.Image = global::Edulink.Windows.Properties.Resources.nuevo1;
            this.tsAlta.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsAlta.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsAlta.Name = "tsAlta";
            this.tsAlta.Size = new System.Drawing.Size(40, 63);
            this.tsAlta.Text = "Alta";
            this.tsAlta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsAlta.Click += new System.EventHandler(this.tsNuevo_Click);
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
            this.tsBorrar.Size = new System.Drawing.Size(40, 63);
            this.tsBorrar.Text = "Baja";
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
            // tsOrdenar
            // 
            this.tsOrdenar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.estadoToolStripMenuItem,
            this.FechaIngresoToolStripMenuItem,
            this.CiudadToolStripMenuItem,
            this.edadToolStripMenuItem});
            this.tsOrdenar.Font = new System.Drawing.Font("Myanmar Text", 9.75F);
            this.tsOrdenar.Image = global::Edulink.Windows.Properties.Resources.filtrar1;
            this.tsOrdenar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsOrdenar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsOrdenar.Name = "tsOrdenar";
            this.tsOrdenar.Size = new System.Drawing.Size(56, 63);
            this.tsOrdenar.Text = "Filtrar";
            this.tsOrdenar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // estadoToolStripMenuItem
            // 
            this.estadoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.regularToolStripMenuItem,
            this.libreToolStripMenuItem,
            this.recibidoToolStripMenuItem});
            this.estadoToolStripMenuItem.Name = "estadoToolStripMenuItem";
            this.estadoToolStripMenuItem.Size = new System.Drawing.Size(208, 28);
            this.estadoToolStripMenuItem.Text = "Estado";
            // 
            // regularToolStripMenuItem
            // 
            this.regularToolStripMenuItem.Name = "regularToolStripMenuItem";
            this.regularToolStripMenuItem.Size = new System.Drawing.Size(180, 28);
            this.regularToolStripMenuItem.Text = "Regular";
            this.regularToolStripMenuItem.Click += new System.EventHandler(this.regularToolStripMenuItem_Click);
            // 
            // libreToolStripMenuItem
            // 
            this.libreToolStripMenuItem.Name = "libreToolStripMenuItem";
            this.libreToolStripMenuItem.Size = new System.Drawing.Size(180, 28);
            this.libreToolStripMenuItem.Text = "Libre";
            this.libreToolStripMenuItem.Click += new System.EventHandler(this.libreToolStripMenuItem_Click);
            // 
            // recibidoToolStripMenuItem
            // 
            this.recibidoToolStripMenuItem.Name = "recibidoToolStripMenuItem";
            this.recibidoToolStripMenuItem.Size = new System.Drawing.Size(180, 28);
            this.recibidoToolStripMenuItem.Text = "Recibido";
            this.recibidoToolStripMenuItem.Click += new System.EventHandler(this.recibidoToolStripMenuItem_Click);
            // 
            // FechaIngresoToolStripMenuItem
            // 
            this.FechaIngresoToolStripMenuItem.Name = "FechaIngresoToolStripMenuItem";
            this.FechaIngresoToolStripMenuItem.Size = new System.Drawing.Size(208, 28);
            this.FechaIngresoToolStripMenuItem.Text = "Fecha Ingreso (rango)";
            // 
            // CiudadToolStripMenuItem
            // 
            this.CiudadToolStripMenuItem.Name = "CiudadToolStripMenuItem";
            this.CiudadToolStripMenuItem.Size = new System.Drawing.Size(208, 28);
            this.CiudadToolStripMenuItem.Text = "Ciudad";
            this.CiudadToolStripMenuItem.Click += new System.EventHandler(this.ciudadToolStripMenuItem_Click);
            // 
            // edadToolStripMenuItem
            // 
            this.edadToolStripMenuItem.Name = "edadToolStripMenuItem";
            this.edadToolStripMenuItem.Size = new System.Drawing.Size(208, 28);
            this.edadToolStripMenuItem.Text = "Edad (rango)";
            this.edadToolStripMenuItem.Click += new System.EventHandler(this.edadToolStripMenuItem_Click);
            // 
            // tsBuscar
            // 
            this.tsBuscar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.legajoToolStripMenuItem,
            this.dNIToolStripMenuItem});
            this.tsBuscar.Font = new System.Drawing.Font("Myanmar Text", 9.75F);
            this.tsBuscar.Image = global::Edulink.Windows.Properties.Resources.buscar1;
            this.tsBuscar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBuscar.Name = "tsBuscar";
            this.tsBuscar.Size = new System.Drawing.Size(61, 63);
            this.tsBuscar.Text = "Buscar";
            this.tsBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // legajoToolStripMenuItem
            // 
            this.legajoToolStripMenuItem.Name = "legajoToolStripMenuItem";
            this.legajoToolStripMenuItem.Size = new System.Drawing.Size(180, 28);
            this.legajoToolStripMenuItem.Text = "Legajo";
            this.legajoToolStripMenuItem.Click += new System.EventHandler(this.legajoToolStripMenuItem_Click);
            // 
            // dNIToolStripMenuItem
            // 
            this.dNIToolStripMenuItem.Name = "dNIToolStripMenuItem";
            this.dNIToolStripMenuItem.Size = new System.Drawing.Size(180, 28);
            this.dNIToolStripMenuItem.Text = "DNI";
            this.dNIToolStripMenuItem.Click += new System.EventHandler(this.dNIToolStripMenuItem_Click);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(433, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "de:";
            // 
            // lblRegistros
            // 
            this.lblRegistros.AutoSize = true;
            this.lblRegistros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistros.Location = new System.Drawing.Point(179, 268);
            this.lblRegistros.Name = "lblRegistros";
            this.lblRegistros.Size = new System.Drawing.Size(19, 20);
            this.lblRegistros.TabIndex = 7;
            this.lblRegistros.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 267);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Cantidad de registros:";
            // 
            // btnUltimo
            // 
            this.btnUltimo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUltimo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnUltimo.Image = global::Edulink.Windows.Properties.Resources.ultimo;
            this.btnUltimo.Location = new System.Drawing.Point(730, 260);
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
            this.btnSiguiente.Location = new System.Drawing.Point(669, 260);
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
            this.btnAnterior.Location = new System.Drawing.Point(612, 260);
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
            this.btnPrimero.Location = new System.Drawing.Point(551, 260);
            this.btnPrimero.Name = "btnPrimero";
            this.btnPrimero.Size = new System.Drawing.Size(51, 35);
            this.btnPrimero.TabIndex = 2;
            this.btnPrimero.UseVisualStyleBackColor = true;
            this.btnPrimero.Click += new System.EventHandler(this.btnPrimero_Click);
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter1.Location = new System.Drawing.Point(0, 254);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(878, 50);
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
            this.ColFechaAlta,
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
            this.dgvDatosEstudiantes.Size = new System.Drawing.Size(878, 304);
            this.dgvDatosEstudiantes.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(259, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Página:";
            // 
            // lblPaginasTotales
            // 
            this.lblPaginasTotales.AutoSize = true;
            this.lblPaginasTotales.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaginasTotales.Location = new System.Drawing.Point(464, 267);
            this.lblPaginasTotales.Name = "lblPaginasTotales";
            this.lblPaginasTotales.Size = new System.Drawing.Size(19, 20);
            this.lblPaginasTotales.TabIndex = 10;
            this.lblPaginasTotales.Text = "0";
            // 
            // lblPaginaActual
            // 
            this.lblPaginaActual.AutoSize = true;
            this.lblPaginaActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaginaActual.Location = new System.Drawing.Point(320, 269);
            this.lblPaginaActual.Name = "lblPaginaActual";
            this.lblPaginaActual.Size = new System.Drawing.Size(19, 20);
            this.lblPaginaActual.TabIndex = 11;
            this.lblPaginaActual.Text = "0";
            // 
            // ColLegajo
            // 
            this.ColLegajo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ColLegajo.HeaderText = "Legajo";
            this.ColLegajo.Name = "ColLegajo";
            this.ColLegajo.ReadOnly = true;
            this.ColLegajo.Width = 64;
            // 
            // ColNombreApellido
            // 
            this.ColNombreApellido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ColNombreApellido.HeaderText = "Nombre y Apellido";
            this.ColNombreApellido.Name = "ColNombreApellido";
            this.ColNombreApellido.ReadOnly = true;
            this.ColNombreApellido.Width = 107;
            // 
            // ColEstado
            // 
            this.ColEstado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ColEstado.HeaderText = "Estado";
            this.ColEstado.Name = "ColEstado";
            this.ColEstado.ReadOnly = true;
            this.ColEstado.Width = 65;
            // 
            // ColFechaAlta
            // 
            this.ColFechaAlta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ColFechaAlta.HeaderText = "FechaAlta";
            this.ColFechaAlta.Name = "ColFechaAlta";
            this.ColFechaAlta.ReadOnly = true;
            this.ColFechaAlta.Width = 80;
            // 
            // ColCiudad
            // 
            this.ColCiudad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ColCiudad.HeaderText = "Ciudad";
            this.ColCiudad.Name = "ColCiudad";
            this.ColCiudad.ReadOnly = true;
            this.ColCiudad.Width = 65;
            // 
            // ColDireccion
            // 
            this.ColDireccion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ColDireccion.HeaderText = "Dirección";
            this.ColDireccion.Name = "ColDireccion";
            this.ColDireccion.ReadOnly = true;
            this.ColDireccion.Width = 77;
            // 
            // ColTelefono
            // 
            this.ColTelefono.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ColTelefono.HeaderText = "Teléfono";
            this.ColTelefono.Name = "ColTelefono";
            this.ColTelefono.ReadOnly = true;
            this.ColTelefono.Width = 74;
            // 
            // ColEmail
            // 
            this.ColEmail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ColEmail.HeaderText = "Email";
            this.ColEmail.Name = "ColEmail";
            this.ColEmail.ReadOnly = true;
            this.ColEmail.Width = 57;
            // 
            // ColDNI
            // 
            this.ColDNI.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ColDNI.HeaderText = "DNI";
            this.ColDNI.Name = "ColDNI";
            this.ColDNI.ReadOnly = true;
            this.ColDNI.Width = 51;
            // 
            // ColFechaNac
            // 
            this.ColFechaNac.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ColFechaNac.HeaderText = "Fecha Nac.";
            this.ColFechaNac.Name = "ColFechaNac";
            this.ColFechaNac.ReadOnly = true;
            this.ColFechaNac.Width = 81;
            // 
            // FrmEstudiantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(245)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(878, 372);
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
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosEstudiantes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgvDatosEstudiantes;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button btnPrimero;
        private System.Windows.Forms.Button btnUltimo;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Label lblRegistros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripButton tsAlta;
        private System.Windows.Forms.ToolStripButton tsEditar;
        private System.Windows.Forms.ToolStripButton tsBorrar;
        private System.Windows.Forms.ToolStripButton tsMaterias;
        private System.Windows.Forms.ToolStripButton tsFinales;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripDropDownButton tsOrdenar;
        private System.Windows.Forms.ToolStripMenuItem estadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem regularToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem libreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recibidoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FechaIngresoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CiudadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem edadToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton tsBuscar;
        private System.Windows.Forms.ToolStripMenuItem legajoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dNIToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton tsActualizar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsVolver;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblPaginaActual;
        private System.Windows.Forms.Label lblPaginasTotales;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColLegajo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNombreApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColFechaAlta;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCiudad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDireccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColFechaNac;
    }
}