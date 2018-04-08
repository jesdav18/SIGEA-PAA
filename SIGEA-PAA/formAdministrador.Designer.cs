namespace SIGEA_PAA
{
    partial class formAdministrador
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
            this.components = new System.ComponentModel.Container();
<<<<<<< HEAD
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
=======
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Agregar Usuario");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Modificar Usuario");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Eliminar Usuario");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Administración de Usuarios", new System.Windows.Forms.TreeNode[] {
            treeNode11,
            treeNode12,
            treeNode13});
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Crear Prueba de Aptitud");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Ingresar Inscripciones");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Registrar Alumnos");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Ingresar Asistencia");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Seccion Reporteria");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Operaciones Equipo de Apoyo", new System.Windows.Forms.TreeNode[] {
            treeNode16,
            treeNode17,
            treeNode18,
            treeNode19});
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
>>>>>>> 57db4c3ebe0025b76cc2cb976a3e8c2d1aac3afc
            this.labelUsuario = new MetroFramework.Controls.MetroLabel();
            this.groupBoxOperaciones = new System.Windows.Forms.GroupBox();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.btnAdministrarEmpleados = new MetroFramework.Controls.MetroButton();
            this.btnBuscar = new MetroFramework.Controls.MetroButton();
            this.tabControlAdmonEmpleados = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage5 = new MetroFramework.Controls.MetroTabPage();
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.textBusquedaCodigoEmpleado = new System.Windows.Forms.TextBox();
            this.metroTabPage8 = new MetroFramework.Controls.MetroTabPage();
<<<<<<< HEAD
            this.metroButton6 = new MetroFramework.Controls.MetroButton();
=======
            this.sIGEAPAADataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this._SIGEA_PAA_Usuarios = new SIGEA_PAA._SIGEA_PAA_Usuarios();
            this.empleadosTableAdapter = new SIGEA_PAA._SIGEA_PAA_EmpleadosTableAdapters.EmpleadosTableAdapter();
            this.usuariosTableAdapter = new SIGEA_PAA._SIGEA_PAADataSet1TableAdapters.UsuariosTableAdapter();
>>>>>>> 57db4c3ebe0025b76cc2cb976a3e8c2d1aac3afc
            this.toolTipBusquedaEmpleado = new System.Windows.Forms.ToolTip(this.components);
            this.groupBoxInformacionEmpleado = new System.Windows.Forms.GroupBox();
            this.groupBoxInformacionUsuario = new System.Windows.Forms.GroupBox();
            this.gridInformacionEmpledo = new MetroFramework.Controls.MetroGrid();
            this.groupBoxOperaciones.SuspendLayout();
            this.tabControlAdmonEmpleados.SuspendLayout();
            this.metroTabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
            this.groupBoxInformacionEmpleado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridInformacionEmpledo)).BeginInit();
            this.SuspendLayout();
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelUsuario.Location = new System.Drawing.Point(20, 60);
            this.labelUsuario.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(81, 19);
            this.labelUsuario.TabIndex = 0;
            this.labelUsuario.Text = "labelUsuario";
            // 
            // groupBoxOperaciones
            // 
            this.groupBoxOperaciones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxOperaciones.Controls.Add(this.metroButton3);
            this.groupBoxOperaciones.Controls.Add(this.metroButton2);
<<<<<<< HEAD
            this.groupBoxOperaciones.Controls.Add(this.btnAdministrarEmpleados);
            this.groupBoxOperaciones.Location = new System.Drawing.Point(23, 128);
=======
            this.groupBoxOperaciones.Controls.Add(this.metroButton1);
            this.groupBoxOperaciones.Location = new System.Drawing.Point(23, 92);
