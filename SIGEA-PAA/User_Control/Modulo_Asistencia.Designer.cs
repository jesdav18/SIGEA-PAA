namespace SIGEA_PAA.User_Control
{
    partial class Modulo_Asistencia
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
            this.gb_Asistencia = new System.Windows.Forms.GroupBox();
            this.Txt_cuenta = new MetroFramework.Controls.MetroTextBox();
            this.Lbl_CUenta = new MetroFramework.Controls.MetroLabel();
            this.Btn_Asistencia = new MetroFramework.Controls.MetroButton();
            this.gb_Asistencia.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_Asistencia
            // 
            this.gb_Asistencia.Controls.Add(this.Txt_cuenta);
            this.gb_Asistencia.Controls.Add(this.Lbl_CUenta);
            this.gb_Asistencia.Controls.Add(this.Btn_Asistencia);
            this.gb_Asistencia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gb_Asistencia.Location = new System.Drawing.Point(0, 0);
            this.gb_Asistencia.Name = "gb_Asistencia";
            this.gb_Asistencia.Size = new System.Drawing.Size(448, 239);
            this.gb_Asistencia.TabIndex = 0;
            this.gb_Asistencia.TabStop = false;
            this.gb_Asistencia.Text = "Asistencia";
            // 
            // Txt_cuenta
            // 
            // 
            // 
            // 
            this.Txt_cuenta.CustomButton.Image = null;
            this.Txt_cuenta.CustomButton.Location = new System.Drawing.Point(210, 1);
            this.Txt_cuenta.CustomButton.Name = "";
            this.Txt_cuenta.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.Txt_cuenta.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Txt_cuenta.CustomButton.TabIndex = 1;
            this.Txt_cuenta.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Txt_cuenta.CustomButton.UseSelectable = true;
            this.Txt_cuenta.CustomButton.Visible = false;
            this.Txt_cuenta.Lines = new string[0];
            this.Txt_cuenta.Location = new System.Drawing.Point(199, 78);
            this.Txt_cuenta.MaxLength = 32767;
            this.Txt_cuenta.Name = "Txt_cuenta";
            this.Txt_cuenta.PasswordChar = '\0';
            this.Txt_cuenta.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Txt_cuenta.SelectedText = "";
            this.Txt_cuenta.SelectionLength = 0;
            this.Txt_cuenta.SelectionStart = 0;
            this.Txt_cuenta.ShortcutsEnabled = true;
            this.Txt_cuenta.Size = new System.Drawing.Size(234, 25);
            this.Txt_cuenta.TabIndex = 5;
            this.Txt_cuenta.UseSelectable = true;
            this.Txt_cuenta.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Txt_cuenta.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Lbl_CUenta
            // 
            this.Lbl_CUenta.AutoSize = true;
            this.Lbl_CUenta.Location = new System.Drawing.Point(30, 84);
            this.Lbl_CUenta.Name = "Lbl_CUenta";
            this.Lbl_CUenta.Size = new System.Drawing.Size(122, 19);
            this.Lbl_CUenta.TabIndex = 4;
            this.Lbl_CUenta.Text = "Numero de Cuenta";
            // 
            // Btn_Asistencia
            // 
            this.Btn_Asistencia.Location = new System.Drawing.Point(97, 173);
            this.Btn_Asistencia.Name = "Btn_Asistencia";
            this.Btn_Asistencia.Size = new System.Drawing.Size(260, 25);
            this.Btn_Asistencia.TabIndex = 3;
            this.Btn_Asistencia.Text = "Registrar";
            this.Btn_Asistencia.UseSelectable = true;
            // 
            // Modulo_Asistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gb_Asistencia);
            this.Name = "Modulo_Asistencia";
            this.Size = new System.Drawing.Size(448, 239);
            this.Load += new System.EventHandler(this.Modulo_Asistencia_Load);
            this.gb_Asistencia.ResumeLayout(false);
            this.gb_Asistencia.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_Asistencia;
        private MetroFramework.Controls.MetroTextBox Txt_cuenta;
        private MetroFramework.Controls.MetroLabel Lbl_CUenta;
        private MetroFramework.Controls.MetroButton Btn_Asistencia;
    }
}
