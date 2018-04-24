namespace SIGEA_PAA.User_Control
{
    partial class Modulo_Estudiante
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.GroupBox_Estudiante = new System.Windows.Forms.GroupBox();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.Cmb_Carrera = new MetroFramework.Controls.MetroComboBox();
            this.Btn_Registrar = new MetroFramework.Controls.MetroButton();
            this.Txt_Identidad = new MetroFramework.Controls.MetroTextBox();
            this.Txt_Nombre = new MetroFramework.Controls.MetroTextBox();
            this.Txt_Cuenta = new MetroFramework.Controls.MetroTextBox();
            this.Lbl_Carrera = new MetroFramework.Controls.MetroLabel();
            this.Lbl_Identidad = new MetroFramework.Controls.MetroLabel();
            this.Lbl_Nombre = new MetroFramework.Controls.MetroLabel();
            this.Lbl_Cuenta = new MetroFramework.Controls.MetroLabel();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.Txt_Busqueda_Edicion = new System.Windows.Forms.MaskedTextBox();
            this.Cmb_Carrera_Edicion = new MetroFramework.Controls.MetroComboBox();
            this.Btn_Actualizar_Edicion = new MetroFramework.Controls.MetroButton();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.Txt_Identidad_Edicion = new MetroFramework.Controls.MetroTextBox();
            this.Txt_Nombre_Edicion = new MetroFramework.Controls.MetroTextBox();
            this.Txt_Cuenta_Edicion = new MetroFramework.Controls.MetroTextBox();
            this.Btn_Buscar_Edicion = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.GroupBox_Estudiante.SuspendLayout();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox_Estudiante
            // 
            this.GroupBox_Estudiante.Controls.Add(this.metroTabControl1);
            this.GroupBox_Estudiante.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupBox_Estudiante.Location = new System.Drawing.Point(0, 0);
            this.GroupBox_Estudiante.Name = "GroupBox_Estudiante";
            this.GroupBox_Estudiante.Size = new System.Drawing.Size(651, 540);
            this.GroupBox_Estudiante.TabIndex = 1;
            this.GroupBox_Estudiante.TabStop = false;
            this.GroupBox_Estudiante.Text = "Modulo Estudiante";
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.Location = new System.Drawing.Point(3, 16);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(645, 521);
            this.metroTabControl1.TabIndex = 1;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.Cmb_Carrera);
            this.metroTabPage1.Controls.Add(this.Btn_Registrar);
            this.metroTabPage1.Controls.Add(this.Txt_Identidad);
            this.metroTabPage1.Controls.Add(this.Txt_Nombre);
            this.metroTabPage1.Controls.Add(this.Txt_Cuenta);
            this.metroTabPage1.Controls.Add(this.Lbl_Carrera);
            this.metroTabPage1.Controls.Add(this.Lbl_Identidad);
            this.metroTabPage1.Controls.Add(this.Lbl_Nombre);
            this.metroTabPage1.Controls.Add(this.Lbl_Cuenta);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(637, 479);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Registro";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            this.metroTabPage1.Click += new System.EventHandler(this.metroTabPage1_Click);
            // 
            // Cmb_Carrera
            // 
            this.Cmb_Carrera.FormattingEnabled = true;
            this.Cmb_Carrera.ItemHeight = 23;
            this.Cmb_Carrera.Location = new System.Drawing.Point(232, 305);
            this.Cmb_Carrera.Name = "Cmb_Carrera";
            this.Cmb_Carrera.Size = new System.Drawing.Size(234, 29);
            this.Cmb_Carrera.TabIndex = 27;
            this.Cmb_Carrera.UseSelectable = true;
            this.Cmb_Carrera.SelectedIndexChanged += new System.EventHandler(this.Cmb_Carrera_SelectedIndexChanged);
            // 
            // Btn_Registrar
            // 
            this.Btn_Registrar.Location = new System.Drawing.Point(232, 402);
            this.Btn_Registrar.Name = "Btn_Registrar";
            this.Btn_Registrar.Size = new System.Drawing.Size(234, 25);
            this.Btn_Registrar.TabIndex = 23;
            this.Btn_Registrar.Text = "Registrar";
            this.Btn_Registrar.UseSelectable = true;
            this.Btn_Registrar.Click += new System.EventHandler(this.Btn_Registrar_Click);
            // 
            // Txt_Identidad
            // 
            // 
            // 
            // 
            this.Txt_Identidad.CustomButton.Image = null;
            this.Txt_Identidad.CustomButton.Location = new System.Drawing.Point(210, 1);
            this.Txt_Identidad.CustomButton.Name = "";
            this.Txt_Identidad.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.Txt_Identidad.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Txt_Identidad.CustomButton.TabIndex = 1;
            this.Txt_Identidad.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Txt_Identidad.CustomButton.UseSelectable = true;
            this.Txt_Identidad.CustomButton.Visible = false;
            this.Txt_Identidad.Lines = new string[0];
            this.Txt_Identidad.Location = new System.Drawing.Point(232, 222);
            this.Txt_Identidad.MaxLength = 32767;
            this.Txt_Identidad.Name = "Txt_Identidad";
            this.Txt_Identidad.PasswordChar = '\0';
            this.Txt_Identidad.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Txt_Identidad.SelectedText = "";
            this.Txt_Identidad.SelectionLength = 0;
            this.Txt_Identidad.SelectionStart = 0;
            this.Txt_Identidad.ShortcutsEnabled = true;
            this.Txt_Identidad.Size = new System.Drawing.Size(234, 25);
            this.Txt_Identidad.TabIndex = 22;
            this.Txt_Identidad.UseSelectable = true;
            this.Txt_Identidad.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Txt_Identidad.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Txt_Nombre
            // 
            // 
            // 
            // 
            this.Txt_Nombre.CustomButton.Image = null;
            this.Txt_Nombre.CustomButton.Location = new System.Drawing.Point(210, 1);
            this.Txt_Nombre.CustomButton.Name = "";
            this.Txt_Nombre.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.Txt_Nombre.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Txt_Nombre.CustomButton.TabIndex = 1;
            this.Txt_Nombre.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Txt_Nombre.CustomButton.UseSelectable = true;
            this.Txt_Nombre.CustomButton.Visible = false;
            this.Txt_Nombre.Lines = new string[0];
            this.Txt_Nombre.Location = new System.Drawing.Point(232, 151);
            this.Txt_Nombre.MaxLength = 32767;
            this.Txt_Nombre.Name = "Txt_Nombre";
            this.Txt_Nombre.PasswordChar = '\0';
            this.Txt_Nombre.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Txt_Nombre.SelectedText = "";
            this.Txt_Nombre.SelectionLength = 0;
            this.Txt_Nombre.SelectionStart = 0;
            this.Txt_Nombre.ShortcutsEnabled = true;
            this.Txt_Nombre.Size = new System.Drawing.Size(234, 25);
            this.Txt_Nombre.TabIndex = 21;
            this.Txt_Nombre.UseSelectable = true;
            this.Txt_Nombre.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Txt_Nombre.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Txt_Cuenta
            // 
            // 
            // 
            // 
            this.Txt_Cuenta.CustomButton.Image = null;
            this.Txt_Cuenta.CustomButton.Location = new System.Drawing.Point(210, 1);
            this.Txt_Cuenta.CustomButton.Name = "";
            this.Txt_Cuenta.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.Txt_Cuenta.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Txt_Cuenta.CustomButton.TabIndex = 1;
            this.Txt_Cuenta.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Txt_Cuenta.CustomButton.UseSelectable = true;
            this.Txt_Cuenta.CustomButton.Visible = false;
            this.Txt_Cuenta.Lines = new string[0];
            this.Txt_Cuenta.Location = new System.Drawing.Point(232, 75);
            this.Txt_Cuenta.MaxLength = 13;
            this.Txt_Cuenta.Name = "Txt_Cuenta";
            this.Txt_Cuenta.PasswordChar = '\0';
            this.Txt_Cuenta.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Txt_Cuenta.SelectedText = "";
            this.Txt_Cuenta.SelectionLength = 0;
            this.Txt_Cuenta.SelectionStart = 0;
            this.Txt_Cuenta.ShortcutsEnabled = true;
            this.Txt_Cuenta.Size = new System.Drawing.Size(234, 25);
            this.Txt_Cuenta.TabIndex = 20;
            this.Txt_Cuenta.UseSelectable = true;
            this.Txt_Cuenta.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Txt_Cuenta.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Lbl_Carrera
            // 
            this.Lbl_Carrera.AutoSize = true;
            this.Lbl_Carrera.Location = new System.Drawing.Point(121, 305);
            this.Lbl_Carrera.Name = "Lbl_Carrera";
            this.Lbl_Carrera.Size = new System.Drawing.Size(54, 19);
            this.Lbl_Carrera.TabIndex = 26;
            this.Lbl_Carrera.Text = "Carrera";
            // 
            // Lbl_Identidad
            // 
            this.Lbl_Identidad.AutoSize = true;
            this.Lbl_Identidad.Location = new System.Drawing.Point(121, 226);
            this.Lbl_Identidad.Name = "Lbl_Identidad";
            this.Lbl_Identidad.Size = new System.Drawing.Size(83, 19);
            this.Lbl_Identidad.TabIndex = 25;
            this.Lbl_Identidad.Text = "N° Identidad";
            // 
            // Lbl_Nombre
            // 
            this.Lbl_Nombre.AutoSize = true;
            this.Lbl_Nombre.Location = new System.Drawing.Point(121, 155);
            this.Lbl_Nombre.Name = "Lbl_Nombre";
            this.Lbl_Nombre.Size = new System.Drawing.Size(59, 19);
            this.Lbl_Nombre.TabIndex = 24;
            this.Lbl_Nombre.Text = "Nombre";
            // 
            // Lbl_Cuenta
            // 
            this.Lbl_Cuenta.AutoSize = true;
            this.Lbl_Cuenta.Location = new System.Drawing.Point(117, 79);
            this.Lbl_Cuenta.Name = "Lbl_Cuenta";
            this.Lbl_Cuenta.Size = new System.Drawing.Size(88, 19);
            this.Lbl_Cuenta.TabIndex = 19;
            this.Lbl_Cuenta.Text = "N° de Cuenta";
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.Txt_Busqueda_Edicion);
            this.metroTabPage2.Controls.Add(this.Cmb_Carrera_Edicion);
            this.metroTabPage2.Controls.Add(this.Btn_Actualizar_Edicion);
            this.metroTabPage2.Controls.Add(this.metroLabel5);
            this.metroTabPage2.Controls.Add(this.metroLabel4);
            this.metroTabPage2.Controls.Add(this.metroLabel3);
            this.metroTabPage2.Controls.Add(this.metroLabel2);
            this.metroTabPage2.Controls.Add(this.Txt_Identidad_Edicion);
            this.metroTabPage2.Controls.Add(this.Txt_Nombre_Edicion);
            this.metroTabPage2.Controls.Add(this.Txt_Cuenta_Edicion);
            this.metroTabPage2.Controls.Add(this.Btn_Buscar_Edicion);
            this.metroTabPage2.Controls.Add(this.metroLabel1);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(637, 479);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Edicion";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // Txt_Busqueda_Edicion
            // 
            this.Txt_Busqueda_Edicion.Location = new System.Drawing.Point(247, 62);
            this.Txt_Busqueda_Edicion.Mask = "0000-0000-000";
            this.Txt_Busqueda_Edicion.Name = "Txt_Busqueda_Edicion";
            this.Txt_Busqueda_Edicion.Size = new System.Drawing.Size(238, 20);
            this.Txt_Busqueda_Edicion.TabIndex = 29;
            // 
            // Cmb_Carrera_Edicion
            // 
            this.Cmb_Carrera_Edicion.FormattingEnabled = true;
            this.Cmb_Carrera_Edicion.ItemHeight = 23;
            this.Cmb_Carrera_Edicion.Location = new System.Drawing.Point(247, 354);
            this.Cmb_Carrera_Edicion.Name = "Cmb_Carrera_Edicion";
            this.Cmb_Carrera_Edicion.Size = new System.Drawing.Size(238, 29);
            this.Cmb_Carrera_Edicion.TabIndex = 28;
            this.Cmb_Carrera_Edicion.UseSelectable = true;
            // 
            // Btn_Actualizar_Edicion
            // 
            this.Btn_Actualizar_Edicion.Enabled = false;
            this.Btn_Actualizar_Edicion.Location = new System.Drawing.Point(287, 417);
            this.Btn_Actualizar_Edicion.Name = "Btn_Actualizar_Edicion";
            this.Btn_Actualizar_Edicion.Size = new System.Drawing.Size(163, 23);
            this.Btn_Actualizar_Edicion.TabIndex = 23;
            this.Btn_Actualizar_Edicion.Text = "Actualizar";
            this.Btn_Actualizar_Edicion.UseSelectable = true;
            this.Btn_Actualizar_Edicion.Click += new System.EventHandler(this.Btn_Actualizar_Edicion_Click);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(77, 354);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(54, 19);
            this.metroLabel5.TabIndex = 27;
            this.metroLabel5.Text = "Carrera";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(78, 302);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(64, 19);
            this.metroLabel4.TabIndex = 26;
            this.metroLabel4.Text = "Identidad";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(78, 255);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(59, 19);
            this.metroLabel3.TabIndex = 25;
            this.metroLabel3.Text = "Nombre";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(77, 205);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(50, 19);
            this.metroLabel2.TabIndex = 24;
            this.metroLabel2.Text = "Cuenta";
            // 
            // Txt_Identidad_Edicion
            // 
            // 
            // 
            // 
            this.Txt_Identidad_Edicion.CustomButton.Image = null;
            this.Txt_Identidad_Edicion.CustomButton.Location = new System.Drawing.Point(216, 1);
            this.Txt_Identidad_Edicion.CustomButton.Name = "";
            this.Txt_Identidad_Edicion.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Txt_Identidad_Edicion.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Txt_Identidad_Edicion.CustomButton.TabIndex = 1;
            this.Txt_Identidad_Edicion.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Txt_Identidad_Edicion.CustomButton.UseSelectable = true;
            this.Txt_Identidad_Edicion.CustomButton.Visible = false;
            this.Txt_Identidad_Edicion.Lines = new string[0];
            this.Txt_Identidad_Edicion.Location = new System.Drawing.Point(247, 298);
            this.Txt_Identidad_Edicion.MaxLength = 32767;
            this.Txt_Identidad_Edicion.Name = "Txt_Identidad_Edicion";
            this.Txt_Identidad_Edicion.PasswordChar = '\0';
            this.Txt_Identidad_Edicion.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Txt_Identidad_Edicion.SelectedText = "";
            this.Txt_Identidad_Edicion.SelectionLength = 0;
            this.Txt_Identidad_Edicion.SelectionStart = 0;
            this.Txt_Identidad_Edicion.ShortcutsEnabled = true;
            this.Txt_Identidad_Edicion.Size = new System.Drawing.Size(238, 23);
            this.Txt_Identidad_Edicion.TabIndex = 21;
            this.Txt_Identidad_Edicion.UseSelectable = true;
            this.Txt_Identidad_Edicion.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Txt_Identidad_Edicion.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Txt_Nombre_Edicion
            // 
            // 
            // 
            // 
            this.Txt_Nombre_Edicion.CustomButton.Image = null;
            this.Txt_Nombre_Edicion.CustomButton.Location = new System.Drawing.Point(216, 1);
            this.Txt_Nombre_Edicion.CustomButton.Name = "";
            this.Txt_Nombre_Edicion.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Txt_Nombre_Edicion.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Txt_Nombre_Edicion.CustomButton.TabIndex = 1;
            this.Txt_Nombre_Edicion.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Txt_Nombre_Edicion.CustomButton.UseSelectable = true;
            this.Txt_Nombre_Edicion.CustomButton.Visible = false;
            this.Txt_Nombre_Edicion.Lines = new string[0];
            this.Txt_Nombre_Edicion.Location = new System.Drawing.Point(247, 251);
            this.Txt_Nombre_Edicion.MaxLength = 32767;
            this.Txt_Nombre_Edicion.Name = "Txt_Nombre_Edicion";
            this.Txt_Nombre_Edicion.PasswordChar = '\0';
            this.Txt_Nombre_Edicion.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Txt_Nombre_Edicion.SelectedText = "";
            this.Txt_Nombre_Edicion.SelectionLength = 0;
            this.Txt_Nombre_Edicion.SelectionStart = 0;
            this.Txt_Nombre_Edicion.ShortcutsEnabled = true;
            this.Txt_Nombre_Edicion.Size = new System.Drawing.Size(238, 23);
            this.Txt_Nombre_Edicion.TabIndex = 20;
            this.Txt_Nombre_Edicion.UseSelectable = true;
            this.Txt_Nombre_Edicion.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Txt_Nombre_Edicion.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Txt_Cuenta_Edicion
            // 
            // 
            // 
            // 
            this.Txt_Cuenta_Edicion.CustomButton.Image = null;
            this.Txt_Cuenta_Edicion.CustomButton.Location = new System.Drawing.Point(216, 1);
            this.Txt_Cuenta_Edicion.CustomButton.Name = "";
            this.Txt_Cuenta_Edicion.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Txt_Cuenta_Edicion.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Txt_Cuenta_Edicion.CustomButton.TabIndex = 1;
            this.Txt_Cuenta_Edicion.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Txt_Cuenta_Edicion.CustomButton.UseSelectable = true;
            this.Txt_Cuenta_Edicion.CustomButton.Visible = false;
            this.Txt_Cuenta_Edicion.Lines = new string[0];
            this.Txt_Cuenta_Edicion.Location = new System.Drawing.Point(247, 205);
            this.Txt_Cuenta_Edicion.MaxLength = 32767;
            this.Txt_Cuenta_Edicion.Name = "Txt_Cuenta_Edicion";
            this.Txt_Cuenta_Edicion.PasswordChar = '\0';
            this.Txt_Cuenta_Edicion.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Txt_Cuenta_Edicion.SelectedText = "";
            this.Txt_Cuenta_Edicion.SelectionLength = 0;
            this.Txt_Cuenta_Edicion.SelectionStart = 0;
            this.Txt_Cuenta_Edicion.ShortcutsEnabled = true;
            this.Txt_Cuenta_Edicion.Size = new System.Drawing.Size(238, 23);
            this.Txt_Cuenta_Edicion.TabIndex = 19;
            this.Txt_Cuenta_Edicion.UseSelectable = true;
            this.Txt_Cuenta_Edicion.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Txt_Cuenta_Edicion.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Btn_Buscar_Edicion
            // 
            this.Btn_Buscar_Edicion.Location = new System.Drawing.Point(299, 104);
            this.Btn_Buscar_Edicion.Name = "Btn_Buscar_Edicion";
            this.Btn_Buscar_Edicion.Size = new System.Drawing.Size(163, 23);
            this.Btn_Buscar_Edicion.TabIndex = 17;
            this.Btn_Buscar_Edicion.Text = "Buscar";
            this.Btn_Buscar_Edicion.UseSelectable = true;
            this.Btn_Buscar_Edicion.Click += new System.EventHandler(this.Btn_Buscar_Edicion_Click_2);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(78, 62);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(122, 19);
            this.metroLabel1.TabIndex = 18;
            this.metroLabel1.Text = "Numero de Cuenta";
            // 
            // Modulo_Estudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GroupBox_Estudiante);
            this.Name = "Modulo_Estudiante";
            this.Size = new System.Drawing.Size(651, 540);
            this.Load += new System.EventHandler(this.Modulo_Estudiante_Load);
            this.GroupBox_Estudiante.ResumeLayout(false);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupBox_Estudiante;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroComboBox Cmb_Carrera;
        private MetroFramework.Controls.MetroButton Btn_Registrar;
        private MetroFramework.Controls.MetroTextBox Txt_Identidad;
        private MetroFramework.Controls.MetroTextBox Txt_Nombre;
        private MetroFramework.Controls.MetroTextBox Txt_Cuenta;
        private MetroFramework.Controls.MetroLabel Lbl_Carrera;
        private MetroFramework.Controls.MetroLabel Lbl_Identidad;
        private MetroFramework.Controls.MetroLabel Lbl_Nombre;
        private MetroFramework.Controls.MetroLabel Lbl_Cuenta;
        private MetroFramework.Controls.MetroButton Btn_Actualizar_Edicion;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox Txt_Identidad_Edicion;
        private MetroFramework.Controls.MetroTextBox Txt_Nombre_Edicion;
        private MetroFramework.Controls.MetroTextBox Txt_Cuenta_Edicion;
        private MetroFramework.Controls.MetroButton Btn_Buscar_Edicion;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox Cmb_Carrera_Edicion;
        private System.Windows.Forms.MaskedTextBox Txt_Busqueda_Edicion;
    }
}
