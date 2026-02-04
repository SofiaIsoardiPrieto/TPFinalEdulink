namespace Edulink.Windows
{
    partial class FrmInscripcionMaterias
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsInscribir = new System.Windows.Forms.ToolStripButton();
            this.tsEditar = new System.Windows.Forms.ToolStripButton();
            this.tsBorrar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsFiltrar = new System.Windows.Forms.ToolStripDropDownButton();
            this.añoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.erToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.erToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsCertificado = new System.Windows.Forms.ToolStripButton();
            this.tsActualizar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsVolver = new System.Windows.Forms.ToolStripButton();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.dgvInscripcionMaterias = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColHorario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCondicionLibre = new System.Windows.Forms.DataGridViewCheckBoxColumn();
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
            this.ColNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInscripcionMaterias)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.toolStripContainer1);
            this.splitContainer1.Panel1.Controls.Add(this.splitter2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvInscripcionMaterias);
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
            this.splitContainer1.Size = new System.Drawing.Size(655, 375);
            this.splitContainer1.SplitterDistance = 65;
            this.splitContainer1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "Inscripción";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "MATERIAS";
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(459, 0);
            this.toolStripContainer1.Location = new System.Drawing.Point(164, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(459, 65);
            this.toolStripContainer1.TabIndex = 5;
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
            this.tsInscribir,
            this.tsEditar,
            this.tsBorrar,
            this.toolStripSeparator1,
            this.tsFiltrar,
            this.tsCertificado,
            this.tsActualizar,
            this.toolStripSeparator2,
            this.tsVolver});
            this.toolStrip1.Location = new System.Drawing.Point(3, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(437, 66);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsInscribir
            // 
            this.tsInscribir.Font = new System.Drawing.Font("Myanmar Text", 9.75F);
            this.tsInscribir.Image = global::Edulink.Windows.Properties.Resources.nuevo1;
            this.tsInscribir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsInscribir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsInscribir.Name = "tsInscribir";
            this.tsInscribir.Size = new System.Drawing.Size(60, 63);
            this.tsInscribir.Text = "Inscribir";
            this.tsInscribir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsInscribir.Click += new System.EventHandler(this.tsInscribir_Click);
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
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 66);
            // 
            // tsFiltrar
            // 
            this.tsFiltrar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.añoToolStripMenuItem});
            this.tsFiltrar.Font = new System.Drawing.Font("Myanmar Text", 9.75F);
            this.tsFiltrar.Image = global::Edulink.Windows.Properties.Resources.filtrar1;
            this.tsFiltrar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsFiltrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsFiltrar.Name = "tsFiltrar";
            this.tsFiltrar.Size = new System.Drawing.Size(56, 63);
            this.tsFiltrar.Text = "Filtrar";
            this.tsFiltrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // añoToolStripMenuItem
            // 
            this.añoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.erToolStripMenuItem,
            this.doToolStripMenuItem,
            this.erToolStripMenuItem1});
            this.añoToolStripMenuItem.Name = "añoToolStripMenuItem";
            this.añoToolStripMenuItem.Size = new System.Drawing.Size(103, 28);
            this.añoToolStripMenuItem.Text = "Año";
            // 
            // erToolStripMenuItem
            // 
            this.erToolStripMenuItem.Name = "erToolStripMenuItem";
            this.erToolStripMenuItem.Size = new System.Drawing.Size(103, 28);
            this.erToolStripMenuItem.Text = "1er";
            this.erToolStripMenuItem.Click += new System.EventHandler(this.erToolStripMenuItem_Click);
            // 
            // doToolStripMenuItem
            // 
            this.doToolStripMenuItem.Name = "doToolStripMenuItem";
            this.doToolStripMenuItem.Size = new System.Drawing.Size(103, 28);
            this.doToolStripMenuItem.Text = "2do";
            this.doToolStripMenuItem.Click += new System.EventHandler(this.doToolStripMenuItem_Click);
            // 
            // erToolStripMenuItem1
            // 
            this.erToolStripMenuItem1.Name = "erToolStripMenuItem1";
            this.erToolStripMenuItem1.Size = new System.Drawing.Size(103, 28);
            this.erToolStripMenuItem1.Text = "3er";
            this.erToolStripMenuItem1.Click += new System.EventHandler(this.erToolStripMenuItem1_Click);
            // 
            // tsCertificado
            // 
            this.tsCertificado.Font = new System.Drawing.Font("Myanmar Text", 9.75F);
            this.tsCertificado.Image = global::Edulink.Windows.Properties.Resources.certificado;
            this.tsCertificado.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsCertificado.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsCertificado.Name = "tsCertificado";
            this.tsCertificado.Size = new System.Drawing.Size(77, 63);
            this.tsCertificado.Text = "Certificado";
            this.tsCertificado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsCertificado.Click += new System.EventHandler(this.tsCertificado_Click);
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
            // splitter2
            // 
            this.splitter2.Location = new System.Drawing.Point(0, 0);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(3, 65);
            this.splitter2.TabIndex = 1;
            this.splitter2.TabStop = false;
            // 
            // dgvInscripcionMaterias
            // 
            this.dgvInscripcionMaterias.AllowUserToAddRows = false;
            this.dgvInscripcionMaterias.AllowUserToDeleteRows = false;
            this.dgvInscripcionMaterias.AllowUserToResizeColumns = false;
            this.dgvInscripcionMaterias.AllowUserToResizeRows = false;
            this.dgvInscripcionMaterias.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(245)))), ((int)(((byte)(253)))));
            this.dgvInscripcionMaterias.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvInscripcionMaterias.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInscripcionMaterias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvInscripcionMaterias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInscripcionMaterias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.ColHorario,
            this.ColCondicionLibre});
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInscripcionMaterias.DefaultCellStyle = dataGridViewCellStyle14;
            this.dgvInscripcionMaterias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInscripcionMaterias.Location = new System.Drawing.Point(0, 0);
            this.dgvInscripcionMaterias.MultiSelect = false;
            this.dgvInscripcionMaterias.Name = "dgvInscripcionMaterias";
            this.dgvInscripcionMaterias.ReadOnly = true;
            this.dgvInscripcionMaterias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInscripcionMaterias.Size = new System.Drawing.Size(655, 246);
            this.dgvInscripcionMaterias.TabIndex = 12;
            this.dgvInscripcionMaterias.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInscripcionMaterias_CellClick);
            this.dgvInscripcionMaterias.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInscripcionMaterias_CellValueChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.HeaderText = "Año";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // ColHorario
            // 
            this.ColHorario.HeaderText = "Horario";
            this.ColHorario.Name = "ColHorario";
            this.ColHorario.ReadOnly = true;
            // 
            // ColCondicionLibre
            // 
            this.ColCondicionLibre.HeaderText = "Libre";
            this.ColCondicionLibre.Name = "ColCondicionLibre";
            this.ColCondicionLibre.ReadOnly = true;
            this.ColCondicionLibre.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColCondicionLibre.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
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
            this.splitter1.Location = new System.Drawing.Point(0, 246);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(655, 60);
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
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDatosEstudiantes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvDatosEstudiantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatosEstudiantes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColNombre,
            this.ColApellido,
            this.ColEstado});
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDatosEstudiantes.DefaultCellStyle = dataGridViewCellStyle16;
            this.dgvDatosEstudiantes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDatosEstudiantes.Location = new System.Drawing.Point(0, 0);
            this.dgvDatosEstudiantes.Name = "dgvDatosEstudiantes";
            this.dgvDatosEstudiantes.ReadOnly = true;
            this.dgvDatosEstudiantes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatosEstudiantes.Size = new System.Drawing.Size(655, 306);
            this.dgvDatosEstudiantes.TabIndex = 0;
            // 
            // ColNombre
            // 
            this.ColNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColNombre.HeaderText = "Nombre";
            this.ColNombre.Name = "ColNombre";
            this.ColNombre.ReadOnly = true;
            // 
            // ColApellido
            // 
            this.ColApellido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColApellido.HeaderText = "Apellido";
            this.ColApellido.Name = "ColApellido";
            this.ColApellido.ReadOnly = true;
            // 
            // ColEstado
            // 
            this.ColEstado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColEstado.HeaderText = "Estado";
            this.ColEstado.Name = "ColEstado";
            this.ColEstado.ReadOnly = true;
            // 
            // FrmInscripcionMaterias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(245)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(655, 375);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmInscripcionMaterias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmEstudiantes";
            this.Load += new System.EventHandler(this.FrmEstudianteMaterias_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvInscripcionMaterias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosEstudiantes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgvDatosEstudiantes;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEstado;
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
        private System.Windows.Forms.DataGridView dgvInscripcionMaterias;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsInscribir;
        private System.Windows.Forms.ToolStripButton tsBorrar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsCertificado;
        private System.Windows.Forms.ToolStripButton tsActualizar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsVolver;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripButton tsEditar;
        private System.Windows.Forms.ToolStripDropDownButton tsFiltrar;
        private System.Windows.Forms.ToolStripMenuItem añoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem erToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem erToolStripMenuItem1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColHorario;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColCondicionLibre;
    }
}