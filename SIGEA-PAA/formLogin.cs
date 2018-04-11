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
        int tipoAcceso;
        string usuario;
        string nombreUsuario;

        public formLogin()
        {
            InitializeComponent();
        }

        private void determinarPerfilDeAcceso(int _tipoAcceso, string _usuario, string _nombreUsuario)
        {
            try
            {
                switch (_tipoAcceso) //SE EVALUA TIPO DE ACCESO, O TIPO DE PRIVILEGIOS QUE TIENE EL USUARIO.
                {
                    case 1: formAdministrador nformAdministrador = new formAdministrador(_usuario,_nombreUsuario); //USUARIO ADMINISTRADOR
                        nformAdministrador.Show();
                        break; 
                    case 2: formEquipoApoyo nformEquipoApoyo = new formEquipoApoyo(_usuario,_nombreUsuario); //USUARIO NORMAL
                        nformEquipoApoyo.Show();
                        break;
                }
            }
            catch (Exception E)
            {
                MessageBox.Show("Algo salió mal: " + E.ToString());
            }
        }

        private void determinarAutenticacionUsuario()
        {
            SqlDataReader lectorBD; //LEERÁ DATOS ARROJADOS POR STORED PROCEDURE DE LOGIN
            bool tieneAcceso; //ESTADO DEL ACCESO: VERDADERO O FALSO
            Control etiqueta; // CONTROL QUE PERMITIRÁ MOSTRAR MENSAJE EN PANTALLA

            Conexiones.Conexion conexionBD = new Conexiones.Conexion(); /*SE CREA DE INSTANCIA DE LA CLASE CONEXIONES, CONTENIDA EN NAMESPACE Bankivoide PARA
                                                                         EMPEZAR A VALIDAR LAS CREDENCIALES DE ACCESO INGRESADAS.*/


            lectorBD = conexionBD.validarCredencialesDeAcceso("spLogin", "@usuario", "@contrasenia", textBoxUsuario.Text.Trim(), textBoxContrasenia.Text.Trim());
            lectorBD.Read();
            tieneAcceso = Convert.ToBoolean(lectorBD.GetValue(0)); /*SE TRAE EL VALOR DEL CAMPO TEMPORAL LLAMADO "Resultado" SI ESTE TRUE EL LOGIN ES VALIDO, 
                                                                    CASO CONTRARIO PUEDE QUE NO EXISTA O ESTÉ INCORRECTO LOS DATOS INGRESADOS.*/

            
            if (tieneAcceso == true)
            {
                //LAS CREDENCIALES SON CORRECTAS, Y SE PROCEDERÁ A DETERMINAR QUE TIPO DE ACCESO TIENE EL USUARIO PARA DIRIGIRLO A SU RESPECTIVO FORMULARIO.
                //etiqueta = mensajeUsuario.crearMensajeEnPantalla("Bienvenido", 98, 244, tieneAcceso, 11);

                usuario = Convert.ToString(lectorBD.GetValue(3)); //SE OBTIENE IDENTIFICADOR DE USUARIO LOGUEADO.
                tipoAcceso = Convert.ToInt32(lectorBD.GetValue(2)); //SE OBTIENE TIPO DE ACCESO PAR USUARIO LOGUEADO, ESTO AYUDA A SABER QUE FORMULARIO SE CARGARÁ.
                nombreUsuario = Convert.ToString(lectorBD.GetValue(1)); //SE OBTIENE NOMBRE DEL EMPLEADO QUE SE HA LOGUEADO A TRAVÉS DE UN IDENTFICADOR DE USUARIO AUTORIZADO.
                determinarPerfilDeAcceso(tipoAcceso, usuario, nombreUsuario);
            }
            else
            {
                //EL USUARIO ESCRIBIÓ MAL LA CONTRASEÑA O SU IDENTIFICADOR DE USUARIO, O EL IDENTIFICADOR DE USUARIO NO EXISTE.  
                etiqueta = mensajeUsuario.crearMensajeEnPantalla("Usuario o Contraseña Incorrectos", 76, 260, tieneAcceso, 9);
                Controls.Add(etiqueta);//MOSTRANDO MENSAJE EN PANTALLA.
            }

        }

        public void limpiarCajasTextoLogin()
        {
            textBoxContrasenia.Text = "";
            textBoxUsuario.Text = "";
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {

            determinarAutenticacionUsuario();  
            
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
