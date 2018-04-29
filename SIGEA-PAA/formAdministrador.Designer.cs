namespace SIGEA_PAA
{
    partial class formAdministrador
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBoxOperaciones = new System.Windows.Forms.GroupBox();
            this.Btn_Salir = new MetroFramework.Controls.MetroButton();
            this.Btn_Administrar_Usuario = new MetroFramework.Controls.MetroButton();
            this.Btn_Administrar_Empleado = new MetroFramework.Controls.MetroButton();
            this.toolTipBusquedaEmpleado = new System.Windows.Forms.ToolTip(this.components);
            this.Panel1 = new MetroFramework.Controls.MetroPanel();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.labelUsuario = new MetroFramework.Controls.MetroLabel();
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBoxOperaciones.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxOperaciones
            // 
            this.groupBoxOperaciones.Controls.Add(this.Btn_Salir);
            this.groupBoxOperaciones.Controls.Add(this.Btn_Administrar_Usuario);
            this.groupBoxOperaciones.Controls.Add(this.Btn_Administrar_Empleado);
            this.groupBoxOperaciones.Location = new System.Drawing.Point(20, 95);
            this.groupBoxOperaciones.Name = "groupBoxOperaciones";
            this.groupBoxOperaciones.Size = new System.Drawing.Size(350, 554);
            this.groupBoxOperaciones.TabIndex = 1;
            this.groupBoxOperaciones.TabStop = false;
            this.groupBoxOperaciones.Text = "Operaciones";
            // 
            // Btn_Salir
            // 
            this.Btn_Salir.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Btn_Salir.Location = new System.Drawing.Point(3, 528);
            this.Btn_Salir.Name = "Btn_Salir";
            this.Btn_Salir.Size = new System.Drawing.Size(344, 23);
            this.Btn_Salir.TabIndex = 2;
            this.Btn_Salir.Text = "Cerrar Sesion";
            this.Btn_Salir.UseSelectable = true;
            this.Btn_Salir.Click += new System.EventHandler(this.Btn_Salir_Click);
            // 
            // Btn_Administrar_Usuario
            // 
            this.Btn_Administrar_Usuario.Location = new System.Drawing.Point(38, 251);
            this.Btn_Administrar_Usuario.Name = "Btn_Administrar_Usuario";
            this.Btn_Administrar_Usuario.Size = new System.Drawing.Size(280, 30);
            this.Btn_Administrar_Usuario.TabIndex = 1;
            this.Btn_Administrar_Usuario.Text = "Administrar Usuarios";
            this.Btn_Administrar_Usuario.UseSelectable = true;
            this.Btn_Administrar_Usuario.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // Btn_Administrar_Empleado
            // 
            this.Btn_Administrar_Empleado.Location = new System.Drawing.Point(38, 177);
            this.Btn_Administrar_Empleado.Name = "Btn_Administrar_Empleado";
            this.Btn_Administrar_Empleado.Size = new System.Drawing.Size(280, 30);
            this.Btn_Administrar_Empleado.TabIndex = 0;
            this.Btn_Administrar_Empleado.Text = "Administrar Empleados";
            this.Btn_Administrar_Empleado.UseSelectable = true;
            this.Btn_Administrar_Empleado.Click += new System.EventHandler(this.btnAdministrarEmpleados_Click);
            // 
            // toolTipBusquedaEmpleado
            // 
            this.toolTipBusquedaEmpleado.AutomaticDelay = 100;
            this.toolTipBusquedaEmpleado.Tag = "";
            // 
            // Panel1
            // 
            this.Panel1.HorizontalScrollbarBarColor = true;
            this.Panel1.HorizontalScrollbarHighlightOnWheel = false;
            this.Panel1.HorizontalScrollbarSize = 10;
            this.Panel1.Location = new System.Drawing.Point(482, 92);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(651, 554);
            this.Panel1.TabIndex = 2;
            this.Panel1.VerticalScrollbarBarColor = true;
            this.Panel1.VerticalScrollbarHighlightOnWheel = false;
            this.Panel1.VerticalScrollbarSize = 10;
            this.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.labelUsuario);
            this.metroPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(20, 60);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(1206, 29);
            this.metroPanel2.TabIndex = 3;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.Location = new System.Drawing.Point(4, 4);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(83, 19);
            this.labelUsuario.TabIndex = 2;
            this.labelUsuario.Text = "metroLabel1";
            // 
            // formAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1246, 658);
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.groupBoxOperaciones);
            this.MaximizeBox = false;
            this.Movable = false;
            this.Name = "formAdministrador";
            this.Resizable = false;
            this.Text = "SIGEA-PAA | Administrador";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.formAdministrador_Load);
            this.groupBoxOperaciones.ResumeLayout(false);
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }


        #endregion
        private System.Windows.Forms.GroupBox groupBoxOperaciones;
        private MetroFramework.Controls.MetroButton Btn_Administrar_Empleado;

        private MetroFramework.Controls.MetroGrid metroGrid3;
        private MetroFramework.Controls.MetroTabControl metroTabControl4;
        private MetroFramework.Controls.MetroTabPage metroTabPage6;
        private MetroFramework.Controls.MetroTabPage metroTabPage7;
        private MetroFramework.Controls.MetroButton metroButton7;
        private System.Windows.Forms.BindingSource usuariosBindingSource;
        private System.Windows.Forms.ToolTip toolTipBusquedaEmpleado;
        private MetroFramework.Controls.MetroButton Btn_Administrar_Usuario;
        private MetroFramework.Controls.MetroPanel Panel1;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroButton Btn_Salir;
        private MetroFramework.Controls.MetroLabel labelUsuario;
    }
}

