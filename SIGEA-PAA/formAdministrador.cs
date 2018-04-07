using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using Bankivoide;


namespace SIGEA_PAA
{
    public partial class formAdministrador : MetroFramework.Forms.MetroForm
    {
        string sesion;

        public formAdministrador(string _sesion, string _nombreUsuarioSesion)
        {
            InitializeComponent();
            sesion = _sesion;
            labelUsuario.Text = "Bienvenido " + _nombreUsuarioSesion;
        }

        private void formAdministrador_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla '_SIGEA_PAADataSet1.Usuarios' Puede moverla o quitarla según sea necesario.
            this.usuariosTableAdapter.Fill(this._SIGEA_PAADataSet1.Usuarios);
            // TODO: esta línea de código carga datos en la tabla '_SIGEA_PAA_Empleados.Empleados' Puede moverla o quitarla según sea necesario.
            this.empleadosTableAdapter.Fill(this._SIGEA_PAA_Empleados.Empleados);
            // TODO: esta línea de código carga datos en la tabla '_SIGEA_PAA_Usuarios.Usuarios' Puede moverla o quitarla según sea necesario.
           

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {

                Conexiones.Conexion nConexion = new Conexiones.Conexion();
                //
                nConexion.busquedaCadena(Convert.ToInt32(textBox1.Text), "spBusquedaEmpleado", "@usuario");
                
    
                
               
                
               
            }
            catch (Exception E)
            {
                MessageBox.Show("ALGO SALIÓ MAL: " + E.ToString());

            }
        }

        private void metroTabPage3_Click(object sender, EventArgs e)
        {

        }

        private void metroTabControl2_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}