>>>>>>> 57db4c3ebe0025b76cc2cb976a3e8c2d1aac3afc
            this.groupBoxOperaciones.Name = "groupBoxOperaciones";
            this.groupBoxOperaciones.Size = new System.Drawing.Size(239, 394);
            this.groupBoxOperaciones.TabIndex = 1;
            this.groupBoxOperaciones.TabStop = false;
            this.groupBoxOperaciones.Text = "Operaciones";
            // 
            // metroButton3
            // 
            this.metroButton3.Location = new System.Drawing.Point(17, 163);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(203, 23);
            this.metroButton3.TabIndex = 2;
            this.metroButton3.Text = "Operaciones Equipo de Apoyo";
            this.metroButton3.UseSelectable = true;
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(17, 125);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(203, 23);
            this.metroButton2.TabIndex = 1;
            this.metroButton2.Text = "Crear Prueba de Aptitud Académica";
            this.metroButton2.UseSelectable = true;
            // 
<<<<<<< HEAD
            // btnAdministrarEmpleados
            // 
            this.btnAdministrarEmpleados.Location = new System.Drawing.Point(17, 87);
            this.btnAdministrarEmpleados.Name = "btnAdministrarEmpleados";
            this.btnAdministrarEmpleados.Size = new System.Drawing.Size(203, 23);
            this.btnAdministrarEmpleados.TabIndex = 0;
            this.btnAdministrarEmpleados.Text = "Administración de Empleados";
            this.btnAdministrarEmpleados.UseSelectable = true;
            this.btnAdministrarEmpleados.Click += new System.EventHandler(this.btnAdministrarEmpleados_Click);
=======
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(17, 87);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(203, 23);
            this.metroButton1.TabIndex = 0;
            this.metroButton1.Text = "Administración de Empleados";
            this.metroButton1.UseSelectable = true;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(670, 6);
            this.treeView1.Name = "treeView1";
            treeNode11.Name = "agregarUsuario";
            treeNode11.Text = "Agregar Usuario";
            treeNode12.Name = "modificarUsuario";
            treeNode12.Text = "Modificar Usuario";
            treeNode13.Name = "eliminarUsuario";
            treeNode13.Text = "Eliminar Usuario";
            treeNode14.Name = "administracionUsuarios";
            treeNode14.Text = "Administración de Usuarios";
            treeNode15.Name = "crearPAA";
            treeNode15.Text = "Crear Prueba de Aptitud";
            treeNode16.Name = "ingresarInscripciones";
            treeNode16.Text = "Ingresar Inscripciones";
            treeNode17.Name = "registrarAlumnos";
            treeNode17.Text = "Registrar Alumnos";
            treeNode18.Name = "ingresoAsistencia";
            treeNode18.Text = "Ingresar Asistencia";
            treeNode19.Name = "reporteria";
            treeNode19.Text = "Seccion Reporteria";
            treeNode20.Name = "operacionesEquipoApoyo";
            treeNode20.Text = "Operaciones Equipo de Apoyo";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode14,
            treeNode15,
            treeNode20});
            this.treeView1.Size = new System.Drawing.Size(28, 29);
            this.treeView1.TabIndex = 2;
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage4);
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Location = new System.Drawing.Point(351, 28);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(66, 41);
            this.metroTabControl1.TabIndex = 3;
            this.metroTabControl1.Tag = "";
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage4
            // 
            this.metroTabPage4.Controls.Add(this.metroTabControl2);
            this.metroTabPage4.Controls.Add(this.btnBuscar);
            this.metroTabPage4.Controls.Add(this.metroLabel1);
            this.metroTabPage4.Controls.Add(this.textBox1);
            this.metroTabPage4.HorizontalScrollbarBarColor = true;
            this.metroTabPage4.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage4.HorizontalScrollbarSize = 10;
            this.metroTabPage4.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage4.Name = "metroTabPage4";
            this.metroTabPage4.Size = new System.Drawing.Size(58, 0);
            this.metroTabPage4.TabIndex = 3;
            this.metroTabPage4.Text = "Busqueda Empleado";
            this.metroTabPage4.VerticalScrollbarBarColor = true;
            this.metroTabPage4.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage4.VerticalScrollbarSize = 10;
            // 
            // metroTabControl2
            // 
            this.metroTabControl2.Controls.Add(this.metroTabPage2);
            this.metroTabControl2.Controls.Add(this.metroTabPage3);
            this.metroTabControl2.Location = new System.Drawing.Point(51, 49);
            this.metroTabControl2.Name = "metroTabControl2";
            this.metroTabControl2.SelectedIndex = 0;
            this.metroTabControl2.Size = new System.Drawing.Size(398, 124);
            this.metroTabControl2.TabIndex = 5;
            this.metroTabControl2.UseSelectable = true;
            this.metroTabControl2.SelectedIndexChanged += new System.EventHandler(this.metroTabControl2_SelectedIndexChanged);
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.metroButton4);
            this.metroTabPage2.Controls.Add(this.metroGrid1);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(390, 82);
            this.metroTabPage2.TabIndex = 0;
            this.metroTabPage2.Text = "Modificar";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // metroButton4
            // 
            this.metroButton4.Location = new System.Drawing.Point(0, 56);
            this.metroButton4.Name = "metroButton4";
            this.metroButton4.Size = new System.Drawing.Size(394, 23);
            this.metroButton4.TabIndex = 5;
            this.metroButton4.Text = "metroButton4";
            this.metroButton4.UseSelectable = true;
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle11;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(-27, 3);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(433, 58);
            this.metroGrid1.TabIndex = 2;
            // 
            // metroTabPage3
            // 
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.HorizontalScrollbarSize = 10;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(390, 82);
            this.metroTabPage3.TabIndex = 1;
            this.metroTabPage3.Text = "Eliminar";
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            this.metroTabPage3.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.VerticalScrollbarSize = 10;
            this.metroTabPage3.Click += new System.EventHandler(this.metroTabPage3_Click);
