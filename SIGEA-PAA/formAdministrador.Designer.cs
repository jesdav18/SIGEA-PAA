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
            this.labelUsuario = new MetroFramework.Controls.MetroLabel();
            this.groupBoxOperaciones = new System.Windows.Forms.GroupBox();
            this.btnOperacionesEquipoApoyo = new MetroFramework.Controls.MetroButton();
            this.btnCrearPaa = new MetroFramework.Controls.MetroButton();
            this.btnAdministrarEmpleados = new MetroFramework.Controls.MetroButton();
            this.btnBuscar = new MetroFramework.Controls.MetroButton();
            this.tabControlAdmonEmpleados = new MetroFramework.Controls.MetroTabControl();
            this.tabPageBusquedaEmpleado = new MetroFramework.Controls.MetroTabPage();
            this.groupBoxBuscarPor = new System.Windows.Forms.GroupBox();
            this.radioNombreEmpleado = new MetroFramework.Controls.MetroRadioButton();
            this.radioCodigoEmpleado = new MetroFramework.Controls.MetroRadioButton();
            this.textBusquedaEmpleado = new System.Windows.Forms.TextBox();
            this.tabPageAgregarEmpleado = new MetroFramework.Controls.MetroTabPage();
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolTipBusquedaEmpleado = new System.Windows.Forms.ToolTip(this.components);
            this.metroTituloInformacionEmpleado = new MetroFramework.Controls.MetroLabel();
            this.textBoxNombreUsuario = new MetroFramework.Controls.MetroTextBox();
            this.labelNombreEmpleado = new MetroFramework.Controls.MetroLabel();
            this.labelCodigoEmpleado = new MetroFramework.Controls.MetroLabel();
            this.labelIdentidad = new MetroFramework.Controls.MetroLabel();
            this.labelCodigoUsuario = new MetroFramework.Controls.MetroLabel();
            this.labelTipoAcceso = new MetroFramework.Controls.MetroLabel();
            this.textBoxCódigoEmpleado = new MetroFramework.Controls.MetroTextBox();
            this.textBoxIdentidad = new MetroFramework.Controls.MetroTextBox();
            this.textBoxUsuario = new MetroFramework.Controls.MetroTextBox();
            this.textBoxTipoAcceso = new MetroFramework.Controls.MetroTextBox();
            this.groupBoxOperaciones.SuspendLayout();
            this.tabControlAdmonEmpleados.SuspendLayout();
            this.tabPageBusquedaEmpleado.SuspendLayout();
            this.groupBoxBuscarPor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
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
            this.groupBoxOperaciones.Controls.Add(this.btnOperacionesEquipoApoyo);
            this.groupBoxOperaciones.Controls.Add(this.btnCrearPaa);
            this.groupBoxOperaciones.Controls.Add(this.btnAdministrarEmpleados);
            this.groupBoxOperaciones.Location = new System.Drawing.Point(23, 92);
            this.groupBoxOperaciones.Name = "groupBoxOperaciones";
            this.groupBoxOperaciones.Size = new System.Drawing.Size(239, 465);
            this.groupBoxOperaciones.TabIndex = 1;
            this.groupBoxOperaciones.TabStop = false;
            this.groupBoxOperaciones.Text = "Operaciones";
            // 
            // btnOperacionesEquipoApoyo
            // 
            this.btnOperacionesEquipoApoyo.Location = new System.Drawing.Point(17, 163);
            this.btnOperacionesEquipoApoyo.Name = "btnOperacionesEquipoApoyo";
            this.btnOperacionesEquipoApoyo.Size = new System.Drawing.Size(203, 23);
            this.btnOperacionesEquipoApoyo.TabIndex = 2;
            this.btnOperacionesEquipoApoyo.Text = "Operaciones Equipo de Apoyo";
            this.btnOperacionesEquipoApoyo.UseSelectable = true;
            // 
            // btnCrearPaa
            // 
            this.btnCrearPaa.Location = new System.Drawing.Point(17, 125);
            this.btnCrearPaa.Name = "btnCrearPaa";
            this.btnCrearPaa.Size = new System.Drawing.Size(203, 23);
            this.btnCrearPaa.TabIndex = 1;
            this.btnCrearPaa.Text = "Crear Prueba de Aptitud Académica";
            this.btnCrearPaa.UseSelectable = true;
            // 
            // btnAdministrarEmpleados
            // 
            this.btnAdministrarEmpleados.Location = new System.Drawing.Point(17, 87);
            this.btnAdministrarEmpleados.Name = "btnAdministrarEmpleados";
            this.btnAdministrarEmpleados.Size = new System.Drawing.Size(203, 23);
            this.btnAdministrarEmpleados.TabIndex = 0;
            this.btnAdministrarEmpleados.Text = "Administración de Empleados";
            this.btnAdministrarEmpleados.UseSelectable = true;
            this.btnAdministrarEmpleados.Click += new System.EventHandler(this.btnAdministrarEmpleados_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(147, 100);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(269, 23);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseSelectable = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // tabControlAdmonEmpleados
            // 
            this.tabControlAdmonEmpleados.Controls.Add(this.tabPageBusquedaEmpleado);
            this.tabControlAdmonEmpleados.Controls.Add(this.tabPageAgregarEmpleado);
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
            // tabPageBusquedaEmpleado
            // 
            this.tabPageBusquedaEmpleado.Controls.Add(this.textBoxTipoAcceso);
            this.tabPageBusquedaEmpleado.Controls.Add(this.textBoxUsuario);
            this.tabPageBusquedaEmpleado.Controls.Add(this.textBoxIdentidad);
            this.tabPageBusquedaEmpleado.Controls.Add(this.textBoxCódigoEmpleado);
            this.tabPageBusquedaEmpleado.Controls.Add(this.labelTipoAcceso);
            this.tabPageBusquedaEmpleado.Controls.Add(this.labelCodigoUsuario);
            this.tabPageBusquedaEmpleado.Controls.Add(this.labelIdentidad);
            this.tabPageBusquedaEmpleado.Controls.Add(this.labelCodigoEmpleado);
            this.tabPageBusquedaEmpleado.Controls.Add(this.labelNombreEmpleado);
            this.tabPageBusquedaEmpleado.Controls.Add(this.textBoxNombreUsuario);
            this.tabPageBusquedaEmpleado.Controls.Add(this.metroTituloInformacionEmpleado);
            this.tabPageBusquedaEmpleado.Controls.Add(this.groupBoxBuscarPor);
            this.tabPageBusquedaEmpleado.HorizontalScrollbarBarColor = true;
            this.tabPageBusquedaEmpleado.HorizontalScrollbarHighlightOnWheel = false;
            this.tabPageBusquedaEmpleado.HorizontalScrollbarSize = 10;
            this.tabPageBusquedaEmpleado.Location = new System.Drawing.Point(4, 38);
            this.tabPageBusquedaEmpleado.Name = "tabPageBusquedaEmpleado";
            this.tabPageBusquedaEmpleado.Size = new System.Drawing.Size(876, 452);
            this.tabPageBusquedaEmpleado.TabIndex = 3;
            this.tabPageBusquedaEmpleado.Text = "Busqueda de Empleado";
            this.tabPageBusquedaEmpleado.VerticalScrollbarBarColor = true;
            this.tabPageBusquedaEmpleado.VerticalScrollbarHighlightOnWheel = false;
            this.tabPageBusquedaEmpleado.VerticalScrollbarSize = 10;
            // 
            // groupBoxBuscarPor
            // 
            this.groupBoxBuscarPor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxBuscarPor.BackColor = System.Drawing.Color.White;
            this.groupBoxBuscarPor.Controls.Add(this.radioNombreEmpleado);
            this.groupBoxBuscarPor.Controls.Add(this.radioCodigoEmpleado);
            this.groupBoxBuscarPor.Controls.Add(this.textBusquedaEmpleado);
            this.groupBoxBuscarPor.Controls.Add(this.btnBuscar);
            this.groupBoxBuscarPor.Location = new System.Drawing.Point(36, 15);
            this.groupBoxBuscarPor.Name = "groupBoxBuscarPor";
            this.groupBoxBuscarPor.Size = new System.Drawing.Size(573, 159);
            this.groupBoxBuscarPor.TabIndex = 9;
            this.groupBoxBuscarPor.TabStop = false;
            this.groupBoxBuscarPor.Text = "Buscar Empleado por:";
            // 
            // radioNombreEmpleado
            // 
            this.radioNombreEmpleado.AutoSize = true;
            this.radioNombreEmpleado.Location = new System.Drawing.Point(296, 38);
            this.radioNombreEmpleado.Name = "radioNombreEmpleado";
            this.radioNombreEmpleado.Size = new System.Drawing.Size(139, 15);
            this.radioNombreEmpleado.TabIndex = 6;
            this.radioNombreEmpleado.Text = "Nombre de Empleado";
            this.radioNombreEmpleado.UseSelectable = true;
            // 
            // radioCodigoEmpleado
            // 
            this.radioCodigoEmpleado.AutoSize = true;
            this.radioCodigoEmpleado.Location = new System.Drawing.Point(134, 38);
            this.radioCodigoEmpleado.Name = "radioCodigoEmpleado";
            this.radioCodigoEmpleado.Size = new System.Drawing.Size(134, 15);
            this.radioCodigoEmpleado.TabIndex = 5;
            this.radioCodigoEmpleado.Text = "Código de Empleado";
            this.radioCodigoEmpleado.UseSelectable = true;
            // 
            // textBusquedaEmpleado
            // 
            this.textBusquedaEmpleado.Location = new System.Drawing.Point(118, 64);
            this.textBusquedaEmpleado.Name = "textBusquedaEmpleado";
            this.textBusquedaEmpleado.Size = new System.Drawing.Size(326, 20);
            this.textBusquedaEmpleado.TabIndex = 2;
            this.toolTipBusquedaEmpleado.SetToolTip(this.textBusquedaEmpleado, "Ingrese Aquí la información del Empleado que busca. Puede ser sú código de emplea" +
        "do o su nombre.");
            this.textBusquedaEmpleado.TextChanged += new System.EventHandler(this.textBusquedaCodigoEmpleado_TextChanged);
            // 
            // tabPageAgregarEmpleado
            // 
            this.tabPageAgregarEmpleado.HorizontalScrollbarBarColor = true;
            this.tabPageAgregarEmpleado.HorizontalScrollbarHighlightOnWheel = false;
            this.tabPageAgregarEmpleado.HorizontalScrollbarSize = 10;
            this.tabPageAgregarEmpleado.Location = new System.Drawing.Point(4, 38);
            this.tabPageAgregarEmpleado.Name = "tabPageAgregarEmpleado";
            this.tabPageAgregarEmpleado.Size = new System.Drawing.Size(876, 452);
            this.tabPageAgregarEmpleado.TabIndex = 0;
            this.tabPageAgregarEmpleado.Text = "Agregar Empleado";
            this.tabPageAgregarEmpleado.VerticalScrollbarBarColor = true;
            this.tabPageAgregarEmpleado.VerticalScrollbarHighlightOnWheel = false;
            this.tabPageAgregarEmpleado.VerticalScrollbarSize = 10;
            // 
            // toolTipBusquedaEmpleado
            // 
            this.toolTipBusquedaEmpleado.AutomaticDelay = 100;
            this.toolTipBusquedaEmpleado.Tag = "";
            // 
            // metroTituloInformacionEmpleado
            // 
            this.metroTituloInformacionEmpleado.AutoSize = true;
            this.metroTituloInformacionEmpleado.Location = new System.Drawing.Point(255, 187);
            this.metroTituloInformacionEmpleado.Name = "metroTituloInformacionEmpleado";
            this.metroTituloInformacionEmpleado.Size = new System.Drawing.Size(162, 19);
            this.metroTituloInformacionEmpleado.TabIndex = 11;
            this.metroTituloInformacionEmpleado.Text = "Información de Empleado";
            // 
            // textBoxNombreUsuario
            // 
            // 
            // 
            // 
            this.textBoxNombreUsuario.CustomButton.Image = null;
            this.textBoxNombreUsuario.CustomButton.Location = new System.Drawing.Point(313, 1);
            this.textBoxNombreUsuario.CustomButton.Name = "";
            this.textBoxNombreUsuario.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textBoxNombreUsuario.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBoxNombreUsuario.CustomButton.TabIndex = 1;
            this.textBoxNombreUsuario.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBoxNombreUsuario.CustomButton.UseSelectable = true;
            this.textBoxNombreUsuario.CustomButton.Visible = false;
            this.textBoxNombreUsuario.Lines = new string[0];
            this.textBoxNombreUsuario.Location = new System.Drawing.Point(255, 256);
            this.textBoxNombreUsuario.MaxLength = 32767;
            this.textBoxNombreUsuario.Name = "textBoxNombreUsuario";
            this.textBoxNombreUsuario.PasswordChar = '\0';
            this.textBoxNombreUsuario.ReadOnly = true;
            this.textBoxNombreUsuario.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxNombreUsuario.SelectedText = "";
            this.textBoxNombreUsuario.SelectionLength = 0;
            this.textBoxNombreUsuario.SelectionStart = 0;
            this.textBoxNombreUsuario.ShortcutsEnabled = true;
            this.textBoxNombreUsuario.Size = new System.Drawing.Size(335, 23);
            this.textBoxNombreUsuario.TabIndex = 12;
            this.textBoxNombreUsuario.UseSelectable = true;
            this.textBoxNombreUsuario.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBoxNombreUsuario.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // labelNombreEmpleado
            // 
            this.labelNombreEmpleado.AutoSize = true;
            this.labelNombreEmpleado.Location = new System.Drawing.Point(93, 260);
            this.labelNombreEmpleado.Name = "labelNombreEmpleado";
            this.labelNombreEmpleado.Size = new System.Drawing.Size(59, 19);
            this.labelNombreEmpleado.TabIndex = 13;
            this.labelNombreEmpleado.Text = "Nombre";
            // 
            // labelCodigoEmpleado
            // 
            this.labelCodigoEmpleado.AutoSize = true;
            this.labelCodigoEmpleado.Location = new System.Drawing.Point(93, 231);
            this.labelCodigoEmpleado.Name = "labelCodigoEmpleado";
            this.labelCodigoEmpleado.Size = new System.Drawing.Size(136, 19);
            this.labelCodigoEmpleado.TabIndex = 14;
            this.labelCodigoEmpleado.Text = "Código de Empleado";
            // 
            // labelIdentidad
            // 
            this.labelIdentidad.AutoSize = true;
            this.labelIdentidad.Location = new System.Drawing.Point(93, 291);
            this.labelIdentidad.Name = "labelIdentidad";
            this.labelIdentidad.Size = new System.Drawing.Size(64, 19);
            this.labelIdentidad.TabIndex = 15;
            this.labelIdentidad.Text = "Identidad";
            // 
            // labelCodigoUsuario
            // 
            this.labelCodigoUsuario.AutoSize = true;
            this.labelCodigoUsuario.Location = new System.Drawing.Point(93, 324);
            this.labelCodigoUsuario.Name = "labelCodigoUsuario";
            this.labelCodigoUsuario.Size = new System.Drawing.Size(53, 19);
            this.labelCodigoUsuario.TabIndex = 16;
            this.labelCodigoUsuario.Text = "Usuario";
            // 
            // labelTipoAcceso
            // 
            this.labelTipoAcceso.AutoSize = true;
            this.labelTipoAcceso.Location = new System.Drawing.Point(93, 358);
            this.labelTipoAcceso.Name = "labelTipoAcceso";
            this.labelTipoAcceso.Size = new System.Drawing.Size(99, 19);
            this.labelTipoAcceso.TabIndex = 17;
            this.labelTipoAcceso.Text = "Tipo de Acceso";
            // 
            // textBoxCódigoEmpleado
            // 
            // 
            // 
            // 
            this.textBoxCódigoEmpleado.CustomButton.Image = null;
            this.textBoxCódigoEmpleado.CustomButton.Location = new System.Drawing.Point(82, 1);
            this.textBoxCódigoEmpleado.CustomButton.Name = "";
            this.textBoxCódigoEmpleado.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textBoxCódigoEmpleado.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBoxCódigoEmpleado.CustomButton.TabIndex = 1;
            this.textBoxCódigoEmpleado.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBoxCódigoEmpleado.CustomButton.UseSelectable = true;
            this.textBoxCódigoEmpleado.CustomButton.Visible = false;
            this.textBoxCódigoEmpleado.Lines = new string[0];
            this.textBoxCódigoEmpleado.Location = new System.Drawing.Point(255, 227);
            this.textBoxCódigoEmpleado.MaxLength = 32767;
            this.textBoxCódigoEmpleado.Name = "textBoxCódigoEmpleado";
            this.textBoxCódigoEmpleado.PasswordChar = '\0';
            this.textBoxCódigoEmpleado.ReadOnly = true;
            this.textBoxCódigoEmpleado.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxCódigoEmpleado.SelectedText = "";
            this.textBoxCódigoEmpleado.SelectionLength = 0;
            this.textBoxCódigoEmpleado.SelectionStart = 0;
            this.textBoxCódigoEmpleado.ShortcutsEnabled = true;
            this.textBoxCódigoEmpleado.Size = new System.Drawing.Size(104, 23);
            this.textBoxCódigoEmpleado.TabIndex = 18;
            this.textBoxCódigoEmpleado.UseSelectable = true;
            this.textBoxCódigoEmpleado.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBoxCódigoEmpleado.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // textBoxIdentidad
            // 
            // 
            // 
            // 
            this.textBoxIdentidad.CustomButton.Image = null;
            this.textBoxIdentidad.CustomButton.Location = new System.Drawing.Point(82, 1);
            this.textBoxIdentidad.CustomButton.Name = "";
            this.textBoxIdentidad.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textBoxIdentidad.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBoxIdentidad.CustomButton.TabIndex = 1;
            this.textBoxIdentidad.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBoxIdentidad.CustomButton.UseSelectable = true;
            this.textBoxIdentidad.CustomButton.Visible = false;
            this.textBoxIdentidad.Lines = new string[0];
            this.textBoxIdentidad.Location = new System.Drawing.Point(255, 287);
            this.textBoxIdentidad.MaxLength = 32767;
            this.textBoxIdentidad.Name = "textBoxIdentidad";
            this.textBoxIdentidad.PasswordChar = '\0';
            this.textBoxIdentidad.ReadOnly = true;
            this.textBoxIdentidad.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxIdentidad.SelectedText = "";
            this.textBoxIdentidad.SelectionLength = 0;
            this.textBoxIdentidad.SelectionStart = 0;
            this.textBoxIdentidad.ShortcutsEnabled = true;
            this.textBoxIdentidad.Size = new System.Drawing.Size(104, 23);
            this.textBoxIdentidad.TabIndex = 19;
            this.textBoxIdentidad.UseSelectable = true;
            this.textBoxIdentidad.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBoxIdentidad.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // textBoxUsuario
            // 
            // 
            // 
            // 
            this.textBoxUsuario.CustomButton.Image = null;
            this.textBoxUsuario.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.textBoxUsuario.CustomButton.Name = "";
            this.textBoxUsuario.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textBoxUsuario.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBoxUsuario.CustomButton.TabIndex = 1;
            this.textBoxUsuario.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBoxUsuario.CustomButton.UseSelectable = true;
            this.textBoxUsuario.CustomButton.Visible = false;
            this.textBoxUsuario.Lines = new string[0];
            this.textBoxUsuario.Location = new System.Drawing.Point(255, 319);
            this.textBoxUsuario.MaxLength = 32767;
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.PasswordChar = '\0';
            this.textBoxUsuario.ReadOnly = true;
            this.textBoxUsuario.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxUsuario.SelectedText = "";
            this.textBoxUsuario.SelectionLength = 0;
            this.textBoxUsuario.SelectionStart = 0;
            this.textBoxUsuario.ShortcutsEnabled = true;
            this.textBoxUsuario.Size = new System.Drawing.Size(75, 23);
            this.textBoxUsuario.TabIndex = 20;
            this.textBoxUsuario.UseSelectable = true;
            this.textBoxUsuario.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBoxUsuario.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // textBoxTipoAcceso
            // 
            // 
            // 
            // 
            this.textBoxTipoAcceso.CustomButton.Image = null;
            this.textBoxTipoAcceso.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.textBoxTipoAcceso.CustomButton.Name = "";
            this.textBoxTipoAcceso.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textBoxTipoAcceso.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBoxTipoAcceso.CustomButton.TabIndex = 1;
            this.textBoxTipoAcceso.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBoxTipoAcceso.CustomButton.UseSelectable = true;
            this.textBoxTipoAcceso.CustomButton.Visible = false;
            this.textBoxTipoAcceso.Lines = new string[0];
            this.textBoxTipoAcceso.Location = new System.Drawing.Point(255, 353);
            this.textBoxTipoAcceso.MaxLength = 32767;
            this.textBoxTipoAcceso.Name = "textBoxTipoAcceso";
            this.textBoxTipoAcceso.PasswordChar = '\0';
            this.textBoxTipoAcceso.ReadOnly = true;
            this.textBoxTipoAcceso.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxTipoAcceso.SelectedText = "";
            this.textBoxTipoAcceso.SelectionLength = 0;
            this.textBoxTipoAcceso.SelectionStart = 0;
            this.textBoxTipoAcceso.ShortcutsEnabled = true;
            this.textBoxTipoAcceso.Size = new System.Drawing.Size(75, 23);
            this.textBoxTipoAcceso.TabIndex = 21;
            this.textBoxTipoAcceso.UseSelectable = true;
            this.textBoxTipoAcceso.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBoxTipoAcceso.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // formAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1235, 580);
            this.Controls.Add(this.tabControlAdmonEmpleados);
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
            this.tabPageBusquedaEmpleado.ResumeLayout(false);
            this.tabPageBusquedaEmpleado.PerformLayout();
            this.groupBoxBuscarPor.ResumeLayout(false);
            this.groupBoxBuscarPor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private MetroFramework.Controls.MetroLabel labelUsuario;
        private System.Windows.Forms.GroupBox groupBoxOperaciones;
        private MetroFramework.Controls.MetroButton btnCrearPaa;
        private MetroFramework.Controls.MetroButton btnAdministrarEmpleados;
        private MetroFramework.Controls.MetroButton btnOperacionesEquipoApoyo;
        private MetroFramework.Controls.MetroButton btnBuscar;
        private MetroFramework.Controls.MetroTabControl tabControlAdmonEmpleados;
        private MetroFramework.Controls.MetroTabPage tabPageBusquedaEmpleado;

        private MetroFramework.Controls.MetroGrid metroGrid3;
        private MetroFramework.Controls.MetroTabControl metroTabControl4;
        private MetroFramework.Controls.MetroTabPage metroTabPage6;
        private MetroFramework.Controls.MetroTabPage metroTabPage7;
        private MetroFramework.Controls.MetroButton metroButton7;
        private System.Windows.Forms.TextBox textBusquedaEmpleado;
        private MetroFramework.Controls.MetroTabPage tabPageAgregarEmpleado;
        private System.Windows.Forms.BindingSource usuariosBindingSource;
        private System.Windows.Forms.ToolTip toolTipBusquedaEmpleado;
        private System.Windows.Forms.GroupBox groupBoxBuscarPor;
        private MetroFramework.Controls.MetroRadioButton radioNombreEmpleado;
        private MetroFramework.Controls.MetroRadioButton radioCodigoEmpleado;
        private MetroFramework.Controls.MetroTextBox textBoxNombreUsuario;
        private MetroFramework.Controls.MetroLabel metroTituloInformacionEmpleado;
        private MetroFramework.Controls.MetroLabel labelTipoAcceso;
        private MetroFramework.Controls.MetroLabel labelCodigoUsuario;
        private MetroFramework.Controls.MetroLabel labelIdentidad;
        private MetroFramework.Controls.MetroLabel labelCodigoEmpleado;
        private MetroFramework.Controls.MetroLabel labelNombreEmpleado;
        private MetroFramework.Controls.MetroTextBox textBoxCódigoEmpleado;
        private MetroFramework.Controls.MetroTextBox textBoxTipoAcceso;
        private MetroFramework.Controls.MetroTextBox textBoxUsuario;
        private MetroFramework.Controls.MetroTextBox textBoxIdentidad;
    }
}

