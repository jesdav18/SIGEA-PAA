using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bankivoide;
using MetroFramework;

namespace SIGEA_PAA.User_Control
{
    public partial class Modulo_Estudiante : MetroFramework.Controls.MetroUserControl
    {
        public string Sesion { get; set; }
        Mensajes msjRetroalimentacion = new Mensajes();//OBJETO QUE SERVIRÁ PARA MOSTRAR MENSAJES EN PANTALLA.

        public Modulo_Estudiante()
        {
            InitializeComponent();
        }
        private static Modulo_Estudiante _instancia;

        public static Modulo_Estudiante Instancia
        {
            get
            {
                if (_instancia == null)
                    _instancia = new Modulo_Estudiante();
                return _instancia;
            }
        }
        private void Modulo_Estudiante_Load(object sender, EventArgs e)
        {
            DataTable dt;
            Conexiones.Conexion conex = new Conexiones.Conexion();
            dt = new DataTable();
            dt.Load(conex.traerDatos("spV_MostrarCarrera"));

            Cmb_Carrera.ValueMember = "codigoCarrera";
            Cmb_Carrera.DisplayMember = "nombreCarrera";
            Cmb_Carrera.DataSource = dt;

            Cmb_Carrera_Edicion.ValueMember = "codigoCarrera";
            Cmb_Carrera_Edicion.DisplayMember = "nombreCarrera";
            Cmb_Carrera_Edicion.DataSource = dt;

        }

        private void Btn_Registrar_Click(object sender, EventArgs e)
        {
            string evaluador = "";
            Utilidades util = new Utilidades();
            evaluador = util.TransaccionEstudiante("spR_Estudiante", txtCuenta.Text.Trim(), Txt_Nombre.Text.Trim(), txtIdentidad.Text.Trim(), Convert.ToInt32(Cmb_Carrera.SelectedValue.ToString()),Txt_Telefono.Text,(Txt_Correo_Registro + labelArroba.Text + Txt_Dominio.Text), Sesion);
            switch (evaluador)
            {

                case "0":
                    MetroFramework.MetroMessageBox.Show(this, "El estudiante ya está registrado, revise la información ingresada", "SIGEA-PPA", MessageBoxButtons.OK, MessageBoxIcon.Warning, 100);
                    break;

                case "1":
                    MetroFramework.MetroMessageBox.Show(this, "Estudiante Registrado con éxito","SIGEA-PAA", MessageBoxButtons.OK, MessageBoxIcon.Information, 100);
                    LimpiarCajasTexto();
                    break;
                case "2":
                    MetroFramework.MetroMessageBox.Show(this, "Algo salió mal, por favor, vuelva a intentarlo","SIGEA-PAA" ,MessageBoxButtons.OK, MessageBoxIcon.Error, 100);
                    break;

            }

        }

        private void Txt_Busqueda_Edicion_TextChanged(object sender, EventArgs e)
        {
            
            Txt_Cuenta_Edicion.Text = "";
            Txt_Identidad_Edicion.Text = "";
            Txt_Nombre_Edicion.Text = "";
            Cmb_Carrera_Edicion.Text = "";
            Txt_Correo_Editar.Text = "";
            Txt_Telefono_Editar.Text = "";
            Btn_Actualizar_Edicion.Enabled = false;

        }

        private void Btn_Actualizar_Edicion_Click(object sender, EventArgs e)
        {


            string evaluador = "";
            Utilidades util = new Utilidades();
            evaluador=util.TransaccionEstudiante("spU_Estudiante", Txt_Cuenta_Edicion.Text.Trim(), Txt_Nombre_Edicion.Text.Trim(), Txt_Identidad_Edicion.Text.Trim(), Convert.ToInt32(Cmb_Carrera.SelectedValue.ToString()), Txt_Telefono_Editar.Text.Trim(), Txt_Correo_Editar.Text.Trim(), Sesion);
            
            switch (evaluador)
            {

                case "1":
                    MetroFramework.MetroMessageBox.Show(this, "Estudiante Actualizado");
                    break;
                case "2":
                    MetroFramework.MetroMessageBox.Show(this, "Algo Paso");
                    break;

            }

        }

       

        private void Btn_Buscar_Edicion_Click(object sender, EventArgs e)
        {

            Conexiones.Conexion cone = new Conexiones.Conexion();
            DataRow dr = cone.busquedaDatos(Txt_Busqueda_Edicion.Text, "spB_ConsultaEstudiante", "@Cuenta").Rows[0];

            //SI EL NÚMERO DE COLUMNAS QUE DEVUELVE LA FUNCION "busquedaDatos" A TRAVÉS DEL DATATABLE ES IGUAL A 1, SIGNIFICA QUE
            //EL ESTUDIANTE NO EXISTE. CASO CONTRARIO, EL ESTUDIANTE SE ENCONTRÓ, Y SE LLENAN LAS CAJAS DE TEXTO CON SU INFORMACIÓN.

            if (dr.Table.Columns.Count.ToString() == "1")
            {
                Btn_Actualizar_Edicion.Enabled = false;
                Controls.Add(msjRetroalimentacion.crearMensajeEnPantalla("ESTE ESTUDIANTE NO EXISTE", 115, 132, false, 9));
            }
            else
            {
                //MOSTRANDO INFORMACION DE ESTUDIANTE

                Txt_Cuenta_Edicion.Text = dr[2].ToString();
                Txt_Nombre_Edicion.Text = dr[1].ToString();
                Txt_Identidad_Edicion.Text = dr[3].ToString();
                Cmb_Carrera_Edicion.Text = dr[4].ToString();
                Txt_Telefono_Editar.Text = dr[5].ToString();
                Txt_Correo_Registro.Text = dr[6].ToString();
                Btn_Actualizar_Edicion.Enabled = true;


            }
        }

      

        public void LimpiarCajasTexto()
        {
            txtCuenta.Text = "";
            Txt_Nombre.Text = "";
            txtIdentidad.Text = "";
            Txt_Correo_Registro.Text = "";
            Txt_Telefono.Text = "";
            
        }

        int contadorEspacio = 0;
        int contadorC = 0;
        private void Txt_Nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar));
            Txt_Nombre.Text = Txt_Nombre.Text.Replace(" ", " ");
            Txt_Nombre.Select(Txt_Nombre.Text.Length, 0);
        }

        private void Txt_Telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar));
            Txt_Telefono.Text= Txt_Telefono.Text.Replace(" ", " ");
           Txt_Telefono.Select(Txt_Telefono.Text.Length, 0);
        }


        private void Cmb_Carrera_KeyDown(object sender, KeyEventArgs e)
        {
            Cmb_Carrera.DroppedDown = true;
        }
    }
}
