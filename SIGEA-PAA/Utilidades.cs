using System;
using Bankivoide;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroFramework;
using MetroFramework.Forms;

namespace SIGEA_PAA
{
    class Utilidades
    {
        public int buscarEstadoEstudiante(string _cuenta)
        {
            int s = 0;
            return s;
        }

        public int determinarSiEstudianteInscrito()
        {
            int cantidad = 0;

            return cantidad;
        }

        public void inscripcionEstudiante<template>(string _procedimiento, template _cuenta, string _usuario)
        {
            try
            {
                SqlCommand vComando;
                Conexiones.Conexion conex = new Conexiones.Conexion();

                vComando = new SqlCommand(_procedimiento, conex.crearConexion());
                vComando.CommandType = CommandType.StoredProcedure;

                vComando.Parameters.Add("@Cuenta", System.Data.SqlDbType.VarChar).Value = _cuenta;
                vComando.Parameters.Add("@Usuario", System.Data.SqlDbType.VarChar).Value = _usuario;


                vComando.ExecuteNonQuery();
            }
            catch (Exception E)
            {
                MetroMessageBox.Show(formEquipoApoyo.ActiveForm, "Algo salió mal" + E.ToString());

            }
        }

        public string TransaccionEstudiante(string _procedimiento, string _cuenta, string _estudiante, string _identidad, int _carrera, string _telefono, string _correo, string _usuario)
        {
            try
            {
                Conexiones.Conexion conex = new Conexiones.Conexion();
                SqlCommand vComando;
                SqlDataReader DR;

                vComando = new SqlCommand(_procedimiento, conex.crearConexion());
                vComando.CommandType = CommandType.StoredProcedure;
                vComando.Parameters.Add("@Cuenta", SqlDbType.VarChar).Value = _cuenta;
                vComando.Parameters.Add("@Usuario", SqlDbType.VarChar).Value = _usuario;
                vComando.Parameters.Add("@Estudiante", SqlDbType.VarChar).Value = _estudiante;
                vComando.Parameters.Add("@Identidad", SqlDbType.VarChar).Value = _identidad;
                vComando.Parameters.Add("@Carrera", SqlDbType.Int).Value = _carrera;
                vComando.Parameters.Add("@Telefono", SqlDbType.VarChar).Value = _telefono;
                vComando.Parameters.Add("@Correo", SqlDbType.VarChar).Value = _correo;
                DR = vComando.ExecuteReader();
                DR.Read();
                return DR.GetValue(0).ToString();

            }
            catch (Exception)
            {

                return "2";
            }

        }

        internal int Diferencia_Fechas(object date1, DateTime date2)
        {
            throw new NotImplementedException();
        }

        public string RegistrarAsistencia<template>(string _procedimiento, template _cuenta, string _usuario)//Agregue instancia Usuario
        {
            try
            {

                SqlCommand vComando;
                Conexiones.Conexion conex = new Conexiones.Conexion();
                SqlDataReader DR;
                vComando = new SqlCommand(_procedimiento, conex.crearConexion());
                vComando.CommandType = CommandType.StoredProcedure;

                vComando.Parameters.Add("@Cuenta", System.Data.SqlDbType.VarChar).Value = _cuenta;
                vComando.Parameters.Add("@Usuario", SqlDbType.VarChar).Value = _usuario;
                DR = vComando.ExecuteReader();
                DR.Read();
                return DR.GetValue(0).ToString();

            }

            catch (Exception)
            {
                return "3";
            }

        }
        public string RegistrarPAA<template>(string _procedimiento, template _paa, string _inicioPaa, string _finalPaa, string _inicioInscripcion, string _finalInscripcion, int _cupos, string _usuario)
        {
            try
            {
                SqlCommand vComando;
                Conexiones.Conexion conex = new Conexiones.Conexion();
                SqlDataReader DR;
                vComando = new SqlCommand(_procedimiento, conex.crearConexion());
                vComando.CommandType = CommandType.StoredProcedure;

                vComando.Parameters.Add("@CodigoPAA", SqlDbType.VarChar).Value = _paa;
                vComando.Parameters.Add("@codigoUsuario", SqlDbType.VarChar).Value = _usuario;
                vComando.Parameters.Add("@fechaInicio", SqlDbType.VarChar).Value = _inicioPaa;

                vComando.Parameters.Add("@fechaFinal", SqlDbType.VarChar).Value = _finalPaa;
                vComando.Parameters.Add("@fechaInicioInscripcionPAA", SqlDbType.VarChar).Value = _inicioInscripcion;
                vComando.Parameters.Add("@fechaFinalInscripcionPAA", SqlDbType.VarChar).Value = _finalInscripcion;
                vComando.Parameters.Add("@Cupos", SqlDbType.Int).Value = _cupos;
                DR = vComando.ExecuteReader();
                DR.Read();
                return DR.GetValue(0).ToString();
            }
            catch (Exception)
            {
                return "2";

            }


        }
        

         

