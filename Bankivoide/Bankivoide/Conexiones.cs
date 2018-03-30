using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;


namespace Bankivoide
{
    public class Conexiones
    {
        public class Conexion
        {
            SqlConnection vConexion;
            SqlCommand vComando;

            public SqlDataReader validarCredencialesDeAcceso<Template>(string _cadenaConexion, string _spAutenticacion, string _paramUsuario, string _paramContrasenia, Template _usuario, Template _contrasenia)
            {
                //_cadenaConexion : EL USUARIO MANDA COMO CADENA DE TEXTO EL CONTENIDO DE LA PROPIEDAD "ConnectionString" DE LA CONEXIÓN A LA BASE DE DATOS.
                //_spAutenticacion : EL NOMBRE DADO EN EL SERVIDOR SQL-SERVER AL PROCEDIMIENTO ALMACENADO QUE EVALUA LAS CREDENCIALES.
                //_paramUsuario : "NOMBRE DEL PARAMETRO ESPECIFICADO EN EL PROCEDIMIENTO QUE EVALUA CREDENCIALES EN EL SERVIDOR SQL-SERVER PARA QUE RECIBA EL "USERNAME"
                //_paramContrasenia : "NOMBRE DEL PARAMETRO ESPECIFICADO EN EL PROCEDIMIENTO QUE EVALUA CREDENCIALES EN EL SERVIDOR SQL-SERVER PARA QUE RECIBA EL "PASSWORD"
                //_usuario : VALORES QUE SE INGRESEN EN LA CAJA DE TEXTO USUARIO DEL FORMULARIO LOGIN
                //_contrasenia : VALORES QUE SE INGRESEN EN LA CAJA DE TEXTO USUARIO DEL FORMULARIO LOGIN
                
                SqlDataReader resultado;

                //IR A COMPARAR LO QUE EL USUARIO INGRESE EN LAS CAJAS DE TEXTO CORRESPONDIENTES A USUARIO Y CONTRASEÑA RESPECTIVAMENTE, CON LO REGISTRADO EN TABLA DE USUARIOS , EN LA BASE DE DATOS.
                try
                {

                    vConexion = new SqlConnection(_cadenaConexion);
                    vConexion.Open();
                    vComando = new SqlCommand(_spAutenticacion, vConexion);
                    vComando.CommandType = CommandType.StoredProcedure;


                    vComando.Parameters.Add(_paramUsuario, SqlDbType.Int).Value = _usuario; //SE LE MANDA EL TEXTO QUE SE INGRESE EN LA CAJA DE TEXTO DE USUARIO DEL FORM LOGIN.
                    vComando.Parameters.Add(_paramContrasenia, SqlDbType.VarChar, 80).Value = _contrasenia; //SE LE MANDA EL TEXTO QUE SE INGRESE EN LA CAJA DE TEXTO DE CONTRASEÑA DEL FORM LOGIN


                    resultado = vComando.ExecuteReader();
                    return resultado;

                }
                catch (Exception E)
                {
                    resultado = null;
                    MessageBox.Show("ALGO SALIÓ MAL: " + E.ToString());
                    return resultado;
                }
            }//FIN FUNCIÓN "validarCredencialesDeAcceso"

            public void finalizarConexion()
            {
                vConexion.Container.Remove(vConexion);
                vConexion.Dispose();

            }//FIN FUNCIÓN "finalizarConexion"


        }//FIN DE CLASE "Conexion"

    }
}
