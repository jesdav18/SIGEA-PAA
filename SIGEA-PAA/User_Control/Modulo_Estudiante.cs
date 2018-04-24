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

        private void Txt_Nombre_Click(object sender, EventArgs e)
        {

        }

        private void gb_Estudiante_Enter(object sender, EventArgs e)
        {

        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Txt_Cuenta_Edicion_Click(object sender, EventArgs e)
        {
            
        }

        

        private void Btn_Buscar_Edicion_Click_1(object sender, EventArgs e)
        {

        }

        private void GroupBox_Estudiante_Edicion_Enter(object sender, EventArgs e)
        {

        }

        private void Cmb_Carrera_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Btn_Registrar_Click(object sender, EventArgs e)
        {
            try
            {
                Utilidades util = new Utilidades();
                util.TransaccionEstudiante("spU_Estudiante", Txt_Cuenta.Text.Trim(), Txt_Nombre.Text.Trim(), Txt_Identidad.Text.Trim(),Convert.ToInt32(Cmb_Carrera.SelectedValue.ToString()), Sesion);
                MetroFramework.MetroMessageBox.Show(formEquipoApoyo.ActiveForm, "Estudiante Registrado");
            }
            catch (Exception E)
            {
                MetroFramework.MetroMessageBox.Show(formEquipoApoyo.ActiveForm, "Algo salió mal" + E.ToString());

            }
        }

        private void Btn_Buscar_Edicion_Click_2(object sender, EventArgs e)
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
                Btn_Actualizar_Edicion.Enabled = true;


            }

         }

        private void Txt_Busqueda_Edicion_TextChanged(object sender, EventArgs e)
        {
            Txt_Cuenta_Edicion.Text = "";
            Txt_Identidad_Edicion.Text = "";
            Txt_Nombre_Edicion.Text = "";
            Cmb_Carrera_Edicion.Text = "";
            Btn_Actualizar_Edicion.Enabled = false;
        }

        private void Btn_Actualizar_Edicion_Click(object sender, EventArgs e)
        {
            try
            {
                Utilidades util = new Utilidades();
                util.TransaccionEstudiante("spU_Estudiante", Txt_Cuenta_Edicion.Text.Trim(), Txt_Nombre_Edicion.Text.Trim(), Txt_Identidad_Edicion.Text.Trim(), Convert.ToInt32(Cmb_Carrera.SelectedValue.ToString()), Sesion);
                MetroFramework.MetroMessageBox.Show(formEquipoApoyo.ActiveForm, "Estudiante Registrado");
            }
            catch (Exception E)
            {
                MetroFramework.MetroMessageBox.Show(formEquipoApoyo.ActiveForm, "Algo salió mal" + E.ToString());

            }
        }

        private void metroTabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
