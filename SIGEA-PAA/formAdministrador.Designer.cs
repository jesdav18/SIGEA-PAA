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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelUsuario = new MetroFramework.Controls.MetroLabel();
            this.groupBoxOperaciones = new System.Windows.Forms.GroupBox();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.btnAdministrarEmpleados = new MetroFramework.Controls.MetroButton();
            this.btnBuscar = new MetroFramework.Controls.MetroButton();
            this.tabControlAdmonEmpleados = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage5 = new MetroFramework.Controls.MetroTabPage();
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.textBusquedaCodigoEmpleado = new System.Windows.Forms.TextBox();
            this.metroTabPage8 = new MetroFramework.Controls.MetroTabPage();
            this.metroButton6 = new MetroFramework.Controls.MetroButton();
            this.toolTipBusquedaEmpleado = new System.Windows.Forms.ToolTip(this.components);
            this.groupBoxInformacionEmpleado = new System.Windows.Forms.GroupBox();
            this.groupBoxInformacionUsuario = new System.Windows.Forms.GroupBox();
            this.gridInformacionEmpledo = new MetroFramework.Controls.MetroGrid();
            this.groupBoxOperaciones.SuspendLayout();
            this.tabControlAdmonEmpleados.SuspendLayout();
            this.metroTabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
            this.groupBoxInformacionEmpleado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridInformacionEmpledo)).BeginInit();
            this.SuspendLayout();
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.Location = new System.Drawing.Point(62, 80);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(81, 19);
            this.labelUsuario.TabIndex = 0;
            this.labelUsuario.Text = "labelUsuario";
            // 
            // groupBoxOperaciones
            // 
            this.groupBoxOperaciones.Controls.Add(this.metroButton3);
            this.groupBoxOperaciones.Controls.Add(this.metroButton2);
            this.groupBoxOperaciones.Controls.Add(this.btnAdministrarEmpleados);
            this.groupBoxOperaciones.Location = new System.Drawing.Point(23, 128);
            this.groupBoxOperaciones.Name = "groupBoxOperaciones";
            this.groupBoxOperaciones.Size = new System.Drawing.Size(239, 261);
            this.groupBoxOperaciones.TabIndex = 1;
            this.groupBoxOperaciones.TabStop = false;
            this.groupBoxOperaciones.Text = "Operaciones";
            // 
            // metroButton3
            // 
            this.metroButton3.Location = new System.Drawing.Point(17, 163);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(203, 23);
            this.metroButton3.TabIndex = 2;
            this.metroButton3.Text = "Operaciones Equipo de Apoyo";
            this.metroButton3.UseSelectable = true;
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(17, 125);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(203, 23);
            this.metroButton2.TabIndex = 1;
            this.metroButton2.Text = "Crear Prueba de Aptitud Académica";
            this.metroButton2.UseSelectable = true;
            // 
            // btnAdministrarEmpleados
            // 
            this.btnAdministrarEmpleados.Location = new System.Drawing.Point(17, 87);
            this.btnAdministrarEmpleados.Name = "btnAdministrarEmpleados";
            this.btnAdministrarEmpleados.Size = new System.Drawing.Size(203, 23);
            this.btnAdministrarEmpleados.TabIndex = 0;
            this.btnAdministrarEmpleados.Text = "Administración de Empleados";
            this.btnAdministrarEmpleados.UseSelectable = true;
            this.btnAdministrarEmpleados.Click += new System.EventHandler(this.btnAdministrarEmpleados_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(294, 16);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(100, 23);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseSelectable = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // tabControlAdmonEmpleados
            // 
            this.tabControlAdmonEmpleados.Controls.Add(this.metroTabPage5);
            this.tabControlAdmonEmpleados.Controls.Add(this.metroTabPage8);
            this.tabControlAdmonEmpleados.Location = new System.Drawing.Point(300, 111);
            this.tabControlAdmonEmpleados.Name = "tabControlAdmonEmpleados";
            this.tabControlAdmonEmpleados.SelectedIndex = 0;
            this.tabControlAdmonEmpleados.Size = new System.Drawing.Size(884, 494);
            this.tabControlAdmonEmpleados.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControlAdmonEmpleados.TabIndex = 5;
            this.tabControlAdmonEmpleados.Tag = "";
            this.tabControlAdmonEmpleados.UseSelectable = true;
            this.tabControlAdmonEmpleados.Visible = false;
            // 
            // metroTabPage5
            // 
            this.metroTabPage5.Controls.Add(this.groupBoxInformacionUsuario);
            this.metroTabPage5.Controls.Add(this.groupBoxInformacionEmpleado);
            this.metroTabPage5.Controls.Add(this.btnBuscar);
            this.metroTabPage5.Controls.Add(this.metroLabel2);
            this.metroTabPage5.Controls.Add(this.textBusquedaCodigoEmpleado);
            this.metroTabPage5.HorizontalScrollbarBarColor = true;
            this.metroTabPage5.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage5.HorizontalScrollbarSize = 10;
            this.metroTabPage5.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage5.Name = "metroTabPage5";
            this.metroTabPage5.Size = new System.Drawing.Size(876, 452);
            this.metroTabPage5.TabIndex = 3;
            this.metroTabPage5.Text = "Busqueda Empleado";
            this.metroTabPage5.VerticalScrollbarBarColor = true;
            this.metroTabPage5.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage5.VerticalScrollbarSize = 10;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(3, 20);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(143, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Código de Empleado: ";
            // 
            // textBusquedaCodigoEmpleado
            // 
            this.textBusquedaCodigoEmpleado.Location = new System.Drawing.Point(168, 19);
            this.textBusquedaCodigoEmpleado.Name = "textBusquedaCodigoEmpleado";
            this.textBusquedaCodigoEmpleado.Size = new System.Drawing.Size(100, 20);
            this.textBusquedaCodigoEmpleado.TabIndex = 2;
            // 
            // metroTabPage8
            // 
            this.metroTabPage8.HorizontalScrollbarBarColor = true;
            this.metroTabPage8.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage8.HorizontalScrollbarSize = 10;
            this.metroTabPage8.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage8.Name = "metroTabPage8";
            this.metroTabPage8.Size = new System.Drawing.Size(876, 348);
            this.metroTabPage8.TabIndex = 0;
            this.metroTabPage8.Text = "Agregar Empleado";
            this.metroTabPage8.VerticalScrollbarBarColor = true;
            this.metroTabPage8.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage8.VerticalScrollbarSize = 10;
            // 
            // metroButton6
            // 
            this.metroButton6.Location = new System.Drawing.Point(118, 410);
            this.metroButton6.Name = "metroButton6";
            this.metroButton6.Size = new System.Drawing.Size(113, 23);
            this.metroButton6.TabIndex = 5;
            this.metroButton6.Text = "metroButton6";
            this.metroButton6.UseSelectable = true;
            // 
            // toolTipBusquedaEmpleado
            // 
            this.toolTipBusquedaEmpleado.Tag = "";
            // 
            // groupBoxInformacionEmpleado
            // 
            this.groupBoxInformacionEmpleado.BackColor = System.Drawing.Color.White;
            this.groupBoxInformacionEmpleado.Controls.Add(this.gridInformacionEmpledo);
            this.groupBoxInformacionEmpleado.Location = new System.Drawing.Point(3, 65);
            this.groupBoxInformacionEmpleado.Name = "groupBoxInformacionEmpleado";
            this.groupBoxInformacionEmpleado.Size = new System.Drawing.Size(870, 185);
            this.groupBoxInformacionEmpleado.TabIndex = 5;
            this.groupBoxInformacionEmpleado.TabStop = false;
            this.groupBoxInformacionEmpleado.Text = "Información de Empleado";
            // 
            // groupBoxInformacionUsuario
            // 
            this.groupBoxInformacionUsuario.BackColor = System.Drawing.Color.White;
            this.groupBoxInformacionUsuario.Location = new System.Drawing.Point(3, 256);
            this.groupBoxInformacionUsuario.Name = "groupBoxInformacionUsuario";
            this.groupBoxInformacionUsuario.Size = new System.Drawing.Size(870, 142);
            this.groupBoxInformacionUsuario.TabIndex = 6;
            this.groupBoxInformacionUsuario.TabStop = false;
            this.groupBoxInformacionUsuario.Text = "Información de Usuario";
            // 
            // gridInformacionEmpledo
            // 
            this.gridInformacionEmpledo.AllowUserToResizeRows = false;
            this.gridInformacionEmpledo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridInformacionEmpledo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridInformacionEmpledo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridInformacionEmpledo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridInformacionEmpledo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridInformacionEmpledo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridInformacionEmpledo.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridInformacionEmpledo.EnableHeadersVisualStyles = false;
            this.gridInformacionEmpledo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridInformacionEmpledo.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridInformacionEmpledo.Location = new System.Drawing.Point(25, 19);
            this.gridInformacionEmpledo.Name = "gridInformacionEmpledo";
            this.gridInformacionEmpledo.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridInformacionEmpledo.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridInformacionEmpledo.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridInformacionEmpledo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridInformacionEmpledo.Size = new System.Drawing.Size(739, 150);
            this.gridInformacionEmpledo.TabIndex = 0;
            // 
            // formAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1235, 675);
            this.Controls.Add(this.tabControlAdmonEmpleados);
            this.Controls.Add(this.metroButton6);
            this.Controls.Add(this.groupBoxOperaciones);
            this.Controls.Add(this.labelUsuario);
            this.MaximizeBox = false;
            this.Movable = false;
            this.Name = "formAdministrador";
            this.Resizable = false;
            this.Text = "SIGEA-PAA | Administrador";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.formAdministrador_Load);
            this.groupBoxOperaciones.ResumeLayout(false);
            this.tabControlAdmonEmpleados.ResumeLayout(false);
            this.metroTabPage5.ResumeLayout(false);
            this.metroTabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
            this.groupBoxInformacionEmpleado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridInformacionEmpledo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private MetroFramework.Controls.MetroLabel labelUsuario;
        private System.Windows.Forms.GroupBox groupBoxOperaciones;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton btnAdministrarEmpleados;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroButton btnBuscar;
        private MetroFramework.Controls.MetroTabControl tabControlAdmonEmpleados;
        private MetroFramework.Controls.MetroTabPage metroTabPage5;
        private MetroFramework.Controls.MetroButton metroButton6;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.TextBox textBusquedaCodigoEmpleado;
        private MetroFramework.Controls.MetroTabPage metroTabPage8;
        private System.Windows.Forms.BindingSource usuariosBindingSource;
        private System.Windows.Forms.ToolTip toolTipBusquedaEmpleado;
        private System.Windows.Forms.GroupBox groupBoxInformacionUsuario;
        private System.Windows.Forms.GroupBox groupBoxInformacionEmpleado;
        private MetroFramework.Controls.MetroGrid gridInformacionEmpledo;
    }
}

