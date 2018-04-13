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
            this.gb_Estudiante = new System.Windows.Forms.GroupBox();
            this.Btn_Registrar = new MetroFramework.Controls.MetroButton();
            this.Txt_Identidad = new MetroFramework.Controls.MetroTextBox();
            this.Txt_Nombre = new MetroFramework.Controls.MetroTextBox();
            this.Txt_Cuenta = new MetroFramework.Controls.MetroTextBox();
            this.Lbl_Carrera = new MetroFramework.Controls.MetroLabel();
            this.Lbl_Identidad = new MetroFramework.Controls.MetroLabel();
            this.Lbl_Nombre = new MetroFramework.Controls.MetroLabel();
            this.Lbl_Cuenta = new MetroFramework.Controls.MetroLabel();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.gb_Estudiante.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_Estudiante
            // 
            this.gb_Estudiante.Controls.Add(this.metroComboBox1);
            this.gb_Estudiante.Controls.Add(this.Btn_Registrar);
            this.gb_Estudiante.Controls.Add(this.Txt_Identidad);
            this.gb_Estudiante.Controls.Add(this.Txt_Nombre);
            this.gb_Estudiante.Controls.Add(this.Txt_Cuenta);
            this.gb_Estudiante.Controls.Add(this.Lbl_Carrera);
            this.gb_Estudiante.Controls.Add(this.Lbl_Identidad);
            this.gb_Estudiante.Controls.Add(this.Lbl_Nombre);
            this.gb_Estudiante.Controls.Add(this.Lbl_Cuenta);
            this.gb_Estudiante.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gb_Estudiante.Location = new System.Drawing.Point(0, 0);
            this.gb_Estudiante.Name = "gb_Estudiante";
            this.gb_Estudiante.Size = new System.Drawing.Size(433, 437);
            this.gb_Estudiante.TabIndex = 0;
            this.gb_Estudiante.TabStop = false;
            this.gb_Estudiante.Text = "Registro de Estudiante";
            this.gb_Estudiante.Enter += new System.EventHandler(this.gb_Estudiante_Enter);
            // 
            // Btn_Registrar
            // 
            this.Btn_Registrar.Location = new System.Drawing.Point(75, 366);
            this.Btn_Registrar.Name = "Btn_Registrar";
            this.Btn_Registrar.Size = new System.Drawing.Size(260, 25);
            this.Btn_Registrar.TabIndex = 14;
            this.Btn_Registrar.Text = "Registrar";
            this.Btn_Registrar.UseSelectable = true;
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
            this.Txt_Identidad.Location = new System.Drawing.Point(170, 193);
            this.Txt_Identidad.MaxLength = 32767;
            this.Txt_Identidad.Name = "Txt_Identidad";
            this.Txt_Identidad.PasswordChar = '\0';
            this.Txt_Identidad.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Txt_Identidad.SelectedText = "";
            this.Txt_Identidad.SelectionLength = 0;
            this.Txt_Identidad.SelectionStart = 0;
            this.Txt_Identidad.ShortcutsEnabled = true;
            this.Txt_Identidad.Size = new System.Drawing.Size(234, 25);
            this.Txt_Identidad.TabIndex = 12;
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
            this.Txt_Nombre.Location = new System.Drawing.Point(170, 122);
            this.Txt_Nombre.MaxLength = 32767;
            this.Txt_Nombre.Name = "Txt_Nombre";
            this.Txt_Nombre.PasswordChar = '\0';
            this.Txt_Nombre.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Txt_Nombre.SelectedText = "";
            this.Txt_Nombre.SelectionLength = 0;
            this.Txt_Nombre.SelectionStart = 0;
            this.Txt_Nombre.ShortcutsEnabled = true;
            this.Txt_Nombre.Size = new System.Drawing.Size(234, 25);
            this.Txt_Nombre.TabIndex = 11;
            this.Txt_Nombre.UseSelectable = true;
            this.Txt_Nombre.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Txt_Nombre.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.Txt_Nombre.Click += new System.EventHandler(this.Txt_Nombre_Click);
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
            this.Txt_Cuenta.Location = new System.Drawing.Point(170, 46);
            this.Txt_Cuenta.MaxLength = 13;
            this.Txt_Cuenta.Name = "Txt_Cuenta";
            this.Txt_Cuenta.PasswordChar = '\0';
            this.Txt_Cuenta.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Txt_Cuenta.SelectedText = "";
            this.Txt_Cuenta.SelectionLength = 0;
            this.Txt_Cuenta.SelectionStart = 0;
            this.Txt_Cuenta.ShortcutsEnabled = true;
            this.Txt_Cuenta.Size = new System.Drawing.Size(234, 25);
            this.Txt_Cuenta.TabIndex = 10;
            this.Txt_Cuenta.UseSelectable = true;
            this.Txt_Cuenta.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Txt_Cuenta.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Lbl_Carrera
            // 
            this.Lbl_Carrera.AutoSize = true;
            this.Lbl_Carrera.Location = new System.Drawing.Point(59, 276);
            this.Lbl_Carrera.Name = "Lbl_Carrera";
            this.Lbl_Carrera.Size = new System.Drawing.Size(54, 19);
            this.Lbl_Carrera.TabIndex = 17;
            this.Lbl_Carrera.Text = "Carrera";
            // 
            // Lbl_Identidad
            // 
            this.Lbl_Identidad.AutoSize = true;
            this.Lbl_Identidad.Location = new System.Drawing.Point(59, 197);
            this.Lbl_Identidad.Name = "Lbl_Identidad";
            this.Lbl_Identidad.Size = new System.Drawing.Size(83, 19);
            this.Lbl_Identidad.TabIndex = 16;
            this.Lbl_Identidad.Text = "N° Identidad";
            // 
            // Lbl_Nombre
            // 
            this.Lbl_Nombre.AutoSize = true;
            this.Lbl_Nombre.Location = new System.Drawing.Point(59, 126);
            this.Lbl_Nombre.Name = "Lbl_Nombre";
            this.Lbl_Nombre.Size = new System.Drawing.Size(59, 19);
            this.Lbl_Nombre.TabIndex = 15;
            this.Lbl_Nombre.Text = "Nombre";
            // 
            // Lbl_Cuenta
            // 
            this.Lbl_Cuenta.AutoSize = true;
            this.Lbl_Cuenta.Location = new System.Drawing.Point(55, 50);
            this.Lbl_Cuenta.Name = "Lbl_Cuenta";
            this.Lbl_Cuenta.Size = new System.Drawing.Size(88, 19);
            this.Lbl_Cuenta.TabIndex = 9;
            this.Lbl_Cuenta.Text = "N° de Cuenta";
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Location = new System.Drawing.Point(170, 276);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(234, 29);
            this.metroComboBox1.TabIndex = 18;
            this.metroComboBox1.UseSelectable = true;
            // 
            // Modulo_Estudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gb_Estudiante);
            this.Name = "Modulo_Estudiante";
            this.Size = new System.Drawing.Size(433, 437);
            this.Load += new System.EventHandler(this.Modulo_Estudiante_Load);
            this.gb_Estudiante.ResumeLayout(false);
            this.gb_Estudiante.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_Estudiante;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private MetroFramework.Controls.MetroButton Btn_Registrar;
        private MetroFramework.Controls.MetroTextBox Txt_Identidad;
        private MetroFramework.Controls.MetroTextBox Txt_Nombre;
        private MetroFramework.Controls.MetroTextBox Txt_Cuenta;
        private MetroFramework.Controls.MetroLabel Lbl_Carrera;
        private MetroFramework.Controls.MetroLabel Lbl_Identidad;
        private MetroFramework.Controls.MetroLabel Lbl_Nombre;
        private MetroFramework.Controls.MetroLabel Lbl_Cuenta;
    }
}