>>>>>>> 57db4c3ebe0025b76cc2cb976a3e8c2d1aac3afc
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(294, 16);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(100, 23);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseSelectable = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // tabControlAdmonEmpleados
            // 
            this.tabControlAdmonEmpleados.Controls.Add(this.metroTabPage5);
            this.tabControlAdmonEmpleados.Controls.Add(this.metroTabPage8);
            this.tabControlAdmonEmpleados.Location = new System.Drawing.Point(300, 111);
            this.tabControlAdmonEmpleados.Name = "tabControlAdmonEmpleados";
            this.tabControlAdmonEmpleados.SelectedIndex = 0;
            this.tabControlAdmonEmpleados.Size = new System.Drawing.Size(884, 494);
            this.tabControlAdmonEmpleados.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControlAdmonEmpleados.TabIndex = 5;
            this.tabControlAdmonEmpleados.Tag = "";
            this.tabControlAdmonEmpleados.UseSelectable = true;
            this.tabControlAdmonEmpleados.Visible = false;
            // 
            // metroTabPage5
            // 
            this.metroTabPage5.Controls.Add(this.groupBoxInformacionUsuario);
            this.metroTabPage5.Controls.Add(this.groupBoxInformacionEmpleado);
            this.metroTabPage5.Controls.Add(this.btnBuscar);
            this.metroTabPage5.Controls.Add(this.metroLabel2);
            this.metroTabPage5.Controls.Add(this.textBusquedaCodigoEmpleado);
            this.metroTabPage5.HorizontalScrollbarBarColor = true;
            this.metroTabPage5.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage5.HorizontalScrollbarSize = 10;
            this.metroTabPage5.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage5.Name = "metroTabPage5";
            this.metroTabPage5.Size = new System.Drawing.Size(876, 452);
            this.metroTabPage5.TabIndex = 3;
            this.metroTabPage5.Text = "Busqueda Empleado";
            this.metroTabPage5.VerticalScrollbarBarColor = true;
            this.metroTabPage5.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage5.VerticalScrollbarSize = 10;
            // 
