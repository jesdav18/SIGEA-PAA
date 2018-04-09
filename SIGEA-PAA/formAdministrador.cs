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
                
               
               nConexion.busquedaCadena(Convert.ToInt32(textBusquedaEmpleado.Text), "spBusquedaEmpleado", "@codigoEmpleado");
              


            }
            catch (Exception E)
            {
                MessageBox.Show("ALGO SALIÓ MAL: " + E.ToString());

            }
        }

        private void btnAdministrarEmpleados_Click(object sender, EventArgs e)
        {
            tabControlAdmonEmpleados.Visible = true;
        }

        private void textBusquedaCodigoEmpleado_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
