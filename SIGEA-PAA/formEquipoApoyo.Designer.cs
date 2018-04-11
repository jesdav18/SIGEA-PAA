namespace SIGEA_PAA
{
    partial class formEquipoApoyo
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
            this.labelUsuario = new MetroFramework.Controls.MetroLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Reportes = new MetroFramework.Controls.MetroButton();
            this.btn_Asistencia = new MetroFramework.Controls.MetroButton();
            this.btn_Estudiante = new MetroFramework.Controls.MetroButton();
            this.btn_Inscripcion = new MetroFramework.Controls.MetroButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelUsuario
            // 
            this.labelUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.Location = new System.Drawing.Point(20, 60);
            this.labelUsuario.Margin = new System.Windows.Forms.Padding(3, 0, 3, 20);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(81, 19);
            this.labelUsuario.TabIndex = 0;
            this.labelUsuario.Text = "metroLabel1";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btn_Reportes);
            this.groupBox1.Controls.Add(this.btn_Asistencia);
            this.groupBox1.Controls.Add(this.btn_Estudiante);
            this.groupBox1.Controls.Add(this.btn_Inscripcion);
            this.groupBox1.Location = new System.Drawing.Point(24, 94);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 549);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operaciones";
            // 
            // btn_Reportes
            // 
            this.btn_Reportes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Reportes.Location = new System.Drawing.Point(21, 385);
            this.btn_Reportes.Name = "btn_Reportes";
            this.btn_Reportes.Size = new System.Drawing.Size(159, 23);
            this.btn_Reportes.TabIndex = 3;
            this.btn_Reportes.Text = "Reportes";
            this.btn_Reportes.UseSelectable = true;
            // 
            // btn_Asistencia
            // 
            this.btn_Asistencia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Asistencia.Location = new System.Drawing.Point(21, 311);
            this.btn_Asistencia.Name = "btn_Asistencia";
            this.btn_Asistencia.Size = new System.Drawing.Size(159, 23);
            this.btn_Asistencia.TabIndex = 2;
            this.btn_Asistencia.Text = "Registrar Asistencia";
            this.btn_Asistencia.UseSelectable = true;
            // 
            // btn_Estudiante
            // 
            this.btn_Estudiante.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Estudiante.Location = new System.Drawing.Point(21, 236);
            this.btn_Estudiante.Name = "btn_Estudiante";
            this.btn_Estudiante.Size = new System.Drawing.Size(159, 23);
            this.btn_Estudiante.TabIndex = 1;
            this.btn_Estudiante.Text = "Administracion Estudiante";
            this.btn_Estudiante.UseSelectable = true;
            // 
            // btn_Inscripcion
            // 
            this.btn_Inscripcion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Inscripcion.Location = new System.Drawing.Point(21, 157);
            this.btn_Inscripcion.Name = "btn_Inscripcion";
            this.btn_Inscripcion.Size = new System.Drawing.Size(159, 23);
            this.btn_Inscripcion.TabIndex = 0;
            this.btn_Inscripcion.Text = "Administracion Inscripcion";
            this.btn_Inscripcion.UseSelectable = true;
            this.btn_Inscripcion.Click += new System.EventHandler(this.btn_Inscripcion_Click);
            // 
            // formEquipoApoyo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1246, 658);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelUsuario);
            this.MaximizeBox = false;
            this.Name = "formEquipoApoyo";
            this.Text = "SIGEA-PAA | Equipo de Apoyo";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.formEquipoApoyo_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel labelUsuario;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroButton btn_Reportes;
        private MetroFramework.Controls.MetroButton btn_Asistencia;
        private MetroFramework.Controls.MetroButton btn_Estudiante;
        private MetroFramework.Controls.MetroButton btn_Inscripcion;
    }
}