<<<<<<< HEAD
=======
            // metroTabControl4
            // 
            this.metroTabControl4.Controls.Add(this.metroTabPage6);
            this.metroTabControl4.Controls.Add(this.metroTabPage7);
            this.metroTabControl4.Location = new System.Drawing.Point(3, 49);
            this.metroTabControl4.Name = "metroTabControl4";
            this.metroTabControl4.SelectedIndex = 0;
            this.metroTabControl4.Size = new System.Drawing.Size(873, 296);
            this.metroTabControl4.TabIndex = 5;
            this.metroTabControl4.UseSelectable = true;
            // 
            // metroTabPage6
            // 
            this.metroTabPage6.Controls.Add(this.metroGrid2);
            this.metroTabPage6.Controls.Add(this.metroGrid3);
            this.metroTabPage6.HorizontalScrollbarBarColor = true;
            this.metroTabPage6.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage6.HorizontalScrollbarSize = 10;
            this.metroTabPage6.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage6.Name = "metroTabPage6";
            this.metroTabPage6.Size = new System.Drawing.Size(865, 254);
            this.metroTabPage6.TabIndex = 0;
            this.metroTabPage6.Text = "Modificar";
            this.metroTabPage6.VerticalScrollbarBarColor = true;
            this.metroTabPage6.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage6.VerticalScrollbarSize = 10;
            // 
            // metroGrid2
            // 
            this.metroGrid2.AllowUserToDeleteRows = false;
            this.metroGrid2.AllowUserToResizeRows = false;
            this.metroGrid2.AutoGenerateColumns = false;
            this.metroGrid2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.metroGrid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGrid2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoEmpleadoDataGridViewTextBoxColumn,
            this.nombreEmpleadoDataGridViewTextBoxColumn,
            this.identidadEmpleadoDataGridViewTextBoxColumn,
            this.estadoEmpleadoDataGridViewCheckBoxColumn});
            this.metroGrid2.DataSource = this.empleadosBindingSource;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid2.DefaultCellStyle = dataGridViewCellStyle14;
            this.metroGrid2.EnableHeadersVisualStyles = false;
            this.metroGrid2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid2.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid2.Location = new System.Drawing.Point(4, 4);
            this.metroGrid2.Name = "metroGrid2";
            this.metroGrid2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid2.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.metroGrid2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid2.Size = new System.Drawing.Size(449, 254);
            this.metroGrid2.TabIndex = 2;
            // 
            // codigoEmpleadoDataGridViewTextBoxColumn
            // 
            this.codigoEmpleadoDataGridViewTextBoxColumn.DataPropertyName = "codigoEmpleado";
            this.codigoEmpleadoDataGridViewTextBoxColumn.HeaderText = "codigoEmpleado";
            this.codigoEmpleadoDataGridViewTextBoxColumn.Name = "codigoEmpleadoDataGridViewTextBoxColumn";
            // 
            // nombreEmpleadoDataGridViewTextBoxColumn
            // 
            this.nombreEmpleadoDataGridViewTextBoxColumn.DataPropertyName = "nombreEmpleado";
            this.nombreEmpleadoDataGridViewTextBoxColumn.HeaderText = "nombreEmpleado";
            this.nombreEmpleadoDataGridViewTextBoxColumn.Name = "nombreEmpleadoDataGridViewTextBoxColumn";
            // 
            // identidadEmpleadoDataGridViewTextBoxColumn
            // 
            this.identidadEmpleadoDataGridViewTextBoxColumn.DataPropertyName = "identidadEmpleado";
            this.identidadEmpleadoDataGridViewTextBoxColumn.HeaderText = "identidadEmpleado";
            this.identidadEmpleadoDataGridViewTextBoxColumn.Name = "identidadEmpleadoDataGridViewTextBoxColumn";
            // 
            // estadoEmpleadoDataGridViewCheckBoxColumn
            // 
            this.estadoEmpleadoDataGridViewCheckBoxColumn.DataPropertyName = "estadoEmpleado";
            this.estadoEmpleadoDataGridViewCheckBoxColumn.HeaderText = "estadoEmpleado";
            this.estadoEmpleadoDataGridViewCheckBoxColumn.Name = "estadoEmpleadoDataGridViewCheckBoxColumn";
            // 
            // empleadosBindingSource
            // 
            this.empleadosBindingSource.DataMember = "Empleados";
            this.empleadosBindingSource.DataSource = this._SIGEA_PAA_Empleados;
            // 
            // _SIGEA_PAA_Empleados
            // 
            this._SIGEA_PAA_Empleados.DataSetName = "_SIGEA_PAA_Empleados";
            this._SIGEA_PAA_Empleados.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // metroGrid3
            // 
            this.metroGrid3.AllowUserToResizeRows = false;
            this.metroGrid3.AutoGenerateColumns = false;
            this.metroGrid3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid3.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid3.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid3.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.metroGrid3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGrid3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoUsuarioDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.codigoEmpleadoDataGridViewTextBoxColumn1,
            this.codigoTipoAccesoDataGridViewTextBoxColumn});
            this.metroGrid3.DataSource = this.usuariosBindingSource;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid3.DefaultCellStyle = dataGridViewCellStyle17;
            this.metroGrid3.EnableHeadersVisualStyles = false;
            this.metroGrid3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid3.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid3.Location = new System.Drawing.Point(539, 3);
            this.metroGrid3.Name = "metroGrid3";
            this.metroGrid3.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid3.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.metroGrid3.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid3.Size = new System.Drawing.Size(482, 113);
            this.metroGrid3.TabIndex = 6;
            // 
            // codigoUsuarioDataGridViewTextBoxColumn
            // 
            this.codigoUsuarioDataGridViewTextBoxColumn.DataPropertyName = "codigoUsuario";
            this.codigoUsuarioDataGridViewTextBoxColumn.HeaderText = "codigoUsuario";
            this.codigoUsuarioDataGridViewTextBoxColumn.Name = "codigoUsuarioDataGridViewTextBoxColumn";
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            // 
            // codigoEmpleadoDataGridViewTextBoxColumn1
            // 
            this.codigoEmpleadoDataGridViewTextBoxColumn1.DataPropertyName = "codigoEmpleado";
            this.codigoEmpleadoDataGridViewTextBoxColumn1.HeaderText = "codigoEmpleado";
            this.codigoEmpleadoDataGridViewTextBoxColumn1.Name = "codigoEmpleadoDataGridViewTextBoxColumn1";
            // 
            // codigoTipoAccesoDataGridViewTextBoxColumn
            // 
            this.codigoTipoAccesoDataGridViewTextBoxColumn.DataPropertyName = "codigoTipoAcceso";
            this.codigoTipoAccesoDataGridViewTextBoxColumn.HeaderText = "codigoTipoAcceso";
            this.codigoTipoAccesoDataGridViewTextBoxColumn.Name = "codigoTipoAccesoDataGridViewTextBoxColumn";
            // 
            // usuariosBindingSource
            // 
            this.usuariosBindingSource.DataMember = "Usuarios";
            this.usuariosBindingSource.DataSource = this._SIGEA_PAADataSet1;
            // 
            // _SIGEA_PAADataSet1
            // 
            this._SIGEA_PAADataSet1.DataSetName = "_SIGEA_PAADataSet1";
            this._SIGEA_PAADataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // metroTabPage7
            // 
            this.metroTabPage7.HorizontalScrollbarBarColor = true;
            this.metroTabPage7.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage7.HorizontalScrollbarSize = 10;
            this.metroTabPage7.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage7.Name = "metroTabPage7";
            this.metroTabPage7.Size = new System.Drawing.Size(865, 254);
            this.metroTabPage7.TabIndex = 1;
            this.metroTabPage7.Text = "Eliminar";
            this.metroTabPage7.VerticalScrollbarBarColor = true;
            this.metroTabPage7.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage7.VerticalScrollbarSize = 10;
            // 
            // metroButton7
            // 
            this.metroButton7.Location = new System.Drawing.Point(283, 20);
            this.metroButton7.Name = "metroButton7";
            this.metroButton7.Size = new System.Drawing.Size(100, 23);
            this.metroButton7.TabIndex = 4;
            this.metroButton7.Text = "Buscar";
            this.toolTipBusquedaEmpleado.SetToolTip(this.metroButton7, "Ingrese el Código de Empleado para comprobar su existencia en el sistema.");
            this.metroButton7.UseSelectable = true;
            // 
