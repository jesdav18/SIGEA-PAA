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
          

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {

                Conexiones.Conexion nConexion = new Conexiones.Conexion();
                
               
               //nConexion.busquedaCadena(Convert.ToInt32(textBusquedaEmpleado.Text), "spBusquedaEmpleado", "@codigoEmpleado");
              
                

            }
             catch (Exception E)
            {
                MessageBox.Show("ALGO SALIÓ MAL: " + E.ToString());

            }
        }

        private void btnAdministrarEmpleados_Click(object sender, EventArgs e)
        {
            Panel1.Controls.Clear();
            if (!Panel1.Controls.Contains(User_Control.Modulo_Empleado.Instancia))  /*Determina si el Panel Contiene el Modulo X  */
            {
                Panel1.Controls.Add(User_Control.Modulo_Empleado.Instancia);       /*Si no esta, lo Carga*/

                User_Control.Modulo_Empleado.Instancia.Dock = DockStyle.Fill;
                User_Control.Modulo_Empleado.Instancia.Sesion = sesion;
                BringToFront();
            }
            else
                User_Control.Modulo_Empleado.Instancia.BringToFront();
        }

        private void textBusquedaCodigoEmpleado_TextChanged(object sender, EventArgs e)
        {

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Panel1.Controls.Clear();
            if (!Panel1.Controls.Contains(User_Control.Modulo_Usuario.Instancia))  /*Determina si el Panel Contiene el Modulo X  */
            {
                Panel1.Controls.Add(User_Control.Modulo_Usuario.Instancia);       /*Si no esta, lo Carga*/

                User_Control.Modulo_Usuario.Instancia.Dock = DockStyle.Fill;
                User_Control.Modulo_Usuario.Instancia.Sesion = sesion;
                BringToFront();
            }
            else
                User_Control.Modulo_Usuario.Instancia.BringToFront();

        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            
            Close();
        }
    }
}
