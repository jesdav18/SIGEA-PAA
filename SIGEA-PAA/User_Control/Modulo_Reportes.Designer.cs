namespace SIGEA_PAA.User_Control
{
    partial class Modulo_Reportes
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
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.rEstudiantesInscritos = new MetroFramework.Controls.MetroTabPage();
            this.rListadoGeneralAsistencia = new MetroFramework.Controls.MetroTabPage();
            this.rHistorialParticipacion = new MetroFramework.Controls.MetroTabPage();
            this.rAsistencia = new MetroFramework.Controls.MetroTabPage();
            this.documentViewer1 = new DevExpress.XtraPrinting.Preview.DocumentViewer();
            this.metroDateTime1 = new MetroFramework.Controls.MetroDateTime();
            this.metroTabControl1.SuspendLayout();
            this.rEstudiantesInscritos.SuspendLayout();
            this.rListadoGeneralAsistencia.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.rEstudiantesInscritos);
            this.metroTabControl1.Controls.Add(this.rListadoGeneralAsistencia);
            this.metroTabControl1.Controls.Add(this.rHistorialParticipacion);
            this.metroTabControl1.Controls.Add(this.rAsistencia);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.Location = new System.Drawing.Point(0, 0);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 1;
            this.metroTabControl1.Size = new System.Drawing.Size(716, 481);
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.UseSelectable = true;
            // 
            // rEstudiantesInscritos
            // 
            this.rEstudiantesInscritos.Controls.Add(this.documentViewer1);
            this.rEstudiantesInscritos.HorizontalScrollbarBarColor = true;
            this.rEstudiantesInscritos.HorizontalScrollbarHighlightOnWheel = false;
            this.rEstudiantesInscritos.HorizontalScrollbarSize = 10;
            this.rEstudiantesInscritos.Location = new System.Drawing.Point(4, 38);
            this.rEstudiantesInscritos.Name = "rEstudiantesInscritos";
            this.rEstudiantesInscritos.Size = new System.Drawing.Size(708, 439);
            this.rEstudiantesInscritos.TabIndex = 0;
            this.rEstudiantesInscritos.Text = "Listado General Estudiantes Inscritos";
            this.rEstudiantesInscritos.VerticalScrollbarBarColor = true;
            this.rEstudiantesInscritos.VerticalScrollbarHighlightOnWheel = false;
            this.rEstudiantesInscritos.VerticalScrollbarSize = 10;
            // 
            // rListadoGeneralAsistencia
            // 
            this.rListadoGeneralAsistencia.Controls.Add(this.metroDateTime1);
            this.rListadoGeneralAsistencia.HorizontalScrollbarBarColor = true;
            this.rListadoGeneralAsistencia.HorizontalScrollbarHighlightOnWheel = false;
            this.rListadoGeneralAsistencia.HorizontalScrollbarSize = 10;
            this.rListadoGeneralAsistencia.Location = new System.Drawing.Point(4, 38);
            this.rListadoGeneralAsistencia.Name = "rListadoGeneralAsistencia";
            this.rListadoGeneralAsistencia.Size = new System.Drawing.Size(708, 439);
            this.rListadoGeneralAsistencia.TabIndex = 1;
            this.rListadoGeneralAsistencia.Text = "Listado General de Asistencia";
            this.rListadoGeneralAsistencia.VerticalScrollbarBarColor = true;
            this.rListadoGeneralAsistencia.VerticalScrollbarHighlightOnWheel = false;
            this.rListadoGeneralAsistencia.VerticalScrollbarSize = 10;
            this.rListadoGeneralAsistencia.Click += new System.EventHandler(this.rListadoGeneralAsistencia_Click);
            // 
            // rHistorialParticipacion
            // 
            this.rHistorialParticipacion.HorizontalScrollbarBarColor = true;
            this.rHistorialParticipacion.HorizontalScrollbarHighlightOnWheel = false;
            this.rHistorialParticipacion.HorizontalScrollbarSize = 10;
            this.rHistorialParticipacion.Location = new System.Drawing.Point(4, 38);
            this.rHistorialParticipacion.Name = "rHistorialParticipacion";
            this.rHistorialParticipacion.Size = new System.Drawing.Size(708, 439);
            this.rHistorialParticipacion.TabIndex = 2;
            this.rHistorialParticipacion.Text = "Historial de Participación";
            this.rHistorialParticipacion.VerticalScrollbarBarColor = true;
            this.rHistorialParticipacion.VerticalScrollbarHighlightOnWheel = false;
            this.rHistorialParticipacion.VerticalScrollbarSize = 10;
            // 
            // rAsistencia
            // 
            this.rAsistencia.HorizontalScrollbarBarColor = true;
            this.rAsistencia.HorizontalScrollbarHighlightOnWheel = false;
            this.rAsistencia.HorizontalScrollbarSize = 10;
            this.rAsistencia.Location = new System.Drawing.Point(4, 38);
            this.rAsistencia.Name = "rAsistencia";
            this.rAsistencia.Size = new System.Drawing.Size(708, 439);
            this.rAsistencia.TabIndex = 3;
            this.rAsistencia.Text = "Asistencia";
            this.rAsistencia.VerticalScrollbarBarColor = true;
            this.rAsistencia.VerticalScrollbarHighlightOnWheel = false;
            this.rAsistencia.VerticalScrollbarSize = 10;
            // 
            // documentViewer1
            // 
            this.documentViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.documentViewer1.DocumentSource = typeof(SIGEA_PAA.Reports.listadoGeneralEstudiantesInscritos);
            this.documentViewer1.IsMetric = true;
            this.documentViewer1.Location = new System.Drawing.Point(0, 0);
            this.documentViewer1.Name = "documentViewer1";
            this.documentViewer1.ShowPageMargins = false;
            this.documentViewer1.Size = new System.Drawing.Size(708, 439);
            this.documentViewer1.TabIndex = 2;
            // 
            // metroDateTime1
            // 
            this.metroDateTime1.Location = new System.Drawing.Point(254, 205);
            this.metroDateTime1.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTime1.Name = "metroDateTime1";
            this.metroDateTime1.Size = new System.Drawing.Size(200, 29);
            this.metroDateTime1.TabIndex = 2;
            // 
            // Modulo_Reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroTabControl1);
            this.Name = "Modulo_Reportes";
            this.Size = new System.Drawing.Size(716, 481);
            this.Load += new System.EventHandler(this.Modulo_Reportes_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.rEstudiantesInscritos.ResumeLayout(false);
            this.rListadoGeneralAsistencia.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage rEstudiantesInscritos;
        private MetroFramework.Controls.MetroTabPage rListadoGeneralAsistencia;
        private MetroFramework.Controls.MetroTabPage rHistorialParticipacion;
        private MetroFramework.Controls.MetroTabPage rAsistencia;
        private DevExpress.XtraPrinting.Preview.DocumentViewer documentViewer1;
        private MetroFramework.Controls.MetroDateTime metroDateTime1;
    }
}
