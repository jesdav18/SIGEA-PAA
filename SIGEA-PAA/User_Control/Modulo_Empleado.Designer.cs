namespace SIGEA_PAA.User_Control
{
    partial class Modulo_Empleado
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.Btn_Registrar_Empleado = new MetroFramework.Controls.MetroButton();
            this.groupBox_Datos_Usuario = new System.Windows.Forms.GroupBox();
            this.Txt_Identidad_Registrar = new System.Windows.Forms.MaskedTextBox();
            this.Txt_Nombre_Registrar = new MetroFramework.Controls.MetroTextBox();
            this.Lbl_Nombre = new MetroFramework.Controls.MetroLabel();
            this.Txt_Empleado_Registrar = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.Btn_Editar_Usuario = new MetroFramework.Controls.MetroButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Lbl_Usuario_Editar_Usuario = new MetroFramework.Controls.MetroLabel();
            this.Btn_Buscar_Empleado = new MetroFramework.Controls.MetroButton();
            this.Txt_Buscar_Empleado_Editar = new MetroFramework.Controls.MetroTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Txt_Identidad_Editar = new System.Windows.Forms.MaskedTextBox();
            this.Txt_Empleado_Editar = new MetroFramework.Controls.MetroTextBox();
            this.Txt_Password_Editar = new MetroFramework.Controls.MetroTextBox();
            this.Cmb_TipoAcceso_Editar = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.groupBox1.SuspendLayout();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.groupBox_Datos_Usuario.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.metroTabControl1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(651, 540);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Administracion Empleado";
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.Location = new System.Drawing.Point(3, 16);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 1;
            this.metroTabControl1.Size = new System.Drawing.Size(645, 521);
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.Btn_Registrar_Empleado);
            this.metroTabPage1.Controls.Add(this.groupBox_Datos_Usuario);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(637, 479);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Agregar Empleado";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // Btn_Registrar_Empleado
            // 
            this.Btn_Registrar_Empleado.Location = new System.Drawing.Point(210, 405);
            this.Btn_Registrar_Empleado.Name = "Btn_Registrar_Empleado";
            this.Btn_Registrar_Empleado.Size = new System.Drawing.Size(230, 25);
            this.Btn_Registrar_Empleado.TabIndex = 5;
            this.Btn_Registrar_Empleado.Text = "Registrar Empleado";
            this.Btn_Registrar_Empleado.UseSelectable = true;
            this.Btn_Registrar_Empleado.Click += new System.EventHandler(this.Btn_Registrar_Usuario_Click);
            // 
            // groupBox_Datos_Usuario
            // 
            this.groupBox_Datos_Usuario.BackColor = System.Drawing.Color.White;
            this.groupBox_Datos_Usuario.Controls.Add(this.Txt_Identidad_Registrar);
            this.groupBox_Datos_Usuario.Controls.Add(this.Txt_Nombre_Registrar);
            this.groupBox_Datos_Usuario.Controls.Add(this.Lbl_Nombre);
            this.groupBox_Datos_Usuario.Controls.Add(this.Txt_Empleado_Registrar);
            this.groupBox_Datos_Usuario.Controls.Add(this.metroLabel2);
            this.groupBox_Datos_Usuario.Controls.Add(this.metroLabel1);
            this.groupBox_Datos_Usuario.Location = new System.Drawing.Point(0, 157);
            this.groupBox_Datos_Usuario.Name = "groupBox_Datos_Usuario";
            this.groupBox_Datos_Usuario.Size = new System.Drawing.Size(637, 207);
            this.groupBox_Datos_Usuario.TabIndex = 4;
            this.groupBox_Datos_Usuario.TabStop = false;
            this.groupBox_Datos_Usuario.Text = "Datos del Usuario";
            // 
            // Txt_Identidad_Registrar
            // 
            this.Txt_Identidad_Registrar.Location = new System.Drawing.Point(251, 152);
            this.Txt_Identidad_Registrar.Mask = "0000-0000-00000";
            this.Txt_Identidad_Registrar.Name = "Txt_Identidad_Registrar";
            this.Txt_Identidad_Registrar.Size = new System.Drawing.Size(230, 20);
            this.Txt_Identidad_Registrar.TabIndex = 20;
            // 
            // Txt_Nombre_Registrar
            // 
            // 
            // 
            // 
            this.Txt_Nombre_Registrar.CustomButton.Image = null;
            this.Txt_Nombre_Registrar.CustomButton.Location = new System.Drawing.Point(206, 1);
            this.Txt_Nombre_Registrar.CustomButton.Name = "";
            this.Txt_Nombre_Registrar.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.Txt_Nombre_Registrar.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Txt_Nombre_Registrar.CustomButton.TabIndex = 1;
            this.Txt_Nombre_Registrar.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Txt_Nombre_Registrar.CustomButton.UseSelectable = true;
            this.Txt_Nombre_Registrar.CustomButton.Visible = false;
            this.Txt_Nombre_Registrar.Lines = new string[0];
            this.Txt_Nombre_Registrar.Location = new System.Drawing.Point(251, 105);
            this.Txt_Nombre_Registrar.MaxLength = 32767;
            this.Txt_Nombre_Registrar.Name = "Txt_Nombre_Registrar";
            this.Txt_Nombre_Registrar.PasswordChar = '\0';
            this.Txt_Nombre_Registrar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Txt_Nombre_Registrar.SelectedText = "";
            this.Txt_Nombre_Registrar.SelectionLength = 0;
            this.Txt_Nombre_Registrar.SelectionStart = 0;
            this.Txt_Nombre_Registrar.ShortcutsEnabled = true;
            this.Txt_Nombre_Registrar.Size = new System.Drawing.Size(230, 25);
            this.Txt_Nombre_Registrar.TabIndex = 19;
            this.Txt_Nombre_Registrar.UseSelectable = true;
            this.Txt_Nombre_Registrar.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Txt_Nombre_Registrar.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Lbl_Nombre
            // 
            this.Lbl_Nombre.AutoSize = true;
            this.Lbl_Nombre.Location = new System.Drawing.Point(106, 105);
            this.Lbl_Nombre.Name = "Lbl_Nombre";
            this.Lbl_Nombre.Size = new System.Drawing.Size(59, 19);
            this.Lbl_Nombre.TabIndex = 18;
            this.Lbl_Nombre.Text = "Nombre";
            // 
            // Txt_Empleado_Registrar
            // 
            // 
            // 
            // 
            this.Txt_Empleado_Registrar.CustomButton.Image = null;
            this.Txt_Empleado_Registrar.CustomButton.Location = new System.Drawing.Point(206, 1);
            this.Txt_Empleado_Registrar.CustomButton.Name = "";
            this.Txt_Empleado_Registrar.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.Txt_Empleado_Registrar.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Txt_Empleado_Registrar.CustomButton.TabIndex = 1;
            this.Txt_Empleado_Registrar.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Txt_Empleado_Registrar.CustomButton.UseSelectable = true;
            this.Txt_Empleado_Registrar.CustomButton.Visible = false;
            this.Txt_Empleado_Registrar.Enabled = false;
            this.Txt_Empleado_Registrar.Lines = new string[0];
            this.Txt_Empleado_Registrar.Location = new System.Drawing.Point(251, 57);
            this.Txt_Empleado_Registrar.MaxLength = 32767;
            this.Txt_Empleado_Registrar.Name = "Txt_Empleado_Registrar";
            this.Txt_Empleado_Registrar.PasswordChar = '\0';
            this.Txt_Empleado_Registrar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Txt_Empleado_Registrar.SelectedText = "";
            this.Txt_Empleado_Registrar.SelectionLength = 0;
            this.Txt_Empleado_Registrar.SelectionStart = 0;
            this.Txt_Empleado_Registrar.ShortcutsEnabled = true;
            this.Txt_Empleado_Registrar.Size = new System.Drawing.Size(230, 25);
            this.Txt_Empleado_Registrar.TabIndex = 17;
            this.Txt_Empleado_Registrar.UseSelectable = true;
            this.Txt_Empleado_Registrar.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Txt_Empleado_Registrar.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(106, 152);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(83, 19);
            this.metroLabel2.TabIndex = 11;
            this.metroLabel2.Text = "N° Identidad";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(106, 62);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(139, 19);
            this.metroLabel1.TabIndex = 10;
            this.metroLabel1.Text = "Codigo del Empleado";
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.Btn_Editar_Usuario);
            this.metroTabPage2.Controls.Add(this.groupBox2);
            this.metroTabPage2.Controls.Add(this.groupBox3);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(637, 479);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Edicion Empleado";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // Btn_Editar_Usuario
            // 
            this.Btn_Editar_Usuario.Location = new System.Drawing.Point(210, 405);
            this.Btn_Editar_Usuario.Name = "Btn_Editar_Usuario";
            this.Btn_Editar_Usuario.Size = new System.Drawing.Size(230, 30);
            this.Btn_Editar_Usuario.TabIndex = 9;
            this.Btn_Editar_Usuario.Text = "Registrar Cambios";
            this.Btn_Editar_Usuario.UseSelectable = true;
            this.Btn_Editar_Usuario.Click += new System.EventHandler(this.Btn_Editar_Usuario_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.Lbl_Usuario_Editar_Usuario);
            this.groupBox2.Controls.Add(this.Btn_Buscar_Empleado);
            this.groupBox2.Controls.Add(this.Txt_Buscar_Empleado_Editar);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(637, 138);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Busqueda";
            // 
            // Lbl_Usuario_Editar_Usuario
            // 
            this.Lbl_Usuario_Editar_Usuario.AutoSize = true;
            this.Lbl_Usuario_Editar_Usuario.Location = new System.Drawing.Point(114, 36);
            this.Lbl_Usuario_Editar_Usuario.Name = "Lbl_Usuario_Editar_Usuario";
            this.Lbl_Usuario_Editar_Usuario.Size = new System.Drawing.Size(139, 19);
            this.Lbl_Usuario_Editar_Usuario.TabIndex = 2;
            this.Lbl_Usuario_Editar_Usuario.Text = "Codigo del Empleado";
            // 
            // Btn_Buscar_Empleado
            // 
            this.Btn_Buscar_Empleado.Location = new System.Drawing.Point(259, 89);
            this.Btn_Buscar_Empleado.Name = "Btn_Buscar_Empleado";
            this.Btn_Buscar_Empleado.Size = new System.Drawing.Size(230, 30);
            this.Btn_Buscar_Empleado.TabIndex = 1;
            this.Btn_Buscar_Empleado.Text = "Buscar";
            this.Btn_Buscar_Empleado.UseSelectable = true;
            this.Btn_Buscar_Empleado.Click += new System.EventHandler(this.Btn_Buscar_Empleado_Click);
            // 
            // Txt_Buscar_Empleado_Editar
            // 
            // 
            // 
            // 
            this.Txt_Buscar_Empleado_Editar.CustomButton.Image = null;
            this.Txt_Buscar_Empleado_Editar.CustomButton.Location = new System.Drawing.Point(206, 1);
            this.Txt_Buscar_Empleado_Editar.CustomButton.Name = "";
            this.Txt_Buscar_Empleado_Editar.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.Txt_Buscar_Empleado_Editar.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Txt_Buscar_Empleado_Editar.CustomButton.TabIndex = 1;
            this.Txt_Buscar_Empleado_Editar.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Txt_Buscar_Empleado_Editar.CustomButton.UseSelectable = true;
            this.Txt_Buscar_Empleado_Editar.CustomButton.Visible = false;
            this.Txt_Buscar_Empleado_Editar.Lines = new string[0];
            this.Txt_Buscar_Empleado_Editar.Location = new System.Drawing.Point(259, 36);
            this.Txt_Buscar_Empleado_Editar.MaxLength = 32767;
            this.Txt_Buscar_Empleado_Editar.Name = "Txt_Buscar_Empleado_Editar";
            this.Txt_Buscar_Empleado_Editar.PasswordChar = '\0';
            this.Txt_Buscar_Empleado_Editar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Txt_Buscar_Empleado_Editar.SelectedText = "";
            this.Txt_Buscar_Empleado_Editar.SelectionLength = 0;
            this.Txt_Buscar_Empleado_Editar.SelectionStart = 0;
            this.Txt_Buscar_Empleado_Editar.ShortcutsEnabled = true;
            this.Txt_Buscar_Empleado_Editar.Size = new System.Drawing.Size(230, 25);
            this.Txt_Buscar_Empleado_Editar.TabIndex = 0;
            this.Txt_Buscar_Empleado_Editar.UseSelectable = true;
            this.Txt_Buscar_Empleado_Editar.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Txt_Buscar_Empleado_Editar.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.Txt_Identidad_Editar);
            this.groupBox3.Controls.Add(this.Txt_Empleado_Editar);
            this.groupBox3.Controls.Add(this.Txt_Password_Editar);
            this.groupBox3.Controls.Add(this.Cmb_TipoAcceso_Editar);
            this.groupBox3.Controls.Add(this.metroLabel7);
            this.groupBox3.Controls.Add(this.metroLabel8);
            this.groupBox3.Controls.Add(this.metroLabel9);
            this.groupBox3.Controls.Add(this.metroLabel10);
            this.groupBox3.Location = new System.Drawing.Point(0, 157);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(637, 207);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos del Usuario";
            // 
            // Txt_Identidad_Editar
            // 
            this.Txt_Identidad_Editar.Location = new System.Drawing.Point(259, 121);
            this.Txt_Identidad_Editar.Mask = "0000-0000-00000";
            this.Txt_Identidad_Editar.Name = "Txt_Identidad_Editar";
            this.Txt_Identidad_Editar.Size = new System.Drawing.Size(230, 20);
            this.Txt_Identidad_Editar.TabIndex = 21;
            // 
            // Txt_Empleado_Editar
            // 
            // 
            // 
            // 
            this.Txt_Empleado_Editar.CustomButton.Image = null;
            this.Txt_Empleado_Editar.CustomButton.Location = new System.Drawing.Point(206, 1);
            this.Txt_Empleado_Editar.CustomButton.Name = "";
            this.Txt_Empleado_Editar.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.Txt_Empleado_Editar.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Txt_Empleado_Editar.CustomButton.TabIndex = 1;
            this.Txt_Empleado_Editar.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Txt_Empleado_Editar.CustomButton.UseSelectable = true;
            this.Txt_Empleado_Editar.CustomButton.Visible = false;
            this.Txt_Empleado_Editar.Enabled = false;
            this.Txt_Empleado_Editar.Lines = new string[0];
            this.Txt_Empleado_Editar.Location = new System.Drawing.Point(259, 24);
            this.Txt_Empleado_Editar.MaxLength = 32767;
            this.Txt_Empleado_Editar.Name = "Txt_Empleado_Editar";
            this.Txt_Empleado_Editar.PasswordChar = '\0';
            this.Txt_Empleado_Editar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Txt_Empleado_Editar.SelectedText = "";
            this.Txt_Empleado_Editar.SelectionLength = 0;
            this.Txt_Empleado_Editar.SelectionStart = 0;
            this.Txt_Empleado_Editar.ShortcutsEnabled = true;
            this.Txt_Empleado_Editar.Size = new System.Drawing.Size(230, 25);
            this.Txt_Empleado_Editar.TabIndex = 17;
            this.Txt_Empleado_Editar.UseSelectable = true;
            this.Txt_Empleado_Editar.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Txt_Empleado_Editar.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Txt_Password_Editar
            // 
            // 
            // 
            // 
            this.Txt_Password_Editar.CustomButton.Image = null;
            this.Txt_Password_Editar.CustomButton.Location = new System.Drawing.Point(206, 1);
            this.Txt_Password_Editar.CustomButton.Name = "";
            this.Txt_Password_Editar.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.Txt_Password_Editar.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Txt_Password_Editar.CustomButton.TabIndex = 1;
            this.Txt_Password_Editar.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Txt_Password_Editar.CustomButton.UseSelectable = true;
            this.Txt_Password_Editar.CustomButton.Visible = false;
            this.Txt_Password_Editar.Lines = new string[0];
            this.Txt_Password_Editar.Location = new System.Drawing.Point(259, 72);
            this.Txt_Password_Editar.MaxLength = 32767;
            this.Txt_Password_Editar.Name = "Txt_Password_Editar";
            this.Txt_Password_Editar.PasswordChar = '\0';
            this.Txt_Password_Editar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Txt_Password_Editar.SelectedText = "";
            this.Txt_Password_Editar.SelectionLength = 0;
            this.Txt_Password_Editar.SelectionStart = 0;
            this.Txt_Password_Editar.ShortcutsEnabled = true;
            this.Txt_Password_Editar.Size = new System.Drawing.Size(230, 25);
            this.Txt_Password_Editar.TabIndex = 16;
            this.Txt_Password_Editar.UseSelectable = true;
            this.Txt_Password_Editar.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Txt_Password_Editar.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Cmb_TipoAcceso_Editar
            // 
            this.Cmb_TipoAcceso_Editar.FormattingEnabled = true;
            this.Cmb_TipoAcceso_Editar.ItemHeight = 23;
            this.Cmb_TipoAcceso_Editar.Items.AddRange(new object[] {
            "ACTIVO",
            "INACTIVO"});
            this.Cmb_TipoAcceso_Editar.Location = new System.Drawing.Point(259, 163);
            this.Cmb_TipoAcceso_Editar.Name = "Cmb_TipoAcceso_Editar";
            this.Cmb_TipoAcceso_Editar.Size = new System.Drawing.Size(230, 29);
            this.Cmb_TipoAcceso_Editar.TabIndex = 14;
            this.Cmb_TipoAcceso_Editar.UseSelectable = true;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(114, 164);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(134, 19);
            this.metroLabel7.TabIndex = 13;
            this.metroLabel7.Text = "Estado del Empleado";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(114, 122);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(64, 19);
            this.metroLabel8.TabIndex = 12;
            this.metroLabel8.Text = "Identidad";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(114, 73);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(59, 19);
            this.metroLabel9.TabIndex = 11;
            this.metroLabel9.Text = "Nombre";
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(114, 30);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(139, 19);
            this.metroLabel10.TabIndex = 10;
            this.metroLabel10.Text = "Codigo del Empleado";
            // 
            // Modulo_Empleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "Modulo_Empleado";
            this.Size = new System.Drawing.Size(651, 540);
            this.groupBox1.ResumeLayout(false);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.groupBox_Datos_Usuario.ResumeLayout(false);
            this.groupBox_Datos_Usuario.PerformLayout();
            this.metroTabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroButton Btn_Editar_Usuario;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroLabel Lbl_Usuario_Editar_Usuario;
        private MetroFramework.Controls.MetroButton Btn_Buscar_Empleado;
        private MetroFramework.Controls.MetroTextBox Txt_Buscar_Empleado_Editar;
        private System.Windows.Forms.GroupBox groupBox3;
        private MetroFramework.Controls.MetroTextBox Txt_Empleado_Editar;
        private MetroFramework.Controls.MetroTextBox Txt_Password_Editar;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroButton Btn_Registrar_Empleado;
        private System.Windows.Forms.GroupBox groupBox_Datos_Usuario;
        private MetroFramework.Controls.MetroTextBox Txt_Nombre_Registrar;
        private MetroFramework.Controls.MetroLabel Lbl_Nombre;
        private MetroFramework.Controls.MetroTextBox Txt_Empleado_Registrar;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.MaskedTextBox Txt_Identidad_Registrar;
        private System.Windows.Forms.MaskedTextBox Txt_Identidad_Editar;
        private MetroFramework.Controls.MetroComboBox Cmb_TipoAcceso_Editar;
        private MetroFramework.Controls.MetroLabel metroLabel7;
    }
}
