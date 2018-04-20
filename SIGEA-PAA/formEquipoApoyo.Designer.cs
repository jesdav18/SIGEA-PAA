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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Btn_Salir = new MetroFramework.Controls.MetroButton();
            this.btn_Reportes = new MetroFramework.Controls.MetroButton();
            this.btn_Asistencia = new MetroFramework.Controls.MetroButton();
            this.btn_Estudiante = new MetroFramework.Controls.MetroButton();
            this.btn_Inscripcion = new MetroFramework.Controls.MetroButton();
            this.Panel1 = new MetroFramework.Controls.MetroPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelUsuario = new MetroFramework.Controls.MetroLabel();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.Btn_Salir);
            this.groupBox1.Controls.Add(this.btn_Reportes);
            this.groupBox1.Controls.Add(this.btn_Asistencia);
            this.groupBox1.Controls.Add(this.btn_Estudiante);
            this.groupBox1.Controls.Add(this.btn_Inscripcion);
            this.groupBox1.Location = new System.Drawing.Point(39, 96);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(350, 540);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operaciones";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Btn_Salir
            // 
            this.Btn_Salir.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Btn_Salir.Location = new System.Drawing.Point(3, 514);
            this.Btn_Salir.Name = "Btn_Salir";
            this.Btn_Salir.Size = new System.Drawing.Size(344, 23);
            this.Btn_Salir.TabIndex = 4;
            this.Btn_Salir.Text = "Cerrar Sesion";
            this.Btn_Salir.UseSelectable = true;
            this.Btn_Salir.Click += new System.EventHandler(this.Btn_Salir_Click);
            // 
            // btn_Reportes
            // 
            this.btn_Reportes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Reportes.Location = new System.Drawing.Point(21, 372);
            this.btn_Reportes.Name = "btn_Reportes";
            this.btn_Reportes.Size = new System.Drawing.Size(280, 30);
            this.btn_Reportes.TabIndex = 3;
            this.btn_Reportes.Text = "Reportes";
            this.btn_Reportes.UseSelectable = true;
            this.btn_Reportes.Click += new System.EventHandler(this.btn_Reportes_Click_1);
            // 
            // btn_Asistencia
            // 
            this.btn_Asistencia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Asistencia.Location = new System.Drawing.Point(21, 298);
            this.btn_Asistencia.Name = "btn_Asistencia";
            this.btn_Asistencia.Size = new System.Drawing.Size(280, 30);
            this.btn_Asistencia.TabIndex = 2;
            this.btn_Asistencia.Text = "Registrar Asistencia";
            this.btn_Asistencia.UseSelectable = true;
            this.btn_Asistencia.Click += new System.EventHandler(this.btn_Asistencia_Click_1);
            // 
            // btn_Estudiante
            // 
            this.btn_Estudiante.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Estudiante.Location = new System.Drawing.Point(21, 223);
            this.btn_Estudiante.Name = "btn_Estudiante";
            this.btn_Estudiante.Size = new System.Drawing.Size(280, 30);
            this.btn_Estudiante.TabIndex = 1;
            this.btn_Estudiante.Text = "Administracion Estudiante";
            this.btn_Estudiante.UseSelectable = true;
            this.btn_Estudiante.Click += new System.EventHandler(this.btn_Estudiante_Click_1);
            // 
            // btn_Inscripcion
            // 
            this.btn_Inscripcion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Inscripcion.AutoSize = true;
            this.btn_Inscripcion.Location = new System.Drawing.Point(21, 141);
            this.btn_Inscripcion.Name = "btn_Inscripcion";
            this.btn_Inscripcion.Size = new System.Drawing.Size(280, 30);
            this.btn_Inscripcion.TabIndex = 0;
            this.btn_Inscripcion.Text = "Inscripcion";
            this.btn_Inscripcion.UseSelectable = true;
            this.btn_Inscripcion.Click += new System.EventHandler(this.btn_Inscripcion_Click);
            // 
            // Panel1
            // 
            this.Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel1.HorizontalScrollbarBarColor = true;
            this.Panel1.HorizontalScrollbarHighlightOnWheel = false;
            this.Panel1.HorizontalScrollbarSize = 10;
            this.Panel1.Location = new System.Drawing.Point(482, 96);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(651, 540);
            this.Panel1.TabIndex = 2;
            this.Panel1.VerticalScrollbarBarColor = true;
            this.Panel1.VerticalScrollbarHighlightOnWheel = false;
            this.Panel1.VerticalScrollbarSize = 10;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelUsuario);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(20, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1206, 32);
            this.panel2.TabIndex = 3;
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelUsuario.Location = new System.Drawing.Point(0, 0);
            this.labelUsuario.Margin = new System.Windows.Forms.Padding(3, 0, 3, 20);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(83, 19);
            this.labelUsuario.TabIndex = 1;
            this.labelUsuario.Text = "metroLabel1";
            // 
            // formEquipoApoyo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1246, 658);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "formEquipoApoyo";
            this.Text = "SIGEA-PAA | Equipo de Apoyo";
            this.Load += new System.EventHandler(this.formEquipoApoyo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroButton btn_Reportes;
        private MetroFramework.Controls.MetroButton btn_Asistencia;
        private MetroFramework.Controls.MetroButton btn_Estudiante;
        private MetroFramework.Controls.MetroButton btn_Inscripcion;
        private MetroFramework.Controls.MetroPanel Panel1;
        private MetroFramework.Controls.MetroButton Btn_Salir;
        private System.Windows.Forms.Panel panel2;
        private MetroFramework.Controls.MetroLabel labelUsuario;
    }
}