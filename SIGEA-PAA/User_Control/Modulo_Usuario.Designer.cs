namespace SIGEA_PAA.User_Control
{
    partial class Modulo_Usuario
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
            this.Btn_Registrar_Usuario = new MetroFramework.Controls.MetroButton();
            this.groupBox_Datos_Usuario = new System.Windows.Forms.GroupBox();
            this.Txt_Usuario_Registrar = new MetroFramework.Controls.MetroTextBox();
            this.Txt_Password_Registrar = new MetroFramework.Controls.MetroTextBox();
            this.Txt_Empleado_Registrar = new MetroFramework.Controls.MetroTextBox();
            this.Cmb_TipoAcceso_Registrar = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.Btn_Editar_Usuario = new MetroFramework.Controls.MetroButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Lbl_Usuario_Editar_Usuario = new MetroFramework.Controls.MetroLabel();
            this.Btn_Buscar_Usuario = new MetroFramework.Controls.MetroButton();
            this.Txt_Buscar_Usuario_Editar = new MetroFramework.Controls.MetroTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Txt_Usuario_Editar = new MetroFramework.Controls.MetroTextBox();
            this.Txt_Password_Editar = new MetroFramework.Controls.MetroTextBox();
            this.Txt_Empleado_Editar = new MetroFramework.Controls.MetroTextBox();
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
            this.groupBox1.Text = "Administrar Usuario";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
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
            this.metroTabPage1.Controls.Add(this.Btn_Registrar_Usuario);
            this.metroTabPage1.Controls.Add(this.groupBox_Datos_Usuario);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 41);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(637, 476);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Agregar Usuario";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // Btn_Registrar_Usuario
            // 
            this.Btn_Registrar_Usuario.Location = new System.Drawing.Point(244, 416);
            this.Btn_Registrar_Usuario.Name = "Btn_Registrar_Usuario";
            this.Btn_Registrar_Usuario.Size = new System.Drawing.Size(230, 25);
            this.Btn_Registrar_Usuario.TabIndex = 3;
            this.Btn_Registrar_Usuario.Text = "Registrar Usuario";
            this.Btn_Registrar_Usuario.UseSelectable = true;
            this.Btn_Registrar_Usuario.Click += new System.EventHandler(this.Btn_Registrar_Usuario_Click);
            // 
            // groupBox_Datos_Usuario
            // 
            this.groupBox_Datos_Usuario.BackColor = System.Drawing.Color.White;
            this.groupBox_Datos_Usuario.Controls.Add(this.Txt_Usuario_Registrar);
            this.groupBox_Datos_Usuario.Controls.Add(this.Txt_Password_Registrar);
            this.groupBox_Datos_Usuario.Controls.Add(this.Txt_Empleado_Registrar);
            this.groupBox_Datos_Usuario.Controls.Add(this.Cmb_TipoAcceso_Registrar);
            this.groupBox_Datos_Usuario.Controls.Add(this.metroLabel4);
            this.groupBox_Datos_Usuario.Controls.Add(this.metroLabel3);
            this.groupBox_Datos_Usuario.Controls.Add(this.metroLabel2);
            this.groupBox_Datos_Usuario.Controls.Add(this.metroLabel1);
            this.groupBox_Datos_Usuario.Location = new System.Drawing.Point(0, 163);
            this.groupBox_Datos_Usuario.Name = "groupBox_Datos_Usuario";
            this.groupBox_Datos_Usuario.Size = new System.Drawing.Size(634, 207);
            this.groupBox_Datos_Usuario.TabIndex = 2;
            this.groupBox_Datos_Usuario.TabStop = false;
            this.groupBox_Datos_Usuario.Text = "Datos del Usuario";
            // 
            // Txt_Usuario_Registrar
            // 
            // 
            // 
            // 
            this.Txt_Usuario_Registrar.CustomButton.Image = null;
            this.Txt_Usuario_Registrar.CustomButton.Location = new System.Drawing.Point(206, 1);
            this.Txt_Usuario_Registrar.CustomButton.Name = "";
            this.Txt_Usuario_Registrar.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.Txt_Usuario_Registrar.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Txt_Usuario_Registrar.CustomButton.TabIndex = 1;
            this.Txt_Usuario_Registrar.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Txt_Usuario_Registrar.CustomButton.UseSelectable = true;
            this.Txt_Usuario_Registrar.CustomButton.Visible = false;
            this.Txt_Usuario_Registrar.Enabled = false;
            this.Txt_Usuario_Registrar.Lines = new string[0];
            this.Txt_Usuario_Registrar.Location = new System.Drawing.Point(244, 25);
            this.Txt_Usuario_Registrar.MaxLength = 32767;
            this.Txt_Usuario_Registrar.Name = "Txt_Usuario_Registrar";
            this.Txt_Usuario_Registrar.PasswordChar = '\0';
            this.Txt_Usuario_Registrar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Txt_Usuario_Registrar.SelectedText = "";
            this.Txt_Usuario_Registrar.SelectionLength = 0;
            this.Txt_Usuario_Registrar.SelectionStart = 0;
            this.Txt_Usuario_Registrar.ShortcutsEnabled = true;
            this.Txt_Usuario_Registrar.Size = new System.Drawing.Size(230, 25);
            this.Txt_Usuario_Registrar.TabIndex = 17;
            this.Txt_Usuario_Registrar.UseSelectable = true;
            this.Txt_Usuario_Registrar.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Txt_Usuario_Registrar.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Txt_Password_Registrar
            // 
            // 
            // 
            // 
            this.Txt_Password_Registrar.CustomButton.Image = null;
            this.Txt_Password_Registrar.CustomButton.Location = new System.Drawing.Point(206, 1);
            this.Txt_Password_Registrar.CustomButton.Name = "";
            this.Txt_Password_Registrar.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.Txt_Password_Registrar.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Txt_Password_Registrar.CustomButton.TabIndex = 1;
            this.Txt_Password_Registrar.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Txt_Password_Registrar.CustomButton.UseSelectable = true;
            this.Txt_Password_Registrar.CustomButton.Visible = false;
            this.Txt_Password_Registrar.Lines = new string[0];
            this.Txt_Password_Registrar.Location = new System.Drawing.Point(244, 73);
            this.Txt_Password_Registrar.MaxLength = 32767;
            this.Txt_Password_Registrar.Name = "Txt_Password_Registrar";
            this.Txt_Password_Registrar.PasswordChar = '\0';
            this.Txt_Password_Registrar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Txt_Password_Registrar.SelectedText = "";
            this.Txt_Password_Registrar.SelectionLength = 0;
            this.Txt_Password_Registrar.SelectionStart = 0;
            this.Txt_Password_Registrar.ShortcutsEnabled = true;
            this.Txt_Password_Registrar.Size = new System.Drawing.Size(230, 25);
            this.Txt_Password_Registrar.TabIndex = 16;
            this.Txt_Password_Registrar.UseSelectable = true;
            this.Txt_Password_Registrar.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Txt_Password_Registrar.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.Txt_Empleado_Registrar.Location = new System.Drawing.Point(244, 122);
            this.Txt_Empleado_Registrar.MaxLength = 32767;
            this.Txt_Empleado_Registrar.Name = "Txt_Empleado_Registrar";
            this.Txt_Empleado_Registrar.PasswordChar = '\0';
            this.Txt_Empleado_Registrar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Txt_Empleado_Registrar.SelectedText = "";
            this.Txt_Empleado_Registrar.SelectionLength = 0;
            this.Txt_Empleado_Registrar.SelectionStart = 0;
            this.Txt_Empleado_Registrar.ShortcutsEnabled = true;
            this.Txt_Empleado_Registrar.Size = new System.Drawing.Size(230, 25);
            this.Txt_Empleado_Registrar.TabIndex = 15;
            this.Txt_Empleado_Registrar.UseSelectable = true;
            this.Txt_Empleado_Registrar.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Txt_Empleado_Registrar.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Cmb_TipoAcceso_Registrar
            // 
            this.Cmb_TipoAcceso_Registrar.FormattingEnabled = true;
            this.Cmb_TipoAcceso_Registrar.ItemHeight = 23;
            this.Cmb_TipoAcceso_Registrar.Location = new System.Drawing.Point(244, 164);
            this.Cmb_TipoAcceso_Registrar.Name = "Cmb_TipoAcceso_Registrar";
            this.Cmb_TipoAcceso_Registrar.Size = new System.Drawing.Size(230, 29);
            this.Cmb_TipoAcceso_Registrar.TabIndex = 14;
            this.Cmb_TipoAcceso_Registrar.UseSelectable = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(132, 164);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(99, 19);
            this.metroLabel4.TabIndex = 13;
            this.metroLabel4.Text = "Tipo de Acceso";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(132, 122);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(69, 19);
            this.metroLabel3.TabIndex = 12;
            this.metroLabel3.Text = "Empleado";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(132, 73);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(75, 19);
            this.metroLabel2.TabIndex = 11;
            this.metroLabel2.Text = "Contraseña";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(132, 30);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(57, 19);
            this.metroLabel1.TabIndex = 10;
            this.metroLabel1.Text = " Usuario";
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.Btn_Editar_Usuario);
            this.metroTabPage2.Controls.Add(this.groupBox2);
            this.metroTabPage2.Controls.Add(this.groupBox3);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 41);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(637, 476);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Editar Usuario";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            this.metroTabPage2.Click += new System.EventHandler(this.metroTabPage2_Click);
            // 
            // Btn_Editar_Usuario
            // 
            this.Btn_Editar_Usuario.Location = new System.Drawing.Point(259, 406);
            this.Btn_Editar_Usuario.Name = "Btn_Editar_Usuario";
            this.Btn_Editar_Usuario.Size = new System.Drawing.Size(230, 30);
            this.Btn_Editar_Usuario.TabIndex = 6;
            this.Btn_Editar_Usuario.Text = "Registrar Cambios";
            this.Btn_Editar_Usuario.UseSelectable = true;
            this.Btn_Editar_Usuario.Click += new System.EventHandler(this.Btn_Editar_Usuario_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.Lbl_Usuario_Editar_Usuario);
            this.groupBox2.Controls.Add(this.Btn_Buscar_Usuario);
            this.groupBox2.Controls.Add(this.Txt_Buscar_Usuario_Editar);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(637, 138);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Busqueda";
            // 
            // Lbl_Usuario_Editar_Usuario
            // 
            this.Lbl_Usuario_Editar_Usuario.AutoSize = true;
            this.Lbl_Usuario_Editar_Usuario.Location = new System.Drawing.Point(147, 31);
            this.Lbl_Usuario_Editar_Usuario.Name = "Lbl_Usuario_Editar_Usuario";
            this.Lbl_Usuario_Editar_Usuario.Size = new System.Drawing.Size(95, 19);
            this.Lbl_Usuario_Editar_Usuario.TabIndex = 2;
            this.Lbl_Usuario_Editar_Usuario.Text = "Buscar Usuario";
            this.Lbl_Usuario_Editar_Usuario.Click += new System.EventHandler(this.Lbl_Usuario_Editar_Usuario_Click);
            // 
            // Btn_Buscar_Usuario
            // 
            this.Btn_Buscar_Usuario.Location = new System.Drawing.Point(259, 77);
            this.Btn_Buscar_Usuario.Name = "Btn_Buscar_Usuario";
            this.Btn_Buscar_Usuario.Size = new System.Drawing.Size(230, 30);
            this.Btn_Buscar_Usuario.TabIndex = 1;
            this.Btn_Buscar_Usuario.Text = "Buscar";
            this.Btn_Buscar_Usuario.UseSelectable = true;
            this.Btn_Buscar_Usuario.Click += new System.EventHandler(this.Btn_Buscar_Usuario_Click);
            // 
            // Txt_Buscar_Usuario_Editar
            // 
            // 
            // 
            // 
            this.Txt_Buscar_Usuario_Editar.CustomButton.Image = null;
            this.Txt_Buscar_Usuario_Editar.CustomButton.Location = new System.Drawing.Point(206, 1);
            this.Txt_Buscar_Usuario_Editar.CustomButton.Name = "";
            this.Txt_Buscar_Usuario_Editar.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.Txt_Buscar_Usuario_Editar.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Txt_Buscar_Usuario_Editar.CustomButton.TabIndex = 1;
            this.Txt_Buscar_Usuario_Editar.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Txt_Buscar_Usuario_Editar.CustomButton.UseSelectable = true;
            this.Txt_Buscar_Usuario_Editar.CustomButton.Visible = false;
            this.Txt_Buscar_Usuario_Editar.Lines = new string[0];
            this.Txt_Buscar_Usuario_Editar.Location = new System.Drawing.Point(259, 31);
            this.Txt_Buscar_Usuario_Editar.MaxLength = 32767;
            this.Txt_Buscar_Usuario_Editar.Name = "Txt_Buscar_Usuario_Editar";
            this.Txt_Buscar_Usuario_Editar.PasswordChar = '\0';
            this.Txt_Buscar_Usuario_Editar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Txt_Buscar_Usuario_Editar.SelectedText = "";
            this.Txt_Buscar_Usuario_Editar.SelectionLength = 0;
            this.Txt_Buscar_Usuario_Editar.SelectionStart = 0;
            this.Txt_Buscar_Usuario_Editar.ShortcutsEnabled = true;
            this.Txt_Buscar_Usuario_Editar.Size = new System.Drawing.Size(230, 25);
            this.Txt_Buscar_Usuario_Editar.TabIndex = 0;
            this.Txt_Buscar_Usuario_Editar.UseSelectable = true;
            this.Txt_Buscar_Usuario_Editar.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Txt_Buscar_Usuario_Editar.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.Txt_Buscar_Usuario_Editar.Click += new System.EventHandler(this.Txt_Buscar_Usuario_Editar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.Txt_Usuario_Editar);
            this.groupBox3.Controls.Add(this.Txt_Password_Editar);
            this.groupBox3.Controls.Add(this.Txt_Empleado_Editar);
            this.groupBox3.Controls.Add(this.Cmb_TipoAcceso_Editar);
            this.groupBox3.Controls.Add(this.metroLabel7);
            this.groupBox3.Controls.Add(this.metroLabel8);
            this.groupBox3.Controls.Add(this.metroLabel9);
            this.groupBox3.Controls.Add(this.metroLabel10);
            this.groupBox3.Location = new System.Drawing.Point(0, 163);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(634, 207);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos del Usuario";
            // 
            // Txt_Usuario_Editar
            // 
            // 
            // 
            // 
            this.Txt_Usuario_Editar.CustomButton.Image = null;
            this.Txt_Usuario_Editar.CustomButton.Location = new System.Drawing.Point(206, 1);
            this.Txt_Usuario_Editar.CustomButton.Name = "";
            this.Txt_Usuario_Editar.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.Txt_Usuario_Editar.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Txt_Usuario_Editar.CustomButton.TabIndex = 1;
            this.Txt_Usuario_Editar.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Txt_Usuario_Editar.CustomButton.UseSelectable = true;
            this.Txt_Usuario_Editar.CustomButton.Visible = false;
            this.Txt_Usuario_Editar.Lines = new string[0];
            this.Txt_Usuario_Editar.Location = new System.Drawing.Point(259, 24);
            this.Txt_Usuario_Editar.MaxLength = 32767;
            this.Txt_Usuario_Editar.Name = "Txt_Usuario_Editar";
            this.Txt_Usuario_Editar.PasswordChar = '\0';
            this.Txt_Usuario_Editar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Txt_Usuario_Editar.SelectedText = "";
            this.Txt_Usuario_Editar.SelectionLength = 0;
            this.Txt_Usuario_Editar.SelectionStart = 0;
            this.Txt_Usuario_Editar.ShortcutsEnabled = true;
            this.Txt_Usuario_Editar.Size = new System.Drawing.Size(230, 25);
            this.Txt_Usuario_Editar.TabIndex = 17;
            this.Txt_Usuario_Editar.UseSelectable = true;
            this.Txt_Usuario_Editar.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Txt_Usuario_Editar.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.Txt_Empleado_Editar.Location = new System.Drawing.Point(259, 121);
            this.Txt_Empleado_Editar.MaxLength = 32767;
            this.Txt_Empleado_Editar.Name = "Txt_Empleado_Editar";
            this.Txt_Empleado_Editar.PasswordChar = '\0';
            this.Txt_Empleado_Editar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Txt_Empleado_Editar.SelectedText = "";
            this.Txt_Empleado_Editar.SelectionLength = 0;
            this.Txt_Empleado_Editar.SelectionStart = 0;
            this.Txt_Empleado_Editar.ShortcutsEnabled = true;
            this.Txt_Empleado_Editar.Size = new System.Drawing.Size(230, 25);
            this.Txt_Empleado_Editar.TabIndex = 15;
            this.Txt_Empleado_Editar.UseSelectable = true;
            this.Txt_Empleado_Editar.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Txt_Empleado_Editar.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Cmb_TipoAcceso_Editar
            // 
            this.Cmb_TipoAcceso_Editar.FormattingEnabled = true;
            this.Cmb_TipoAcceso_Editar.ItemHeight = 23;
            this.Cmb_TipoAcceso_Editar.Location = new System.Drawing.Point(259, 163);
            this.Cmb_TipoAcceso_Editar.Name = "Cmb_TipoAcceso_Editar";
            this.Cmb_TipoAcceso_Editar.Size = new System.Drawing.Size(230, 29);
            this.Cmb_TipoAcceso_Editar.TabIndex = 14;
            this.Cmb_TipoAcceso_Editar.UseSelectable = true;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(147, 163);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(99, 19);
            this.metroLabel7.TabIndex = 13;
            this.metroLabel7.Text = "Tipo de Acceso";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(147, 121);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(69, 19);
            this.metroLabel8.TabIndex = 12;
            this.metroLabel8.Text = "Empleado";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(147, 72);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(75, 19);
            this.metroLabel9.TabIndex = 11;
            this.metroLabel9.Text = "Contraseña";
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(147, 30);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(57, 19);
            this.metroLabel10.TabIndex = 10;
            this.metroLabel10.Text = " Usuario";
            // 
            // Modulo_Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "Modulo_Usuario";
            this.Size = new System.Drawing.Size(651, 540);
            this.Load += new System.EventHandler(this.Modulo_Usuario_Load);
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
        private System.Windows.Forms.GroupBox groupBox_Datos_Usuario;
        private MetroFramework.Controls.MetroTextBox Txt_Usuario_Registrar;
        private MetroFramework.Controls.MetroTextBox Txt_Password_Registrar;
        private MetroFramework.Controls.MetroTextBox Txt_Empleado_Registrar;
        private MetroFramework.Controls.MetroComboBox Cmb_TipoAcceso_Registrar;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroLabel Lbl_Usuario_Editar_Usuario;
        private MetroFramework.Controls.MetroButton Btn_Buscar_Usuario;
        private MetroFramework.Controls.MetroTextBox Txt_Buscar_Usuario_Editar;
        private System.Windows.Forms.GroupBox groupBox3;
        private MetroFramework.Controls.MetroTextBox Txt_Usuario_Editar;
        private MetroFramework.Controls.MetroTextBox Txt_Password_Editar;
        private MetroFramework.Controls.MetroTextBox Txt_Empleado_Editar;
        private MetroFramework.Controls.MetroComboBox Cmb_TipoAcceso_Editar;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroButton Btn_Registrar_Usuario;
        private MetroFramework.Controls.MetroButton Btn_Editar_Usuario;
    }
}
