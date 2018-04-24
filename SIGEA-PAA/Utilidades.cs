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

        public void TransaccionEstudiante<template>(string _procedimiento, template _cuenta, string _estudiante, string _identidad, int _carrera, string _usuario)
        {
            try
            {
                Conexiones.Conexion conex = new Conexiones.Conexion();
                SqlCommand vComando;
                vComando = new SqlCommand(_procedimiento, conex.crearConexion());
                vComando.CommandType = CommandType.StoredProcedure;
                vComando.Parameters.Add("@Cuenta", SqlDbType.VarChar).Value = _cuenta;
                vComando.Parameters.Add("@Usuario", SqlDbType.VarChar).Value = _usuario;
                vComando.Parameters.Add("@Estudiante", SqlDbType.VarChar).Value = _estudiante;
                vComando.Parameters.Add("@Identidad", SqlDbType.VarChar).Value = _identidad;
                vComando.Parameters.Add("@Carrera", SqlDbType.Int).Value = _carrera;
                vComando.ExecuteNonQuery();

            }
            catch (Exception E)
            {

                MetroMessageBox.Show(formEquipoApoyo.ActiveForm, "Algo salió mal" + E.ToString());
            }

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
        public string RegistrarPAA<template>(string _procedimiento,template _paa, string _inicioPaa, string _finalPaa, string _inicioInscripcion, string _finalInscripcion, int _cupos, string _usuario)
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
                DR=vComando.ExecuteReader();
                DR.Read();
                return DR.GetValue(0).ToString();
            }
            catch (Exception)
            {
                return "2";
                
            }
            

        }
       
    }
}

