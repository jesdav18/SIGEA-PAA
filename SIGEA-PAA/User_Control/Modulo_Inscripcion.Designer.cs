namespace SIGEA_PAA.User_Control
{
    partial class Modulo_Inscripcion
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.linkRegistrarEstudiante = new MetroFramework.Controls.MetroLink();
            this.Txt_Cuenta = new System.Windows.Forms.MaskedTextBox();
            this.Btn_Buscar = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Txt_Carrera = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.Txt_Estado = new MetroFramework.Controls.MetroTextBox();
            this.Txt_Identidad = new MetroFramework.Controls.MetroTextBox();
            this.Txt_Cuenta2 = new MetroFramework.Controls.MetroTextBox();
            this.Txt_Nombre = new MetroFramework.Controls.MetroTextBox();
            this.Btn_Inscribir = new MetroFramework.Controls.MetroButton();
            this.toolTipEnlace = new System.Windows.Forms.ToolTip(this.components);
            this.labelPAA = new MetroFramework.Controls.MetroLabel();
            this.labelFechaPAA = new MetroFramework.Controls.MetroLabel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.linkRegistrarEstudiante);
            this.groupBox1.Controls.Add(this.Txt_Cuenta);
            this.groupBox1.Controls.Add(this.Btn_Buscar);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Location = new System.Drawing.Point(14, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(625, 191);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Busqueda de Estudiante";
            // 
            // linkRegistrarEstudiante
            // 
            this.linkRegistrarEstudiante.Location = new System.Drawing.Point(182, 166);
            this.linkRegistrarEstudiante.Name = "linkRegistrarEstudiante";
            this.linkRegistrarEstudiante.Size = new System.Drawing.Size(267, 19);
            this.linkRegistrarEstudiante.TabIndex = 6;
            this.linkRegistrarEstudiante.Text = "¿Registrar Estudiante?";
            this.toolTipEnlace.SetToolTip(this.linkRegistrarEstudiante, "Haga Clic en este enlace para registrar al Estudiante");
            this.linkRegistrarEstudiante.UseSelectable = true;
            this.linkRegistrarEstudiante.Visible = false;
            this.linkRegistrarEstudiante.Click += new System.EventHandler(this.linkRegistrarEstudiante_Click);
            // 
            // Txt_Cuenta
            // 
            this.Txt_Cuenta.Location = new System.Drawing.Point(291, 56);
            this.Txt_Cuenta.Mask = "0000-0000-000";
            this.Txt_Cuenta.Name = "Txt_Cuenta";
            this.Txt_Cuenta.PromptChar = ' ';
            this.Txt_Cuenta.Size = new System.Drawing.Size(83, 20);
            this.Txt_Cuenta.TabIndex = 0;
            this.Txt_Cuenta.TextChanged += new System.EventHandler(this.Txt_Cuenta_TextChanged);
            // 
            // Btn_Buscar
            // 
            this.Btn_Buscar.Location = new System.Drawing.Point(182, 100);
            this.Btn_Buscar.Name = "Btn_Buscar";
            this.Btn_Buscar.Size = new System.Drawing.Size(260, 25);
            this.Btn_Buscar.TabIndex = 1;
            this.Btn_Buscar.Text = "Buscar";
            this.Btn_Buscar.UseSelectable = true;
            this.Btn_Buscar.Click += new System.EventHandler(this.Btn_Buscar_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(115, 56);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(115, 19);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "Ingrese N° Cuenta";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Txt_Carrera);
            this.groupBox2.Controls.Add(this.metroLabel6);
            this.groupBox2.Controls.Add(this.metroLabel5);
            this.groupBox2.Controls.Add(this.metroLabel4);
            this.groupBox2.Controls.Add(this.metroLabel3);
            this.groupBox2.Controls.Add(this.metroLabel2);
            this.groupBox2.Controls.Add(this.Txt_Estado);
            this.groupBox2.Controls.Add(this.Txt_Identidad);
            this.groupBox2.Controls.Add(this.Txt_Cuenta2);
            this.groupBox2.Controls.Add(this.Txt_Nombre);
            this.groupBox2.Location = new System.Drawing.Point(14, 200);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(625, 258);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos del Estudiante";
            // 
            // Txt_Carrera
            // 
            // 
            // 
            // 
            this.Txt_Carrera.CustomButton.Image = null;
            this.Txt_Carrera.CustomButton.Location = new System.Drawing.Point(210, 1);
            this.Txt_Carrera.CustomButton.Name = "";
            this.Txt_Carrera.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.Txt_Carrera.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Txt_Carrera.CustomButton.TabIndex = 1;
            this.Txt_Carrera.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Txt_Carrera.CustomButton.UseSelectable = true;
            this.Txt_Carrera.CustomButton.Visible = false;
            this.Txt_Carrera.Lines = new string[0];
            this.Txt_Carrera.Location = new System.Drawing.Point(291, 117);
            this.Txt_Carrera.MaxLength = 32767;
            this.Txt_Carrera.Name = "Txt_Carrera";
            this.Txt_Carrera.PasswordChar = '\0';
            this.Txt_Carrera.ReadOnly = true;
            this.Txt_Carrera.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Txt_Carrera.SelectedText = "";
            this.Txt_Carrera.SelectionLength = 0;
            this.Txt_Carrera.SelectionStart = 0;
            this.Txt_Carrera.ShortcutsEnabled = true;
            this.Txt_Carrera.Size = new System.Drawing.Size(234, 25);
            this.Txt_Carrera.TabIndex = 21;
            this.Txt_Carrera.UseSelectable = true;
            this.Txt_Carrera.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Txt_Carrera.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(115, 123);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(54, 19);
            this.metroLabel6.TabIndex = 20;
            this.metroLabel6.Text = "Carrera";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(115, 214);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(132, 19);
            this.metroLabel5.TabIndex = 19;
            this.metroLabel5.Text = "Estado de Inscripcion";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(115, 170);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(83, 19);
            this.metroLabel4.TabIndex = 18;
            this.metroLabel4.Text = "N° Identidad";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(115, 81);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(69, 19);
            this.metroLabel3.TabIndex = 17;
            this.metroLabel3.Text = "N° Cuenta";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(115, 40);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(59, 19);
            this.metroLabel2.TabIndex = 16;
            this.metroLabel2.Text = "Nombre";
            // 
            // Txt_Estado
            // 
            // 
            // 
            // 
            this.Txt_Estado.CustomButton.Image = null;
            this.Txt_Estado.CustomButton.Location = new System.Drawing.Point(210, 1);
            this.Txt_Estado.CustomButton.Name = "";
            this.Txt_Estado.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.Txt_Estado.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Txt_Estado.CustomButton.TabIndex = 1;
            this.Txt_Estado.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Txt_Estado.CustomButton.UseSelectable = true;
            this.Txt_Estado.CustomButton.Visible = false;
            this.Txt_Estado.Lines = new string[0];
            this.Txt_Estado.Location = new System.Drawing.Point(291, 208);
            this.Txt_Estado.MaxLength = 32767;
            this.Txt_Estado.Name = "Txt_Estado";
            this.Txt_Estado.PasswordChar = '\0';
            this.Txt_Estado.ReadOnly = true;
            this.Txt_Estado.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Txt_Estado.SelectedText = "";
            this.Txt_Estado.SelectionLength = 0;
            this.Txt_Estado.SelectionStart = 0;
            this.Txt_Estado.ShortcutsEnabled = true;
            this.Txt_Estado.Size = new System.Drawing.Size(234, 25);
            this.Txt_Estado.TabIndex = 15;
            this.Txt_Estado.UseSelectable = true;
            this.Txt_Estado.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Txt_Estado.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Txt_Identidad
            // 
            // 
            // 
            // 
            this.Txt_Identidad.CustomButton.AutoSize = true;
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
            this.Txt_Identidad.Location = new System.Drawing.Point(291, 164);
            this.Txt_Identidad.MaxLength = 32767;
            this.Txt_Identidad.Name = "Txt_Identidad";
            this.Txt_Identidad.PasswordChar = '\0';
            this.Txt_Identidad.ReadOnly = true;
            this.Txt_Identidad.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Txt_Identidad.SelectedText = "";
            this.Txt_Identidad.SelectionLength = 0;
            this.Txt_Identidad.SelectionStart = 0;
            this.Txt_Identidad.ShortcutsEnabled = true;
            this.Txt_Identidad.Size = new System.Drawing.Size(234, 25);
            this.Txt_Identidad.TabIndex = 14;
            this.Txt_Identidad.UseSelectable = true;
            this.Txt_Identidad.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Txt_Identidad.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Txt_Cuenta2
            // 
            // 
            // 
            // 
            this.Txt_Cuenta2.CustomButton.Image = null;
            this.Txt_Cuenta2.CustomButton.Location = new System.Drawing.Point(210, 1);
            this.Txt_Cuenta2.CustomButton.Name = "";
            this.Txt_Cuenta2.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.Txt_Cuenta2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Txt_Cuenta2.CustomButton.TabIndex = 1;
            this.Txt_Cuenta2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Txt_Cuenta2.CustomButton.UseSelectable = true;
            this.Txt_Cuenta2.CustomButton.Visible = false;
            this.Txt_Cuenta2.Lines = new string[0];
            this.Txt_Cuenta2.Location = new System.Drawing.Point(291, 75);
            this.Txt_Cuenta2.MaxLength = 32767;
            this.Txt_Cuenta2.Name = "Txt_Cuenta2";
            this.Txt_Cuenta2.PasswordChar = '\0';
            this.Txt_Cuenta2.ReadOnly = true;
            this.Txt_Cuenta2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Txt_Cuenta2.SelectedText = "";
            this.Txt_Cuenta2.SelectionLength = 0;
            this.Txt_Cuenta2.SelectionStart = 0;
            this.Txt_Cuenta2.ShortcutsEnabled = true;
            this.Txt_Cuenta2.Size = new System.Drawing.Size(234, 25);
            this.Txt_Cuenta2.TabIndex = 13;
            this.Txt_Cuenta2.UseSelectable = true;
            this.Txt_Cuenta2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Txt_Cuenta2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Txt_Nombre
            // 
            // 
            // 
            // 
            this.Txt_Nombre.CustomButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Txt_Nombre.CustomButton.Image = null;
            this.Txt_Nombre.CustomButton.Location = new System.Drawing.Point(210, 1);
            this.Txt_Nombre.CustomButton.Name = "";
            this.Txt_Nombre.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.Txt_Nombre.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Txt_Nombre.CustomButton.TabIndex = 1;
            this.Txt_Nombre.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Txt_Nombre.CustomButton.UseCompatibleTextRendering = true;
            this.Txt_Nombre.CustomButton.UseSelectable = true;
            this.Txt_Nombre.CustomButton.Visible = false;
            this.Txt_Nombre.Lines = new string[0];
            this.Txt_Nombre.Location = new System.Drawing.Point(291, 34);
            this.Txt_Nombre.MaxLength = 32767;
            this.Txt_Nombre.Name = "Txt_Nombre";
            this.Txt_Nombre.PasswordChar = '\0';
            this.Txt_Nombre.ReadOnly = true;
            this.Txt_Nombre.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Txt_Nombre.SelectedText = "";
            this.Txt_Nombre.SelectionLength = 0;
            this.Txt_Nombre.SelectionStart = 0;
            this.Txt_Nombre.ShortcutsEnabled = true;
            this.Txt_Nombre.Size = new System.Drawing.Size(234, 25);
            this.Txt_Nombre.TabIndex = 12;
            this.Txt_Nombre.UseSelectable = true;
            this.Txt_Nombre.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Txt_Nombre.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Btn_Inscribir
            // 
            this.Btn_Inscribir.Enabled = false;
            this.Btn_Inscribir.Location = new System.Drawing.Point(196, 536);
            this.Btn_Inscribir.Name = "Btn_Inscribir";
            this.Btn_Inscribir.Size = new System.Drawing.Size(260, 25);
            this.Btn_Inscribir.TabIndex = 2;
            this.Btn_Inscribir.Text = "Inscribir";
            this.Btn_Inscribir.UseSelectable = true;
            this.Btn_Inscribir.Click += new System.EventHandler(this.Btn_Inscribir_Click);
            // 
            // labelPAA
            // 
            this.labelPAA.AutoSize = true;
            this.labelPAA.Location = new System.Drawing.Point(129, 477);
            this.labelPAA.Name = "labelPAA";
            this.labelPAA.Size = new System.Drawing.Size(21, 19);
            this.labelPAA.TabIndex = 13;
            this.labelPAA.Text = "--";
            // 
            // labelFechaPAA
            // 
            this.labelFechaPAA.AutoSize = true;
            this.labelFechaPAA.Location = new System.Drawing.Point(305, 477);
            this.labelFechaPAA.Name = "labelFechaPAA";
            this.labelFechaPAA.Size = new System.Drawing.Size(21, 19);
            this.labelFechaPAA.TabIndex = 14;
            this.labelFechaPAA.Text = "--";
            // 
            // Modulo_Inscripcion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.labelFechaPAA);
            this.Controls.Add(this.labelPAA);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Btn_Inscribir);
            this.Name = "Modulo_Inscripcion";
            this.Size = new System.Drawing.Size(651, 619);
            this.Load += new System.EventHandler(this.Modulo_Inscripcion_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroButton Btn_Buscar;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox Txt_Estado;
        private MetroFramework.Controls.MetroTextBox Txt_Identidad;
        private MetroFramework.Controls.MetroTextBox Txt_Cuenta2;
        private MetroFramework.Controls.MetroTextBox Txt_Nombre;
        private MetroFramework.Controls.MetroButton Btn_Inscribir;
        private MetroFramework.Controls.MetroTextBox Txt_Carrera;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private System.Windows.Forms.MaskedTextBox Txt_Cuenta;
        private MetroFramework.Controls.MetroLink linkRegistrarEstudiante;
        private System.Windows.Forms.ToolTip toolTipEnlace;
        private MetroFramework.Controls.MetroLabel labelPAA;
        private MetroFramework.Controls.MetroLabel labelFechaPAA;
    }
}
