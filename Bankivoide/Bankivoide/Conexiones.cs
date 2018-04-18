using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Bankivoide
{
    public class Conexiones
    {
        public class Conexion
        {
            SqlConnection vConexion;
            SqlCommand vComando;

            public SqlConnection crearConexion()
            {
                const string _cadenaConexion = "Data Source=BART-SIMPSON\\BART;Initial Catalog=SIGEA-PAA;Integrated Security=True";
                //LA IDEA ES QUE CADA VEZ QUE SE NECESITE ACCESO  A DATOS SE HAGA UN LLAMADO A ESTA FUNCIÓN PARA ESTABLECER CONEXION.
                vConexion = new SqlConnection(_cadenaConexion);
                vConexion.Open();

                return vConexion;
            }

            public SqlDataReader validarCredencialesDeAcceso<Template>(string _spAutenticacion, string _paramUsuario, string _paramContrasenia, Template _usuario, Template _contrasenia)
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

                    /*vConexion = new SqlConnection(_cadenaConexion);
                    vConexion.Open();*/
                    vComando = new SqlCommand(_spAutenticacion, crearConexion());
                    vComando.CommandType = CommandType.StoredProcedure;


                    vComando.Parameters.Add(_paramUsuario, SqlDbType.VarChar,80).Value = _usuario; //SE LE MANDA EL TEXTO QUE SE INGRESE EN LA CAJA DE TEXTO DE USUARIO DEL FORM LOGIN.
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

            public DataTable busquedaDatos <plantilla>( plantilla _clavePrimaria, string _procedimiento, string _nombreParametro)
            {
                /*ESTE MÉTODO HACE LA BUSQUEDA DE DATOS EN LA BD  COMPARARANDO CLAVE PRIMARIA DE LA TABLA CON CLAVE PRIMARIA 
                 QUE PROVEA EL USUARIO. EL MÉTODO DEVOLVERÁ UN DATATABLE CON LOS DATOS ENCONTRADOS.
                 
                 _clavePrimaria: CLAVE PRIMARIA QUE INGRESE EL USUARIO, PUEDE SER ALGÚN CODIGO, ALGO QUE IDENTIFIQUE ALGUNA ENTIDAD.
                 _procedimiento: NOMBRE DEL PROCEDIMIENTO ALMACENADO QUE CONTIENE LAS INSTRUCCIONES PARA BUSCAR LOS DATOS.
                 _nombreParametro: NOMBRE DEL PARÁMETRO QUE SOLICITA EL PROCEDIMIENTO ALMACENADO CON LAS INSTRUCCIONES PARA BUSCAR LOS DATOS.*/

                SqlDataAdapter da;
                DataTable dt;

                try
                {
                    

                    vComando = new SqlCommand(_procedimiento, crearConexion());
                    vComando.CommandType = CommandType.StoredProcedure;

                    vComando.Parameters.Add(_nombreParametro, SqlDbType.VarChar).Value = _clavePrimaria;

                    da = new SqlDataAdapter(vComando);
                    dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
                catch (Exception E)
                {
                    dt = null;
                    return dt;
                }
            }

            public int validarExistenciaRegistro<template>(string _procedimiento,template _registro,string _paramSP)
            {
                //_procedimiento :NOMBRE DEL PROCEDIMIENTO ALMACENADO EN BD QUE HARÁ LA BUSQUEDA.
                //_registro: DATO QUE EL USUARIO INGRESE MEDIANTE ALGUNA CAJA DE TEXTO O ALGUN OTRO OBJETO COMO PARAMETRO PARA BUSQUEDA.
                //_paramSP: NOMBRE QUE SE LE DIÓ AL PARÁMETRO EN EL PROCEDIMIENTO ALMACENADO DE LA BASE DE DATOS.
                SqlDataReader reader;
                vComando = new SqlCommand(_procedimiento, crearConexion());
                vComando.CommandType = CommandType.StoredProcedure;

                vComando.Parameters.Add(_paramSP, SqlDbType.VarChar).Value = _registro;

                reader = vComando.ExecuteReader();
                reader.Read();
                return Convert.ToInt32(reader.GetValue(0).ToString());

                
            }

            public SqlDataReader traerDatos(string _procedimiento)
            {
                SqlDataReader dt;
                vComando = new SqlCommand(_procedimiento, crearConexion());
                vComando.CommandType = CommandType.StoredProcedure;
                dt = vComando.ExecuteReader();

                return dt;
            }
        }//FIN DE CLASE "Conexion"

    }
}
