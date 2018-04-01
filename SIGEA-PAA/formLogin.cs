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
using System.Data.SqlClient;

namespace SIGEA_PAA
{
    public partial class formLogin : MetroFramework.Forms.MetroForm
    {
        Mensajes mensajeUsuario = new Mensajes();

        public formLogin()
        {
            InitializeComponent();
        }

        public void limpiarCajasTextoLogin()
        {
            textBoxContrasenia.Text = "";
            textBoxUsuario.Text = "";
        }

        private void formLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            SqlDataReader lectorBD; //LEERÁ DATOS ARROJADOS POR STORED PROCEDURE DE LOGIN
            bool tieneAcceso; //ESTADO DEL ACCESO: VERDADERO O FALSO
            Control etiqueta; // CONTROL QUE PERMITIRÁ MOSTRAR MENSAJE EN PANTALLA
            

            Conexiones.Conexion conexionBD = new Conexiones.Conexion();
           

            lectorBD = conexionBD.validarCredencialesDeAcceso("Data Source=BART-SIMPSON\\BART;Initial Catalog=SIGEA-PAA;Integrated Security=True", "spLogin", "@usuario", "@contrasenia", textBoxUsuario.Text.Trim(), textBoxContrasenia.Text.Trim());
            lectorBD.Read();
            tieneAcceso = Convert.ToBoolean(lectorBD.GetValue(0));

            if (tieneAcceso == true) 
                etiqueta = mensajeUsuario.crearMensajeEnPantalla("Bienvenido",98 ,244 , tieneAcceso,11);
          
            else
                etiqueta = mensajeUsuario.crearMensajeEnPantalla("Usuario o Contraseña Incorrectos", 98, 244, tieneAcceso, 11);

            Controls.Add(etiqueta);
            
        }

        private void textBoxUsuario_TextChanged(object sender, EventArgs e)
        {
            mensajeUsuario.limpiarMensajeEnPantalla();
        }

        private void textBoxContrasenia_TextChanged(object sender, EventArgs e)
        {
            mensajeUsuario.limpiarMensajeEnPantalla();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiarCajasTextoLogin();
        }
    }
}