        public int Diferencia_Fechas(DateTime _fecha1, DateTime _fecha2)
        {

            DateTime fecha1 = _fecha1;
            DateTime fecha2 = _fecha2;
            TimeSpan diferencia = fecha2 - fecha1;
            int dias = diferencia.Days;
            return dias;

        }

        public string RegistrarUsuario(string _procedimiento, string _codigoUsuario, string _password, int _codigoEmpleado, int _tipoAcceso, string _usuario)
        {
            try
            {
                SqlCommand vComando;
                Conexiones.Conexion conex = new Conexiones.Conexion();
                SqlDataReader DR;
                vComando = new SqlCommand(_procedimiento, conex.crearConexion());
                vComando.CommandType = CommandType.StoredProcedure;
                vComando.Parameters.Add("@CodigoUsuario2", SqlDbType.VarChar).Value = _codigoUsuario;
                vComando.Parameters.Add("@Password", SqlDbType.VarChar).Value = _password;
                vComando.Parameters.Add("@CodigoEmpleado", SqlDbType.Int).Value = _codigoEmpleado;
                vComando.Parameters.Add("@TipoAcceso", SqlDbType.TinyInt).Value = _tipoAcceso;
                vComando.Parameters.Add("@codigoUsuario", SqlDbType.VarChar).Value = _usuario;
                DR = vComando.ExecuteReader();
                DR.Read();
                return DR.GetValue(0).ToString();
            }
            catch (Exception)
            {
                return "2";

            }
        }
        public SqlDataReader TraerDatos(string _procedimiento)
        {
            SqlCommand vComando;
            SqlDataReader dt;
            Conexiones.Conexion conex = new Conexiones.Conexion();
            vComando = new SqlCommand(_procedimiento, conex.crearConexion());
            vComando.CommandType = CommandType.Text;
            dt = vComando.ExecuteReader();

            return dt;
        }

        public string RegistrarEmpleado(string _procedimiento, int _codigoEmpleado, string _nombreEmpleado, string _identidadEmpleado, string _usuario)
        {
            try
            {
                SqlCommand vComando;
                Conexiones.Conexion conex = new Conexiones.Conexion();
                SqlDataReader DR;
                vComando = new SqlCommand(_procedimiento, conex.crearConexion());
                vComando.CommandType = CommandType.StoredProcedure;
                vComando.Parameters.Add("@CodigoEmpleado", SqlDbType.Int).Value = _codigoEmpleado;
                vComando.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = _nombreEmpleado;
                vComando.Parameters.Add("@Identidad", SqlDbType.VarChar).Value = _identidadEmpleado;
                vComando.Parameters.Add("@CodigoUsuario", SqlDbType.VarChar).Value = _usuario;
                DR = vComando.ExecuteReader();
                DR.Read();
                return DR.GetValue(0).ToString();
            }
            catch (Exception)
            {

                return "2";
            }

        }

