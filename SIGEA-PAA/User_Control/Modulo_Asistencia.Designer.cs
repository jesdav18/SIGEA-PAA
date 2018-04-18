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
            this.Lbl_CUenta = new MetroFramework.Controls.MetroLabel();
            this.Btn_Asistencia = new MetroFramework.Controls.MetroButton();
            this.Txt_Cuenta = new System.Windows.Forms.MaskedTextBox();
            this.gb_Asistencia.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_Asistencia
            // 
            this.gb_Asistencia.Controls.Add(this.Txt_Cuenta);
            this.gb_Asistencia.Controls.Add(this.Lbl_CUenta);
            this.gb_Asistencia.Controls.Add(this.Btn_Asistencia);
            this.gb_Asistencia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gb_Asistencia.Location = new System.Drawing.Point(0, 0);
            this.gb_Asistencia.Name = "gb_Asistencia";
            this.gb_Asistencia.Size = new System.Drawing.Size(651, 540);
            this.gb_Asistencia.TabIndex = 0;
            this.gb_Asistencia.TabStop = false;
            this.gb_Asistencia.Text = "Asistencia";
            // 
            // Lbl_CUenta
            // 
            this.Lbl_CUenta.AutoSize = true;
            this.Lbl_CUenta.Location = new System.Drawing.Point(154, 90);
            this.Lbl_CUenta.Name = "Lbl_CUenta";
            this.Lbl_CUenta.Size = new System.Drawing.Size(122, 19);
            this.Lbl_CUenta.TabIndex = 4;
            this.Lbl_CUenta.Text = "Numero de Cuenta";
            // 
            // Btn_Asistencia
            // 
            this.Btn_Asistencia.Location = new System.Drawing.Point(221, 179);
            this.Btn_Asistencia.Name = "Btn_Asistencia";
            this.Btn_Asistencia.Size = new System.Drawing.Size(260, 25);
            this.Btn_Asistencia.TabIndex = 3;
            this.Btn_Asistencia.Text = "Registrar";
            this.Btn_Asistencia.UseSelectable = true;
            this.Btn_Asistencia.Click += new System.EventHandler(this.Btn_Asistencia_Click);
            // 
            // Txt_Cuenta
            // 
            this.Txt_Cuenta.Location = new System.Drawing.Point(294, 90);
            this.Txt_Cuenta.Mask = "0000-0000-000";
            this.Txt_Cuenta.Name = "Txt_Cuenta";
            this.Txt_Cuenta.Size = new System.Drawing.Size(187, 20);
            this.Txt_Cuenta.TabIndex = 1;
            // 
            // Modulo_Asistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gb_Asistencia);
            this.Name = "Modulo_Asistencia";
            this.Size = new System.Drawing.Size(651, 540);
            this.Load += new System.EventHandler(this.Modulo_Asistencia_Load);
            this.gb_Asistencia.ResumeLayout(false);
            this.gb_Asistencia.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_Asistencia;
        private MetroFramework.Controls.MetroLabel Lbl_CUenta;
        private MetroFramework.Controls.MetroButton Btn_Asistencia;
        private System.Windows.Forms.MaskedTextBox Txt_Cuenta;
    }
}