>>>>>>> 57db4c3ebe0025b76cc2cb976a3e8c2d1aac3afc
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(3, 20);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(143, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Código de Empleado: ";
            // 
            // textBusquedaCodigoEmpleado
            // 
            this.textBusquedaCodigoEmpleado.Location = new System.Drawing.Point(168, 19);
            this.textBusquedaCodigoEmpleado.Name = "textBusquedaCodigoEmpleado";
            this.textBusquedaCodigoEmpleado.Size = new System.Drawing.Size(100, 20);
            this.textBusquedaCodigoEmpleado.TabIndex = 2;
            // 
            // metroTabPage8
            // 
            this.metroTabPage8.HorizontalScrollbarBarColor = true;
            this.metroTabPage8.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage8.HorizontalScrollbarSize = 10;
            this.metroTabPage8.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage8.Name = "metroTabPage8";
            this.metroTabPage8.Size = new System.Drawing.Size(876, 348);
            this.metroTabPage8.TabIndex = 0;
            this.metroTabPage8.Text = "Agregar Empleado";
            this.metroTabPage8.VerticalScrollbarBarColor = true;
            this.metroTabPage8.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage8.VerticalScrollbarSize = 10;
            // 
<<<<<<< HEAD
            // metroButton6
            // 
            this.metroButton6.Location = new System.Drawing.Point(118, 410);
            this.metroButton6.Name = "metroButton6";
            this.metroButton6.Size = new System.Drawing.Size(113, 23);
            this.metroButton6.TabIndex = 5;
            this.metroButton6.Text = "metroButton6";
            this.metroButton6.UseSelectable = true;
=======
            // _SIGEA_PAA_Usuarios
            // 
            this._SIGEA_PAA_Usuarios.DataSetName = "_SIGEA_PAA_Usuarios";
            this._SIGEA_PAA_Usuarios.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // empleadosTableAdapter
            // 
            this.empleadosTableAdapter.ClearBeforeFill = true;
            // 
            // usuariosTableAdapter
            // 
            this.usuariosTableAdapter.ClearBeforeFill = true;
>>>>>>> 57db4c3ebe0025b76cc2cb976a3e8c2d1aac3afc
            // 
            // toolTipBusquedaEmpleado
            // 
            this.toolTipBusquedaEmpleado.Tag = "";
            // 
            // groupBoxInformacionEmpleado
            // 
            this.groupBoxInformacionEmpleado.BackColor = System.Drawing.Color.White;
            this.groupBoxInformacionEmpleado.Controls.Add(this.gridInformacionEmpledo);
            this.groupBoxInformacionEmpleado.Location = new System.Drawing.Point(3, 65);
            this.groupBoxInformacionEmpleado.Name = "groupBoxInformacionEmpleado";
            this.groupBoxInformacionEmpleado.Size = new System.Drawing.Size(870, 185);
            this.groupBoxInformacionEmpleado.TabIndex = 5;
            this.groupBoxInformacionEmpleado.TabStop = false;
            this.groupBoxInformacionEmpleado.Text = "Información de Empleado";
            // 
            // groupBoxInformacionUsuario
            // 
            this.groupBoxInformacionUsuario.BackColor = System.Drawing.Color.White;
            this.groupBoxInformacionUsuario.Location = new System.Drawing.Point(3, 256);
            this.groupBoxInformacionUsuario.Name = "groupBoxInformacionUsuario";
            this.groupBoxInformacionUsuario.Size = new System.Drawing.Size(870, 142);
            this.groupBoxInformacionUsuario.TabIndex = 6;
            this.groupBoxInformacionUsuario.TabStop = false;
            this.groupBoxInformacionUsuario.Text = "Información de Usuario";
            // 
            // gridInformacionEmpledo
            // 
            this.gridInformacionEmpledo.AllowUserToResizeRows = false;
            this.gridInformacionEmpledo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridInformacionEmpledo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridInformacionEmpledo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridInformacionEmpledo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridInformacionEmpledo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridInformacionEmpledo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridInformacionEmpledo.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridInformacionEmpledo.EnableHeadersVisualStyles = false;
            this.gridInformacionEmpledo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridInformacionEmpledo.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridInformacionEmpledo.Location = new System.Drawing.Point(25, 19);
            this.gridInformacionEmpledo.Name = "gridInformacionEmpledo";
            this.gridInformacionEmpledo.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridInformacionEmpledo.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridInformacionEmpledo.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridInformacionEmpledo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridInformacionEmpledo.Size = new System.Drawing.Size(739, 150);
            this.gridInformacionEmpledo.TabIndex = 0;
            // 
            // formAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
<<<<<<< HEAD
            this.ClientSize = new System.Drawing.Size(1235, 675);
            this.Controls.Add(this.tabControlAdmonEmpleados);
            this.Controls.Add(this.metroButton6);
=======
            this.ClientSize = new System.Drawing.Size(1235, 509);
            this.Controls.Add(this.metroTabControl3);
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this.treeView1);
>>>>>>> 57db4c3ebe0025b76cc2cb976a3e8c2d1aac3afc
            this.Controls.Add(this.groupBoxOperaciones);
            this.Controls.Add(this.labelUsuario);
            this.MaximizeBox = false;
            this.Movable = false;
            this.Name = "formAdministrador";
            this.Resizable = false;
            this.Text = "SIGEA-PAA | Administrador";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.formAdministrador_Load);
            this.groupBoxOperaciones.ResumeLayout(false);
            this.tabControlAdmonEmpleados.ResumeLayout(false);
            this.metroTabPage5.ResumeLayout(false);
            this.metroTabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
            this.groupBoxInformacionEmpleado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridInformacionEmpledo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private MetroFramework.Controls.MetroLabel labelUsuario;
        private System.Windows.Forms.GroupBox groupBoxOperaciones;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton btnAdministrarEmpleados;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroButton btnBuscar;
        private MetroFramework.Controls.MetroTabControl tabControlAdmonEmpleados;
        private MetroFramework.Controls.MetroTabPage metroTabPage5;
<<<<<<< HEAD
        private MetroFramework.Controls.MetroButton metroButton6;
=======
        private MetroFramework.Controls.MetroGrid metroGrid3;
        private MetroFramework.Controls.MetroTabControl metroTabControl4;
        private MetroFramework.Controls.MetroTabPage metroTabPage6;
        private MetroFramework.Controls.MetroTabPage metroTabPage7;
        private MetroFramework.Controls.MetroButton metroButton7;
>>>>>>> 57db4c3ebe0025b76cc2cb976a3e8c2d1aac3afc
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.TextBox textBusquedaCodigoEmpleado;
        private MetroFramework.Controls.MetroTabPage metroTabPage8;
        private System.Windows.Forms.BindingSource usuariosBindingSource;
        private System.Windows.Forms.ToolTip toolTipBusquedaEmpleado;
        private System.Windows.Forms.GroupBox groupBoxInformacionUsuario;
        private System.Windows.Forms.GroupBox groupBoxInformacionEmpleado;
        private MetroFramework.Controls.MetroGrid gridInformacionEmpledo;
    }
}