        public string ActualizarEmpleado(string _procedimiento, int _codigoEmpleado, string _nombreEmpleado, string _identidadEmpleado, string _usuario, bool _estado)
        {
            try
            {

                SqlCommand vComando;
                Conexiones.Conexion conex = new Conexiones.Conexion();
                vComando = new SqlCommand(_procedimiento, conex.crearConexion());
                vComando.CommandType = CommandType.StoredProcedure;
                vComando.Parameters.Add("@codigo", SqlDbType.Int).Value = _codigoEmpleado;
                vComando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = _nombreEmpleado;
                vComando.Parameters.Add("@identidad", SqlDbType.VarChar).Value = _identidadEmpleado;
                vComando.Parameters.Add("@usuario", SqlDbType.VarChar).Value = _usuario;
                vComando.Parameters.Add("@fecha", SqlDbType.Date).Value = DateTime.Today;
                vComando.Parameters.Add("@estado", SqlDbType.Bit).Value = _estado;
                vComando.ExecuteNonQuery();
                return "1";
            }
            catch (Exception)
            {
                return "2";

            }
        }

        public DataTable busquedaEmpleado(string _procedimiento, int _clavePrimaria, string _nombreParametro)
        {
            SqlDataAdapter da;
            DataTable dt;
            Conexiones.Conexion conex = new Conexiones.Conexion();
            SqlCommand vComando;

            try
            {


                vComando = new SqlCommand(_procedimiento, conex.crearConexion());
                vComando.CommandType = CommandType.StoredProcedure;

                vComando.Parameters.Add(_nombreParametro, SqlDbType.Int).Value = _clavePrimaria;

                da = new SqlDataAdapter(vComando);
                dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception)
            {
                dt = null;
                return dt;
            }
        }

        public string ActualizarUsuario(string _procedimiento, string _codigoUsuario, string _password, int _tipoAcceso, string _usuario, string _codigousuario3)
        {
            try
            {
                SqlCommand vComando;
                Conexiones.Conexion conex = new Conexiones.Conexion();

                vComando = new SqlCommand(_procedimiento, conex.crearConexion());
                vComando.CommandType = CommandType.StoredProcedure;
                vComando.Parameters.Add("@CodigoUsuario2", SqlDbType.VarChar).Value = _codigoUsuario;
                vComando.Parameters.Add("@Password", SqlDbType.VarChar).Value = _password;
                vComando.Parameters.Add("@TipoAcceso", SqlDbType.TinyInt).Value = _tipoAcceso;
                vComando.Parameters.Add("@codigoUsuario", SqlDbType.VarChar).Value = _usuario;
                vComando.Parameters.Add("@CodigoUsuario3", SqlDbType.VarChar).Value = _codigousuario3;
                vComando.ExecuteNonQuery();
                return "1";
            }
            catch (Exception)
            {
                return "2";

            }
        }
        public string ActualizarPAA(string _procedimiento, string _paa, string _paainicio, string _paafinal, string _inscripcioninicio, string _inscripcionfinal, int _cupos, string _sesion)
        {
            try
            {
                Conexiones.Conexion conex = new Conexiones.Conexion();
                SqlCommand vComando;

                vComando = new SqlCommand(_procedimiento, conex.crearConexion());
                vComando.CommandType = CommandType.StoredProcedure;
                vComando.Parameters.Add("@CodigoPAA", SqlDbType.VarChar).Value = _paa;
                vComando.Parameters.Add("@PAAInicio", SqlDbType.Date).Value = _paainicio;
                vComando.Parameters.Add("@PAAFinal", SqlDbType.Date).Value = _paafinal;
                vComando.Parameters.Add("@InscripcionInicio", SqlDbType.Date).Value = _inscripcioninicio;
                vComando.Parameters.Add("@InscripcionFinal", SqlDbType.Date).Value = _inscripcionfinal;
                vComando.Parameters.Add("@Cupos", SqlDbType.Int).Value = _cupos;
                vComando.Parameters.Add("@codigoUsuario", SqlDbType.VarChar).Value = _sesion;
                vComando.ExecuteNonQuery();
                return "1";
            }
            catch (Exception)
            {
                return "2";


            }


        }
    }
}

